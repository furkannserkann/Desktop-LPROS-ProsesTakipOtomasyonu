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
    public partial class Add_Proses : Form
    {
        public Add_Proses()
        {
            InitializeComponent();
        }

        public bool isUpdate = false;
        SqlConnector Sc = new SqlConnector();

        public string _SelectedId, _SelectedKod, _SelectedIsim;

        String loadTable = "select m.Id as [id], pm.adet as [Adet], m.adi as [İsim], m.fiyat as [Fiyat] from Proses_Malzemeleri as pm " +
                   "inner join Proses as p on p.Id=pm.proses_id " +
                   "inner join Malzemeler as m on m.Id = pm.malzeme_id " +
                   "where pm.proses_id=@parametre1 order by m.adi asc";

        String fullTable = "select CASE WHEN Exists(select top 1 * from Proses_Malzemeleri as pm where pm.malzeme_id=m.Id and proses_id=@parametre1) then 'true' else 'false' end as a, " +
                        " (select top 1 pm.adet from Proses_Malzemeleri as pm where pm.malzeme_id = m.Id and proses_id=@parametre1) as [mAdet], " +
                        " m.id as mid, m.adi as [İsim], m.fiyat as [Fiyat] " +
                        " from Malzemeler as m order by m.adi";

        DataTable loadMalzemeTable;

        private void Add_Proses_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {
                label_head.Text = "Proses Güncelle";
                button_proses_kaydet.Text = "Proses Bilgilerini Güncelle";

                textbox_proses_kod.Text = _SelectedKod;
                textbox_proses_isim.Text = _SelectedIsim;

                datagridview_malzeme.DataSource = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });

                datagridview_malzeme.Columns["id"].Visible = false;
                datagridview_malzeme.Columns["Adet"].Visible = false;
                datagridview_malzeme.Columns["İsim"].ReadOnly = true;

                for (int i = 0; i < datagridview_malzeme.Rows.Count; i++)
                {
                    datagridview_malzeme.Rows[i].Cells["ekle"].Value = true;
                    datagridview_malzeme.Rows[i].Cells["adet"].Value = datagridview_malzeme.Rows[i].Cells[3].Value.ToString();
                }

                loadMalzemeTable = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });

                for (int i = 0; i < datagridview_malzeme.Columns.Count; i++)
                    datagridview_malzeme.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

                checkbox_secili.Visible = true;
            }
            else
            {
                datagridview_malzeme.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
                if (datagridview_malzeme.Rows.Count > 0)
                {
                    for (int i = 0; i < datagridview_malzeme.Columns.Count; i++)
                        datagridview_malzeme.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;

                    datagridview_malzeme.Columns["id"].Visible = false;
                    datagridview_malzeme.Columns["Adı"].ReadOnly = true;
                    datagridview_malzeme.Columns["Fiyat"].ReadOnly = true;
                }

                checkbox_secili.Visible = false;
            }
        }

        private void ProsesKaydet()
        {
            String kod = textbox_proses_kod.Text, isim = textbox_proses_isim.Text;

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Proses Where kod=@parametre1";
                String _QueryIsim = "select * from Proses Where isim=@parametre1";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_isim.Focus();
                }
                else if (Sc.ADD_PROSES(textbox_proses_kod.Text, textbox_proses_isim.Text))
                {
                    String SelectProsesId = Sc.GET_TEKDEGER("select Id from Proses where kod=@parametre1", new String[] { kod });

                    for (int i = 0; i < datagridview_malzeme.RowCount; i++)
                    {
                        if ((Boolean)datagridview_malzeme.Rows[i].Cells[0].EditedFormattedValue)
                        {
                            Sc.ADD_TABLE("Proses_Malzemeleri", new String[] { "proses_id", "malzeme_id", "adet" },
                                new String[] { SelectProsesId,
                                    datagridview_malzeme.Rows[i].Cells["id"].Value.ToString(),
                                    datagridview_malzeme.Rows[i].Cells["adet"].Value.ToString() });
                        }
                    }

                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_proses_kod.Text = "";
                    textbox_proses_isim.Text = "";
                    textbox_proses_kod.Focus();

                    datagridview_malzeme.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
                    Items.panelProses.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);

                    if (Items.panelProses.dataGridUst.RowCount > 0)
                    {
                        Prosesler.SelectedProsesID = Items.panelProses.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProses.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { Prosesler.SelectedProsesID });
                        Items.panelProses.dataGridAlt.Columns[0].Visible = false;
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

                if (textbox_proses_kod.Text == "")
                {
                    textbox_proses_kod.Focus();
                }
                else if (textbox_proses_isim.Text == "")
                {
                    textbox_proses_isim.Focus();
                }
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            ProsesKaydet();
        }

        private void textBox_kayit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProsesKaydet();
            }
        }

        private void datagridview_malzeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if ((Boolean)datagridview_malzeme.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    if (datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value == null || datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value == "")
                    {
                        datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value = "1";
                    }
                }
            }
        }

        private void UpdateCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ekle"].Index && e.RowIndex >= 0)
            {
                if ((Boolean)datagridview_malzeme.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                {
                    if (datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value == null)
                    {
                        datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value = "1";
                    }

                    Sc.QUERY_TABLE("insert into Proses_Malzemeleri (malzeme_id, proses_id, adet) values(@parametre1, @parametre2, @parametre3)", new string[] { datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? "id" : "mid"].Value.ToString(), _SelectedId, datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value.ToString() });
                }
                else
                {
                    Sc.QUERY_TABLE("delete from Proses_Malzemeleri where proses_id=@parametre1 and malzeme_id=@parametre2 and adet=@parametre3", new String[] { _SelectedId, datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? "id" : "mid"].Value.ToString(), datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value.ToString() });
                    datagridview_malzeme.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }
        }

        private void button_proses_kaydet_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                ProsesUpdate();
                isUpdate = false;
            }
            else
            {
                ProsesKaydet();
            }
        }

        private void datagridview_malzeme_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == (checkbox_secili.Checked ? 3 : 1) && e.RowIndex >= 0)
            {
                if (datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? 3 : 1].Value != null)
                {
                    try
                    {
                        if (int.Parse(datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? 3 : 1].Value.ToString()) > 0)
                        {
                            if (isUpdate)
                            {
                                int Adet = int.Parse(datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? 3 : 1].Value.ToString());
                                Sc.QUERY_TABLE("update Proses_Malzemeleri set adet=@parametre1 where proses_id=@parametre2 and malzeme_id=@parametre3", new string[] { Adet.ToString(), _SelectedId, datagridview_malzeme.Rows[e.RowIndex].Cells[checkbox_secili.Checked ? "id" : "mid"].Value.ToString() });
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Negatif Değer Girmeyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            datagridview_malzeme.Rows[e.RowIndex].Cells["sira"].Value = begindeger;
                        }
                    }
                    catch (Exception h)
                    {
                        if ((Boolean)datagridview_malzeme.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                        {
                            MessageBox.Show("Lütfen Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        datagridview_malzeme.Rows[e.RowIndex].Cells[1].Value = begindeger;
                    }
                }
                else
                {
                    if ((Boolean)datagridview_malzeme.Rows[e.RowIndex].Cells[0].EditedFormattedValue)
                    {
                        datagridview_malzeme.Rows[e.RowIndex].Cells[1].Value = begindeger;
                    }
                }
            }
        }

        string begindeger = "";
        private void datagridview_malzeme_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["adet"].Index && e.RowIndex >= 0)
            {
                if (datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value != null)
                {
                    begindeger = datagridview_malzeme.Rows[e.RowIndex].Cells["adet"].Value.ToString();
                }
                else
                {
                    begindeger = "";
                }
            }
        }

        private void checkbox_secili_CheckedChanged(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (checkbox_secili.Checked)
                {
                    datagridview_malzeme.DataSource = Sc.GET_DATATABLE(loadTable, new string[] { _SelectedId });
                    datagridview_malzeme.Columns["id"].Visible = false;
                    datagridview_malzeme.Columns["adet"].Visible = true;
                    datagridview_malzeme.Columns["Adet"].Visible = false;
                    datagridview_malzeme.Columns["İsim"].ReadOnly = true;

                    for (int i = 0; i < datagridview_malzeme.Rows.Count; i++)
                    {
                        datagridview_malzeme.Rows[i].Cells["ekle"].Value = true;
                        datagridview_malzeme.Rows[i].Cells["adet"].Value = datagridview_malzeme.Rows[i].Cells[3].Value.ToString();
                    }
                }
                else
                {
                    datagridview_malzeme.DataSource = Sc.GET_DATATABLE(fullTable, new String[] { _SelectedId });
                    datagridview_malzeme.Columns["adet"].Visible = true;
                    datagridview_malzeme.Columns["mid"].Visible = false;

                    for (int i = 0; i < datagridview_malzeme.Rows.Count; i++)
                    {
                        string dd1 = datagridview_malzeme.Rows[i].Cells[3].Value != null ? datagridview_malzeme.Rows[i].Cells[3].Value.ToString() : "";
                        if (dd1 != "")
                        {
                            datagridview_malzeme.Rows[i].Cells["ekle"].Value = Boolean.Parse(datagridview_malzeme.Rows[i].Cells[2].Value.ToString());
                            datagridview_malzeme.Rows[i].Cells["adet"].Value = datagridview_malzeme.Rows[i].Cells[3].Value.ToString();
                        }
                    }
                    datagridview_malzeme.Columns[2].Visible = false;
                    datagridview_malzeme.Columns[3].Visible = false;
                    datagridview_malzeme.Columns["İsim"].ReadOnly = true;
                }
            }
        }

        private void ProsesUpdate()
        {
            String kod = textbox_proses_kod.Text, isim = textbox_proses_isim.Text;
            String _UpdateCode = "update Proses set kod=@parametre1, isim=@parametre2 Where Id=@parametre3";

            if (isim != "" && kod != "")
            {
                String _QueryKod = "select * from Proses Where kod=@parametre1 and Id!=@parametre2";
                String _QueryIsim = "select * from Proses Where isim=@parametre1 and Id!=@parametre2";

                if (Sc.GET_DATATABLE(_QueryKod, new String[] { kod, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen Kod Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_kod.Focus();
                }
                else if (Sc.GET_DATATABLE(_QueryIsim, new String[] { isim, _SelectedId }).Rows.Count > 0)
                {
                    MessageBox.Show("Girilen İsim Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox_proses_isim.Focus();
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { kod, isim, _SelectedId }))
                {
                    MessageBox.Show("Proses Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelProses.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);

                    if (Items.panelProses.dataGridUst.RowCount > 0)
                    {
                        Prosesler.SelectedProsesID = Items.panelProses.dataGridUst.Rows[0].Cells[0].Value.ToString();
                        Items.panelProses.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { Prosesler.SelectedProsesID });
                        Items.panelProses.dataGridAlt.Columns[0].Visible = false;
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

                if (textbox_proses_kod.Text == "")
                {
                    textbox_proses_kod.Focus();
                }
                else if (textbox_proses_isim.Text == "")
                {
                    textbox_proses_isim.Focus();
                }
            }
        }

        private void Add_Proses_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancelUpdate();
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

        private void cancelUpdate()
        {
            if (isUpdate)
            {
                if (Sc.QUERY_TABLE("delete from Proses_Malzemeleri where proses_id=@parametre1", new string[] { _SelectedId }))
                {
                    for (int i = 0; i < loadMalzemeTable.Rows.Count; i++)
                    {
                        Sc.QUERY_TABLE("insert into Proses_Malzemeleri (malzeme_id, proses_id, adet) values(@parametre1, @parametre2, @parametre3)", new string[] { loadMalzemeTable.Rows[i]["id"].ToString(), _SelectedId, loadMalzemeTable.Rows[i]["Adet"].ToString() });
                    }
                }
            }
        }
    }
}