using LPROS.Custom;
using LPROS.Forms_Panel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms.Table.Add
{
    public partial class Add_Talimat : Form
    {
        public Add_Talimat()
        {
            InitializeComponent();
        }

        int Nowsira = 1;
        SqlConnector Sc = new SqlConnector();
        public bool isUpdate = false;

        public string _SelectedId, _SelectedKod, _SelectedIsim;

        String loadTable = "select p.Id as [id], tp.sira as [Sıra], p.kod as [Kod], p.isim as [İsim] from Talimat_Prosesleri as tp " +
                           "inner join Proses as p on p.Id=tp.proses_id " +
                           "inner join Talimat as t on t.Id = tp.talimat_id " +
                           "where tp.talimat_id=@parametre1 order by tp.sira asc";
        String fullTable = "select CASE WHEN Exists(select top 1 * from Talimat_Prosesleri as tp where tp.proses_id=p.Id and talimat_id=@parametre1) then 'true' else 'false' end as a, (select top 1 tp.sira from Talimat_Prosesleri as tp where tp.proses_id=p.Id and tp.talimat_id=@parametre1) as [Sira], p.Id, p.kod as [Kod], p.isim as [İsim] from Proses as p order by Kod asc";
        DataTable loadProsesTable;

        private void Add_Talimat_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {

                label_head.Text = "Talimat Güncelle";
                button_talimat_kaydet.Text = "Talimat Bilgilerini Güncelle";

                checkbox_secili.Checked = true;
                textbox_talimat_isim.Text = _SelectedIsim;
                textbox_talimat_kod.Text = _SelectedKod;

                datagridview_proses.DataSource = Sc.GET_DATATABLE(loadTable, new String[] { _SelectedId });
                datagridview_proses.Columns["id"].Visible = false;
                datagridview_proses.Columns["Sıra"].Visible = false;
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;

                for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                {
                    datagridview_proses.Rows[i].Cells["ekle"].Value = true;
                    datagridview_proses.Rows[i].Cells["sira"].Value = datagridview_proses.Rows[i].Cells["Sıra"].Value.ToString();
                }

                string maxsira = Sc.GET_TEKDEGER("Select max(sira) from Talimat_Prosesleri where talimat_id=@parametre1", new string[] { _SelectedId });
                if (maxsira != "")
                    Nowsira = int.Parse(maxsira) + 1;

                loadProsesTable = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });

                for (int i = 0; i < datagridview_proses.Columns.Count; i++)
                {
                    datagridview_proses.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            }
            else
            {
                checkbox_secili.Visible = false;

                datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
                datagridview_proses.Columns[2].Visible = false;
                datagridview_proses.Columns["Kod"].ReadOnly = true;
                datagridview_proses.Columns["İsim"].ReadOnly = true;

                for (int i = 0; i < datagridview_proses.Columns.Count; i++)
                {
                    datagridview_proses.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
                }
            }

        }

        private void datagridview_proses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isUpdate)
            {
                UpdateCellContentClick(sender, e);
            }
            else
            {
                AddCellContentClick(sender, e);
            }
        }

        private void AddCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ekle"].Index && e.RowIndex >= 0)
            {
                if ((Boolean)datagridview_proses.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    if (datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value == null || datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value == "")
                    {
                        datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value = Nowsira.ToString();
                        Nowsira++;
                    }
                }
                else
                {
                    datagridview_proses.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }
        }

        private void UpdateCellContentClick(object sender, DataGridViewCellEventArgs e)
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
        }

        private void button_talimat_kaydet_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                TalimatUpdate();
                isUpdate = false;
            }
            else
            {
                TalimatKaydet();
            }
        }

        private void TalimatKaydet()
        {
            String kod = textbox_talimat_kod.Text, isim = textbox_talimat_isim.Text;

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Talimat Where talimat_kodu=@parametre1";
                String _QueryIsim = "select * from Talimat Where talimat_adi=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_talimat_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_talimat_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Talimat", new String[] { "talimat_kodu", "talimat_adi" }, new String[] { kod, isim }))
                {
                    String SelectTalimatId = Sc.GET_TEKDEGER("select Id from Talimat where talimat_kodu=@parametre1", new String[] { kod });


                    for (int i = 0; i < datagridview_proses.RowCount; i++)
                    {
                        if ((Boolean)datagridview_proses.Rows[i].Cells[0].EditedFormattedValue)
                        {
                            Sc.ADD_TABLE("Talimat_Prosesleri", new String[] { "proses_id", "talimat_id", "sira" },
                                new String[] { (String)datagridview_proses.Rows[i].Cells[2].Value.ToString(),
                                    (String)SelectTalimatId.ToString(),
                                    datagridview_proses.Rows[i].Cells[1].Value.ToString() });
                        }
                    }

                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_talimat_kod.Text = "";
                    textbox_talimat_isim.Text = "";
                    textbox_talimat_kod.Focus();

                    datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);

                    Items.panelTalimat.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbox_talimat_kod.Text == "")
                {
                    textbox_talimat_kod.Focus();
                }
                else if (textbox_talimat_isim.Text == "")
                {
                    textbox_talimat_isim.Focus();
                }
            }
        }

        private void textbot_talimat_kod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TalimatKaydet();
            }
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

        private void datagridview_proses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["sira"].Index && e.RowIndex >= 0)
            {
                bool siravar = false;
                for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                {
                    if (datagridview_proses.Rows[i].Cells["sira"].Value != null)
                    {
                        if (datagridview_proses.Rows[i].Cells["sira"].Value.ToString().Equals(datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value) && i != e.RowIndex)
                        {
                            siravar = true;
                        }
                    }
                }

                if (siravar)
                {
                    MessageBox.Show("Girmiş Olduğunuz Sıra Kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value = deger;
                }
                else
                {
                    try
                    {
                        if (int.Parse(datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value.ToString()) > 0)
                        {
                            if (int.Parse(datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value.ToString()) + 1 > Nowsira)
                            {
                                Nowsira = int.Parse(datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value.ToString()) + 1;
                            }

                            if (isUpdate)
                            {
                                int YeniSira = int.Parse(datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value.ToString());
                                Sc.QUERY_TABLE("update Talimat_Prosesleri set sira=@parametre3 where talimat_id=@parametre1 and proses_id=@parametre2", new string[] { _SelectedId, datagridview_proses.Rows[e.RowIndex].Cells[(checkbox_secili.Checked ? 2 : 4)].Value.ToString(), YeniSira.ToString() });
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Negatif Değer Girmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value = deger;
                        }
                    }
                    catch (Exception h)
                    {
                        if ((Boolean)datagridview_proses.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                        {
                            MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value = deger;
                        }
                    }
                }
            }
        }

        private string deger = null;

        private void checkbox_secili_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (checkbox_secili.Checked)
                {
                    datagridview_proses.DataSource = Sc.GET_DATATABLE(loadTable, new String[] { _SelectedId });
                    datagridview_proses.Columns["id"].Visible = false;
                    datagridview_proses.Columns["Sıra"].Visible = false;
                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;

                    for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                    {
                        datagridview_proses.Rows[i].Cells["ekle"].Value = true;
                        datagridview_proses.Rows[i].Cells["sira"].Value = datagridview_proses.Rows[i].Cells["Sıra"].Value.ToString();
                    }
                }
                else
                {
                    datagridview_proses.DataSource = Sc.GET_DATATABLE(fullTable, new String[] { _SelectedId });

                    for (int i = 0; i < datagridview_proses.Rows.Count; i++)
                    {
                        string dd1 = datagridview_proses.Rows[i].Cells[3].Value != null ? datagridview_proses.Rows[i].Cells[3].Value.ToString() : "";
                        if (dd1 != "")
                        {
                            datagridview_proses.Rows[i].Cells["ekle"].Value = Boolean.Parse(datagridview_proses.Rows[i].Cells[2].Value.ToString());
                            datagridview_proses.Rows[i].Cells["sira"].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
                        }
                    }
                    datagridview_proses.Columns[2].Visible = false;
                    datagridview_proses.Columns[3].Visible = false;
                    datagridview_proses.Columns[4].Visible = false;
                    datagridview_proses.Columns["Kod"].ReadOnly = true;
                    datagridview_proses.Columns["İsim"].ReadOnly = true;
                }
            }
        }

        private void datagridview_proses_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == senderGrid.Columns["sira"].Index && e.RowIndex >= 0)
            {
                if (datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value != null)
                {
                    deger = datagridview_proses.Rows[e.RowIndex].Cells["sira"].Value.ToString();
                }
                else
                {
                    deger = "";
                }
            }
        }

        private void Add_Talimat_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancelUpdate();
        }

        private void TalimatUpdate()
        {
            String kod = textbox_talimat_kod.Text, isim = textbox_talimat_isim.Text;
            String _UpdateCode = "update Talimat set talimat_kodu=@parametre1, talimat_adi=@parametre2 Where Id=@parametre3";

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Talimat Where talimat_kodu=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Talimat Where talimat_adi=@parametre1 and Id!=@parametre2";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_talimat_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_talimat_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, isim, _SelectedId }))
                {
                    MessageBox.Show("Talimat Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelTalimat.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);

                    if (Items.panelTalimat.dataGridUst.Rows.Count > 0)
                    {
                        Talimatlar.SelectedTalimatID = Items.panelTalimat.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelTalimat.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { Talimatlar.SelectedTalimatID });
                        Items.panelTalimat.dataGridAlt.Columns[0].Visible = false;
                    }

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

                if (textbox_talimat_kod.Text == "")
                {
                    textbox_talimat_kod.Focus();
                }
                else if (textbox_talimat_isim.Text == "")
                {
                    textbox_talimat_isim.Focus();
                }
            }
        }

        private void cancelUpdate()
        {
            if (isUpdate)
            {
                if (Sc.QUERY_TABLE("delete from Talimat_Prosesleri where talimat_id=@parametre1", new string[] { _SelectedId }))
                {
                    for (int i = 0; i < loadProsesTable.Rows.Count; i++)
                    {
                        Sc.QUERY_TABLE("insert into Talimat_Prosesleri (talimat_id, proses_id, sira) values(@parametre1, @parametre2, @parametre3)", new string[] { _SelectedId, loadProsesTable.Rows[i]["id"].ToString(), loadProsesTable.Rows[i]["Sıra"].ToString() });
                    }
                }
            }
        }
    }
}