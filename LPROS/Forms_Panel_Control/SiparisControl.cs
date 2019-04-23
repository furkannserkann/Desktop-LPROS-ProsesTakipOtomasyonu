using LPROS.Custom;
using LPROS.Forms;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Search;
using LPROS.Forms.Table.Update;
using System;
using System.Data;
using System.Windows.Forms;

namespace LPROS.ControlPanelForms
{
    public partial class SiparisControl : Form
    {
        public SiparisControl()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void SiparisControl_Load(object sender, EventArgs e)
        {
            datepicker_teslimtarihi.Value = DateTime.Now.AddDays(1);

            datepicker_teslimtarihi.MinDate = datepicker_siparistarihi.Value.AddDays(1);

            MySetting.loadComboboxDataTable(combobox_proteztipi, Sc.GET_DATATABLE(SqlConnector.TableProtez), "id", "İsim");
            MySetting.loadComboboxDataTable(combobox_renk, Sc.GET_DATATABLE(SqlConnector.TableRenk), "id", "İsim");
        }

     
        private void button_ekle_Click(object sender, EventArgs e)
        {
            Add_Siparis addSip = new Add_Siparis()
            {
                isUpdate = false
            };
            addSip.ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {


        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Siparis()).ShowDialog();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelSiparis.dataGridview;
            if (Dtg.Rows.Count > 0)
            {
                Add_Siparis addSip = new Add_Siparis()
                {
                    isUpdate = true,
                    fisno = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Fiş Numarası"].Value.ToString(),
                    hasta_adsoyad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Hasta İsmi"].Value.ToString(),
                    protez_id = Sc.GET_TEKDEGER("select top 1 Id from Protez where adi=@parametre1", new string[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Protez Tipi"].Value.ToString() }),
                    hastane_id = Sc.GET_TEKDEGER("select top 1 Id from Hastane where ad=@parametre1", new string[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Hastane"].Value.ToString() }),
                    doktor_id = Sc.GET_TEKDEGER("select top 1 Id from Doktorlar where isim+' '+soyisim=@parametre1", new string[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Doktor"].Value.ToString() }),
                    siparis_tarihi = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Sipariş Tarihi"].Value.ToString(),
                    teslimat_tarihi = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Teslim Tarihi"].Value.ToString(),
                    renk_id = Sc.GET_TEKDEGER("select top 1 Id from Renk where isim=@parametre1", new string[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Renk"].Value.ToString() })
                };
                addSip.ShowDialog();
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            SearchDepartman();
        }

        private bool _SearchSiparisClear = false; // sadece temizleme işleminde true olacak
        private void SearchDepartman()
        {
            if (!_SearchSiparisClear)
            {
                string SFisno = textbox_arafisno.Text,
                       SHasta_adsoyad = textbox_arahasta.Text,
                       SProtez = combobox_proteztipi.SelectedValue != null ? combobox_proteztipi.SelectedValue.ToString() : "0",
                       SRenk = combobox_renk.SelectedValue != null ? combobox_renk.SelectedValue.ToString() : "0";


                DateTime SSiparisTarihi = datepicker_siparistarihi.Value,
                         STeslimatTarihi = datepicker_teslimtarihi.Value;

                string query = SqlConnector.TableSiparis + " Where s.fis_no like '%'+@parametre1+'%' and s.hasta_ad_soyad like '%'+@parametre2+'%' and s.protez_id like '%'+@parametre3+'%' and s.renk_id like '%'+@parametre4+'%' ";
                string[] querydizi = new string[0];

                if (!checkbox_siparistarihi.Checked && !checkbox_teslimattarihi.Checked)
                {
                    querydizi = new string[] { SFisno, SHasta_adsoyad, SProtez == "0" ? "" : SProtez, SRenk == "0" ? "" : SRenk };
                }
                else if (checkbox_siparistarihi.Checked && checkbox_teslimattarihi.Checked)
                {
                    query += " and convert(DATE, s.siparis_tarihi)=@parametre5 and s.teslim_tarihi=@parametre6 ";
                    querydizi = new string[] { SFisno, SHasta_adsoyad, SProtez == "0" ? "" : SProtez, SRenk == "0" ? "" : SRenk, checkbox_siparistarihi.Checked ? SSiparisTarihi.ToString("yyyy/MM/dd") : "", checkbox_teslimattarihi.Checked ? STeslimatTarihi.ToString("yyyy/MM/dd") : "" };
                }
                else if (checkbox_siparistarihi.Checked)
                {
                    query += " and convert(DATE, s.siparis_tarihi)=@parametre5 ";
                    querydizi = new string[] { SFisno, SHasta_adsoyad, SProtez == "0" ? "" : SProtez, SRenk == "0" ? "" : SRenk, checkbox_siparistarihi.Checked ? SSiparisTarihi.ToString("yyyy/MM/dd") : "" };
                }
                else if (checkbox_teslimattarihi.Checked)
                {
                    query += " and convert(DATE, s.siparis_tarihi)=@parametre5 ";
                    querydizi = new string[] { SFisno, SHasta_adsoyad, SProtez == "0" ? "" : SProtez, SRenk == "0" ? "" : SRenk, checkbox_teslimattarihi.Checked ? STeslimatTarihi.ToString("yyyy/MM/dd") : "" };
                }

                Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(query, querydizi);
            }
            else
            {
                textbox_arafisno.Text = "";
                textbox_arahasta.Text = "";
                checkbox_siparistarihi.Checked = true;
                datepicker_siparistarihi.Value = DateTime.Now;
                checkbox_teslimattarihi.Checked = false;
                combobox_proteztipi.SelectedIndex = 0;
                combobox_renk.SelectedIndex = 0;

                Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis + " where convert(DATE, s.siparis_tarihi)='" + DateTime.Now.ToString("yyyy/MM/dd") + "'");
                _SearchSiparisClear = false;

            }
        }

        private void button_temizle_Click(object sender, EventArgs e)
        {
            _SearchSiparisClear = true;
            SearchDepartman();
        }

        private void datepicker_siparistarihi_ValueChanged(object sender, EventArgs e)
        {
            datepicker_teslimtarihi.MinDate = datepicker_siparistarihi.Value.AddDays(1);
        }

        private void button_sil_Click_1(object sender, EventArgs e)
        {
            if (Items.panelSiparis.dataGridview.Rows.Count > 0)
            {
                DialogResult Dr = MessageBox.Show("Seçilen Sipariş Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Dr == DialogResult.OK)
                {
                    DataGridView Dtg = Items.panelSiparis.dataGridview;

                    if (Sc.QUERY_TABLE("delete from Siparis where id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString() }))
                    {
                        MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis);
                    }
                }
            }
        }

        private void textbox_arahasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
