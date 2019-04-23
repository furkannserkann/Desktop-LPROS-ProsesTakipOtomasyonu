using LPROS.Custom;
using LPROS.Forms_Panel;
using System;
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
    public partial class Add_Protez : Form
    {
        public Add_Protez()
        {
            InitializeComponent();
        }

        int Nowsira = 1;

        SqlConnector Sc = new SqlConnector();
        public bool isUpdate = false;

        public string _SelectedId, _SelectedKod, _SelectedIsim;

        String loadTable = "select t.Id as [id], pt.sira as [Sıram], t.talimat_kodu as [Kod], t.talimat_adi as [İsim] from Protez_Talimatlari as pt " +
                   "inner join Protez as p on p.Id=pt.protez_id " +
                   "inner join Talimat as t on t.Id = pt.talimat_id " +
                   "where pt.protez_id=@parametre1 order by pt.sira asc";

        String fullTable = "select CASE WHEN Exists(select top 1 * from Protez_Talimatlari as pt where pt.talimat_id=t.Id and pt.protez_id=@parametre1) then 'true' else 'false' end as a, " +
    " (select top 1 pt.sira from Protez_Talimatlari as pt where pt.talimat_id=t.Id and pt.protez_id=@parametre1) as [Sıram], " +
    " t.Id as [id], t.talimat_kodu as [Kod], t.talimat_adi as [İsim] from Talimat as t order by t.talimat_kodu asc";

        private void Add_Protez_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Protez Güncelle";
                button_protez_kaydet.Text = "Protez Bilgilerini Güncelle";

                textbot_protez_kod.Text = _SelectedKod;
                textbot_protez_isim.Text = _SelectedIsim;
                checkbox_secili.Visible = true;

                datagridview_talimat.DataSource = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });
                datagridview_talimat.Columns["id"].Visible = false;
                datagridview_talimat.Columns["Sıram"].Visible = false;

                string maxsira = Sc.GET_TEKDEGER("Select max(sira) from Protez_Talimatlari where protez_id=@parametre1", new string[] { _SelectedId });
                if (maxsira != "")
                    Nowsira = int.Parse(maxsira) + 1;

                for (int i = 0; i < datagridview_talimat.Rows.Count; i++)
                {
                    datagridview_talimat.Rows[i].Cells["ekle"].Value = true;
                    datagridview_talimat.Rows[i].Cells["sira"].Value = datagridview_talimat.Rows[i].Cells["Sıram"].Value.ToString();
                }

                loadTalimatTable = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });
            }
            else
            {
                checkbox_secili.Visible = false;

                datagridview_talimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
                datagridview_talimat.Columns["id"].Visible = false;

            }
        }

        private void checkbox_secili_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_secili.Checked)
            {
                datagridview_talimat.DataSource = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });
                datagridview_talimat.Columns["id"].Visible = false;

                for (int i = 0; i < datagridview_talimat.Rows.Count; i++)
                {
                    datagridview_talimat.Rows[i].Cells["ekle"].Value = true;
                    datagridview_talimat.Rows[i].Cells["sira"].Value = datagridview_talimat.Rows[i].Cells["Sıram"].Value.ToString();
                }
            }
            else
            {
                datagridview_talimat.DataSource = Sc.GET_DATATABLE(fullTable, new string[] { _SelectedId });
                datagridview_talimat.Columns["id"].Visible = false;
                datagridview_talimat.Columns["a"].Visible = false;

                for (int i = 0; i < datagridview_talimat.Rows.Count; i++)
                {
                    string dd1 = datagridview_talimat.Rows[i].Cells["Sıram"].Value != null ? datagridview_talimat.Rows[i].Cells["Sıram"].Value.ToString() : "";
                    if (dd1 != "")
                    {
                        datagridview_talimat.Rows[i].Cells["ekle"].Value = true;
                        datagridview_talimat.Rows[i].Cells["sira"].Value = datagridview_talimat.Rows[i].Cells["Sıram"].Value.ToString();
                    }
                }
            }
        }

        private void datagridview_talimat_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if ((Boolean)datagridview_talimat.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    if (datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value == null || datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value == "")
                    {
                        datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value = Nowsira.ToString();
                        Nowsira++;
                    }
                }
                else
                {
                    datagridview_talimat.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }
        }

        private void UpdateCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ekle"].Index && e.RowIndex >= 0)
            {
                if ((Boolean)datagridview_talimat.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    datagridview_talimat.Rows[e.RowIndex].Cells[1].Value = Nowsira.ToString();
                    Sc.QUERY_TABLE("insert into Protez_Talimatlari (protez_id, talimat_id, sira) values(@parametre1, @parametre2, @parametre3)", new string[] { _SelectedId, datagridview_talimat.Rows[e.RowIndex].Cells["id"].Value.ToString(), Nowsira.ToString() });

                    Nowsira++;
                }
                else
                {
                    Sc.QUERY_TABLE("delete from Protez_Talimatlari where protez_id=@parametre1 and talimat_id=@parametre2 and sira=@parametre3", new String[] { _SelectedId, datagridview_talimat.Rows[e.RowIndex].Cells["id"].Value.ToString(), datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString() });
                    datagridview_talimat.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }
        }

        private string deger = null;
        private void datagridview_talimat_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (e.ColumnIndex == senderGrid.Columns["sira"].Index && e.RowIndex >= 0)
            {
                if (datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value != null)
                {
                    deger = datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString();
                }
                else
                {
                    deger = "";
                }
            }
        }

        private void datagridview_talimat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["sira"].Index && e.RowIndex >= 0)
            {
                bool siravar = false;
                for (int i = 0; i < datagridview_talimat.Rows.Count; i++)
                {
                    if (datagridview_talimat.Rows[i].Cells["sira"].Value != null)
                    {
                        if (datagridview_talimat.Rows[i].Cells["sira"].Value.ToString().Equals(datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value) && i != e.RowIndex)
                        {
                            siravar = true;
                        }
                    }
                }

                if (siravar)
                {
                    MessageBox.Show("Girmiş Olduğunuz Sıra Kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value = deger;
                }
                else
                {
                    try
                    {
                        if (int.Parse(datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString()) > 0)
                        {
                            if (int.Parse(datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString()) + 1 > Nowsira)
                            {
                                Nowsira = int.Parse(datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString()) + 1;
                            }

                            if (isUpdate)
                            {
                                int YeniSira = int.Parse(datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value.ToString());
                                Sc.QUERY_TABLE("update Protez_Talimatlari set sira=@parametre1 where talimat_id=@parametre2 and protez_id=@parametre3", new string[] { YeniSira.ToString(), (datagridview_talimat.Rows[e.RowIndex].Cells["id"].Value.ToString()), _SelectedId });
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Negatif Değer Girmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value = deger;
                        }
                    }
                    catch (Exception h)
                    {
                        if ((Boolean)datagridview_talimat.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                        {
                            MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            datagridview_talimat.Rows[e.RowIndex].Cells["sira"].Value = deger;
                        }
                    }
                }
            }
        }

        DataTable loadTalimatTable;
        private void Add_Protez_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isUpdate)
            {
                if (Sc.QUERY_TABLE("delete from Protez_Talimatlari where protez_id=@parametre1", new string[] { _SelectedId }))
                {
                    for (int i = 0; i < loadTalimatTable.Rows.Count; i++)
                    {
                        Sc.QUERY_TABLE("insert into Protez_Talimatlari (protez_id, talimat_id, sira) values(@parametre1, @parametre2, @parametre3)", new string[] { _SelectedId, loadTalimatTable.Rows[i]["id"].ToString(), loadTalimatTable.Rows[i]["Sıram"].ToString() });
                    }
                }
            }
        }

        private void button_protez_kaydet_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                ProtezUpdate();
                isUpdate = false;
            }
            else
            {
                ProtezKaydet();
            }
        }

        private void ProtezKaydet()
        {

            String kod = textbot_protez_kod.Text, isim = textbot_protez_isim.Text;

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Protez Where kod=@parametre1";
                String _QueryIsim = "select * from Protez Where adi=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_protez_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_protez_isim.Focus();
                }
                else if (Sc.ADD_TABLE("Protez", new String[] { "kod", "adi" }, new String[] { kod, isim }))
                {
                    String SelectTalimatId = Sc.GET_TEKDEGER("select Id from Protez where kod=@parametre1", new String[] { kod });


                    for (int i = 0; i < datagridview_talimat.RowCount; i++)
                    {
                        if ((Boolean)datagridview_talimat.Rows[i].Cells[0].EditedFormattedValue)
                        {
                            Sc.ADD_TABLE("Protez_Talimatlari", new String[] { "protez_id", "talimat_id", "sira" },
                                new String[] { SelectTalimatId,
                                    datagridview_talimat.Rows[i].Cells["Id"].Value.ToString(),
                                    datagridview_talimat.Rows[i].Cells["sira"].Value.ToString() });
                        }
                    }

                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbot_protez_kod.Text = "";
                    textbot_protez_isim.Text = "";
                    textbot_protez_kod.Focus();

                    datagridview_talimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);

                    Items.panelProtez.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);
                    if (Items.panelProtez.dataGridUst.RowCount > 0)
                    {
                        Protezler.SelectedProtezid = Items.panelProtez.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProtez.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimatByProtezid, new String[] { Protezler.SelectedProtezid });
                        Items.panelProtez.dataGridAlt.Columns[0].Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (textbot_protez_kod.Text == "")
                {
                    textbot_protez_kod.Focus();
                }
                else if (textbot_protez_isim.Text == "")
                {
                    textbot_protez_isim.Focus();
                }
            }

        }

        private void ProtezUpdate()
        {
            String kod = textbot_protez_kod.Text, isim = textbot_protez_isim.Text;
            String _UpdateCode = "update Protez set kod=@parametre1, adi=@parametre2 Where Id=@parametre3";

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Protez Where kod=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Protez Where adi=@parametre1 and Id!=@parametre2";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_protez_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbot_protez_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, isim, _SelectedId }))
                {
                    MessageBox.Show("Talimat Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProtez.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);

                    if (Items.panelProtez.dataGridUst.Rows.Count > 0)
                    {
                        Protezler.SelectedProtezid = Items.panelProtez.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProtez.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimatByProtezid, new String[] { Protezler.SelectedProtezid });
                        Items.panelProtez.dataGridAlt.Columns[0].Visible = false;
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

                if (textbot_protez_kod.Text == "")
                {
                    textbot_protez_kod.Focus();
                }
                else if (textbot_protez_isim.Text == "")
                {
                    textbot_protez_isim.Focus();
                }
            }
        }
    }
}