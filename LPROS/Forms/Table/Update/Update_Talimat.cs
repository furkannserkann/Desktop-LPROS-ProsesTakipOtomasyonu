using LPROS.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms.Table.Update
{
    public partial class Update_Talimat : Form
    {
        public Update_Talimat()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        public String _SelectedId = "";
        public String _SelectedKod = "";
        public String _SelectedIsim = "";
        public String _SelectedAciklama = "";
        private int Nowsira = 0;

        String loadTable = "select p.Id, tp.sira as [Sıra], p.kod as [Kod], p.isim as [İsim] from Talimat_Prosesleri as tp " +
            "inner join Proses as p on p.Id=tp.proses_id " +
            "inner join Talimat as t on t.Id = tp.talimat_id " +
            "where tp.talimat_id=@parametre1 order by tp.sira asc";
        String fullTable = "select CASE WHEN Exists(select top 1 * from Talimat_Prosesleri as tp where tp.proses_id=p.Id and talimat_id=@parametre1) then 'true' else 'false' end as a, (select top 1 tp.sira from Talimat_Prosesleri as tp where tp.proses_id=p.Id and tp.talimat_id=@parametre1) as [Sira], p.Id, p.kod as [Kod], p.isim as [İsim] from Proses as p order by Kod asc";

        private void Update_Talimat_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            textbox_isim.Text = _SelectedIsim;
            textbox_kod.Text = _SelectedKod;
            textbox_aciklama.Text = _SelectedAciklama;

            checkbox_secili.Checked = true;
            datagridview_proses.DataSource = Sc.GET_DATATABLE(loadTable, new String[] { _SelectedId });

            datagridview_proses.Columns[2].Visible = false;
            for (int i = 0; i < datagridview_proses.Rows.Count; i++)
            {
                datagridview_proses.Rows[i].Cells[0].Value = true;
                datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
            }
            datagridview_proses.Columns[3].Visible = false;
            datagridview_proses.Columns["Kod"].ReadOnly = true;
            datagridview_proses.Columns["İsim"].ReadOnly = true;

            for (int i = 0; i < datagridview_proses.Columns.Count; i++)
                datagridview_proses.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

            String maxsira = Sc.GET_TEKDEGER("select max(sira) from Talimat_Prosesleri where talimat_id=@parametre1", new String[] { _SelectedId }).ToString();
            Nowsira = maxsira != "" ? int.Parse(maxsira) + 1 : 1;
        }

        private void checkbox_secili_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_secili.Checked)
            {
                datagridview_proses.DataSource = Sc.GET_DATATABLE(loadTable, new String[] { _SelectedId });

                datagridview_proses.Columns[2].Visible = false;
                for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                {
                    datagridview_proses.Rows[i].Cells[0].Value = true;
                    datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
                }
                datagridview_proses.Columns[3].Visible = false;
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;
            }
            else
            {
                datagridview_proses.DataSource = Sc.GET_DATATABLE(fullTable, new String[] { _SelectedId });

                for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                {
                    datagridview_proses.Rows[i].Cells[0].Value = Boolean.Parse(datagridview_proses.Rows[i].Cells[2].Value.ToString());
                    datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
                }
                datagridview_proses.Columns[2].Visible = false;
                datagridview_proses.Columns[3].Visible = false;
                datagridview_proses.Columns[4].Visible = false;
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;
            }
        }

        private bool _SearchProsesClear = false;
        private void Arama()
        {
            String Kod = textbox_ara_kod.Text, İsim = textbox_ara_isim.Text;

            bool TumProsesler;
            if (checkbox_secili.Checked)
                TumProsesler = false;
            else
                TumProsesler = true;


            if (!_SearchProsesClear)
            {
                if (TumProsesler)
                {
                    datagridview_proses.DataSource = Sc.GET_DATATABLE("select CASE WHEN Exists(select top 1 * from Talimat_Prosesleri as tp where tp.proses_id=p.Id and talimat_id=@parametre1) then 'true' else 'false' end as eklimi, " +
                        "(select top 1 tp.sira from Talimat_Prosesleri as tp where tp.proses_id=p.Id and tp.talimat_id=@parametre1) as [Sira], " +
                        "p.Id, p.kod as [Kod], p.isim as [İsim] from Proses as p where p.kod like '%'+@parametre2+'%' and p.isim like '%'+@parametre3+'%' order by Kod asc", new String[] { _SelectedId, Kod, İsim });

                    for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                    {
                        datagridview_proses.Rows[i].Cells[0].Value = Boolean.Parse(datagridview_proses.Rows[i].Cells[2].Value.ToString());
                        datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
                    }
                    datagridview_proses.Columns[2].Visible = false;
                    datagridview_proses.Columns[3].Visible = false;
                    datagridview_proses.Columns[4].Visible = false;
                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;
                }
                else
                {
                    datagridview_proses.DataSource = Sc.GET_DATATABLE("select p.Id, tp.sira as [Sıra], p.kod as [Kod], p.isim as [İsim] from Talimat_Prosesleri as tp " +
            "inner join Proses as p on p.Id=tp.proses_id " +
            "inner join Talimat as t on t.Id = tp.talimat_id " +
            "where tp.talimat_id=@parametre1 and p.kod like '%'+@parametre2+'%' and p.isim like '%'+@parametre3+'%' order by tp.sira asc ", new String[] { _SelectedId, Kod, İsim });

                    datagridview_proses.Columns[2].Visible = false;
                    for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                    {
                        datagridview_proses.Rows[i].Cells[0].Value = true;
                        datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
                    }
                    datagridview_proses.Columns[3].Visible = false;

                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;
                }


            }
            else
            {
                if (textbox_ara_kod.Text != "" || textbox_ara_isim.Text != "")
                {
                    textbox_ara_kod.Text = "";
                    textbox_ara_isim.Text = "";

                    datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                    _SearchProsesClear = false;
                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;
                }
            }

        }

        private void textbox_ara_TextChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void button_temizle_isim_Click(object sender, EventArgs e)
        {
            _SearchProsesClear = true;
            Arama();
        }

        private void datagridview_proses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ekle"].Index && e.RowIndex >= 0)
            {
                if ((Boolean)datagridview_proses.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    datagridview_proses.Rows[e.RowIndex].Cells[1].Value = Nowsira.ToString();
                    Sc.QUERY_TABLE("insert into Talimat_Prosesleri (talimat_id, proses_id, sira) values(@parametre1, @parametre2, @parametre3)", new string[] { _SelectedId, datagridview_proses.Rows[e.RowIndex].Cells[(checkbox_secili.Checked ? 2 : 4)].Value.ToString(), Nowsira.ToString() });

                    Nowsira++;
                }
                else
                {
                    Sc.QUERY_TABLE("delete from Talimat_Prosesleri where talimat_id=@parametre1 and proses_id=@parametre2 and sira=@parametre3", new String[] { _SelectedId, datagridview_proses.Rows[e.RowIndex].Cells[(checkbox_secili.Checked ? 2 : 4)].Value.ToString(), datagridview_proses.Rows[e.RowIndex].Cells[(checkbox_secili.Checked ? 1 : 3)].Value.ToString() });
                    datagridview_proses.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }

            if (e.ColumnIndex == senderGrid.Columns["sira"].Index && e.RowIndex >= 0)
            {

            }
        }

        private void datagridview_proses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridview_proses.Rows[e.RowIndex].Cells[1].Value.ToString() != "")
            {
                int YeniSira = int.Parse(datagridview_proses.Rows[e.RowIndex].Cells[1].Value.ToString());

                Sc.QUERY_TABLE("update Talimat_Prosesleri set sira=@parametre3 where talimat_id=@parametre1 and proses_id=@parametre2", new string[] { _SelectedId, datagridview_proses.Rows[e.RowIndex].Cells[(checkbox_secili.Checked ? 2 : 4)].Value.ToString(), YeniSira.ToString() });
                datagridview_proses.Rows[e.RowIndex].Cells[1].Value = YeniSira.ToString();

                if (YeniSira >= Nowsira)
                {
                    Nowsira = YeniSira + 1;
                }
            }
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            TalimatGüncelle();
        }

        private void TalimatGüncelle()
        {
            String kod = textbox_kod.Text, isim = textbox_isim.Text, aciklama = textbox_aciklama.Text;
            String _UpdateCode = "update Talimat set talimat_kodu=@parametre1, talimat_adi=@parametre2, aciklama=@parametre3 Where Id=@parametre4";

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Talimat Where talimat_kodu=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Talimat Where talimat_adi=@parametre1 and Id!=@parametre2";

                if (kod == _SelectedKod && isim == _SelectedIsim && aciklama == _SelectedAciklama)
                {
                    MessageBox.Show("Değişiklik Yapmadınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, isim, aciklama, _SelectedId }))
                {
                    MessageBox.Show("Talimat Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProtezTalimatProses.datagridTalimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbox_kod.Text == "")
                {
                    textbox_kod.Focus();
                }
                else if (textbox_isim.Text == "")
                {
                    textbox_isim.Focus();
                }
            }
        }

        private void textbox_talimat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                TalimatGüncelle();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
