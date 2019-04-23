using LPROS.Custom;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms.Table.Search
{
    public partial class Search_Siparis : Form
    {
        public Search_Siparis()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Search_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            checkMinMaxDate();

            string QueryHastane = "SELECT id as [id], kod+' - '+ad as [kod_ad], adres as [Adres] from Hastane";
            string QueryDoktorByHastaneid = "SELECT id as [id], isim+' '+soyisim as [adsoyad] from Doktorlar where hastane_id=@parametre1";
            string QueryPersonel = "SELECT personel_no, ad+' '+soyad as [adsoyad] from Personel as p";
            string QueryProtez = "select id, kod+' - '+adi as [kod_ad] from Protez";
            string QueryRenk = "select id, kod+' - '+isim as [kod_ad] from Renk";

            MySetting.loadComboboxDataTable(combobox_hastane, Sc.GET_DATATABLE(QueryHastane), "id", "kod_ad");
            MySetting.loadComboboxDataTable(combobox_doktor, Sc.GET_DATATABLE(QueryDoktorByHastaneid, new string[] { combobox_hastane.SelectedValue != null ? combobox_hastane.SelectedValue.ToString() : "0" }), "id", "adsoyad");
            MySetting.loadComboboxDataTable(combobox_kayitpersoneli, Sc.GET_DATATABLE(QueryPersonel + " where p.yetki_id=2 or p.yetki_id=1"), "personel_no", "adsoyad");
            MySetting.loadComboboxDataTable(combobox_protez, Sc.GET_DATATABLE(QueryProtez), "id", "kod_ad");
            MySetting.loadComboboxDataTable(combobox_renk, Sc.GET_DATATABLE(QueryRenk), "id", "kod_ad");





            //DataTable hastane = Sc.GET_DATATABLE(SqlConnector.TableHastane);

            //DataRow emptyRow = hastane.NewRow();
            //emptyRow["Id"] = 0;
            //emptyRow["Adı"] = "";
            //hastane.Rows.Add(emptyRow);

            //DataView newView = new DataView(hastane, "", "Adı", DataViewRowState.CurrentRows);

            //combobox_hastane.DataSource = newView;
            //combobox_hastane.DisplayMember = "Adı";
            //combobox_hastane.ValueMember = "ID";
        }

        private void checkBox_siparis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_siparisarasinda.Checked)
            {
                datepicker_siparisbitis.Enabled = true;
                checkbox_siparistarihibaslangic.Text = "Sipariş Tarihi Başlangıç";
                checkMinMaxDate();
            }
            else
            {
                datepicker_siparisbitis.Enabled = false;
                checkbox_siparistarihibaslangic.Text = "Sipariş Tarihi";
            }
        }

        private void checkBox_teslimat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_teslimatarasinda.Checked)
            {
                datepicker_teslimatbitis.Enabled = true;
                checkbox_teslimattarihibaslangic.Text = "Teslimat Tarihi Başlangıç";
                checkMinMaxDate();
            }
            else
            {
                datepicker_teslimatbitis.Enabled = false;
                checkbox_teslimattarihibaslangic.Text = "Teslimat Tarihi";
            }
        }

        private void datetimepicker_siparisbaslangic_ValueChanged(object sender, EventArgs e)
        {
            checkMinMaxDate();
        }

        private void datetimepicker_teslimatbaslangic_ValueChanged(object sender, EventArgs e)
        {
            checkMinMaxDate();
        }

        private void checkMinMaxDate()
        {
            datepicker_siparisbitis.MinDate = datepicker_siparisbaslangic.Value.AddDays(1);
            datepicker_teslimatbitis.MinDate = datepicker_teslimatbaslangic.Value.AddDays(1);
        }

        private void checkbox_maliyet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_maliyet.Checked)
            {
                checkbox_maliyet_arasinda.Enabled = true;
                textbox_maxmaliyet.Enabled = true;
            }
            else
            {
                checkbox_maliyet_arasinda.Enabled = false;
                checkbox_maliyet_arasinda.Checked = false;
                textbox_maxmaliyet.Enabled = false;
            }
        }

        private void combobox_hastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_hastane.ValueMember != "" && combobox_hastane.SelectedIndex >= 0)
            {
                string QuerDoktorByHastaneid = "SELECT id as [ID], isim+' '+soyisim as [adsoyad] from Doktorlar where hastane_id=@parametre1";
                MySetting.loadComboboxDataTable(combobox_doktor, Sc.GET_DATATABLE(QuerDoktorByHastaneid, new string[] { combobox_hastane.SelectedValue != null ? combobox_hastane.SelectedValue.ToString() : "0" }), "ID", "adsoyad");
            }
        }

        private void checkbox_siparistarihibaslangic_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_siparistarihibaslangic.Checked)
            {
                checkbox_siparisarasinda.Checked = false;
                checkbox_siparisarasinda.Enabled = false;
            }
            else
            {
                checkbox_siparisarasinda.Enabled = true;
            }
        }

        private void checkbox_teslimattarihibaslangic_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_teslimattarihibaslangic.Checked)
            {
                checkbox_teslimatarasinda.Checked = false;
                checkbox_teslimatarasinda.Enabled = false;
            }
            else
            {
                checkbox_teslimatarasinda.Enabled = true;
            }
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string toplamFiyatSql = "(select sum(m.fiyat*pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
                        " inner join Proses_Malzemeleri pm on pm.malzeme_id = m.id " +
                        " inner join Talimat_Prosesleri tp on pm.proses_id = tp.proses_id " +
                        " inner join Protez_Talimatlari pt on pt.talimat_id = tp.talimat_id " +
                        " where pt.protez_id = s.protez_id)";


            string SFisno = textbox_fisno.Text,
                   SHastaAdsoyad = textbox_hastaadsoyad.Text,
                   SHastaneid = combobox_hastane.SelectedValue != null ? combobox_hastane.SelectedValue.ToString() : "0",
                   SDoktorid = combobox_doktor.SelectedValue != null ? combobox_doktor.SelectedValue.ToString() : "0",
                   SKayitPersonelid = combobox_kayitpersoneli.SelectedValue != null ? combobox_kayitpersoneli.SelectedValue.ToString() : "0",
                   SProtezid = combobox_protez.SelectedValue != null ? combobox_protez.SelectedValue.ToString() : "0",
                   SRenkid = combobox_renk.SelectedValue != null ? combobox_renk.SelectedValue.ToString() : "0",
                   SMaliyetMin = textbox_minmaliyet.Text,
                   SMaliyetMax = textbox_maxmaliyet.Text;

            DateTime SSiparisTarihiBaslangic = datepicker_siparisbaslangic.Value,
                     SSiparisTarihiBitis = datepicker_siparisbitis.Value,
                     STeslimatTarihiBaslangic = datepicker_teslimatbaslangic.Value,
                     STeslimatTarihiBitis = datepicker_teslimatbitis.Value;

            string[] constArray = new string[] { SFisno, SHastaAdsoyad, SDoktorid == "0" ? "" : SDoktorid, SHastaneid == "0" ? "" : SHastaneid, SKayitPersonelid == "0" ? "" : SKayitPersonelid, SProtezid == "0" ? "" : SProtezid, SRenkid == "0" ? "" : SRenkid };
            string queryCustom = "";

            short parametreSirasi = 8;
            // sipariş tarihinde arama yapacak mı?
            if (checkbox_siparistarihibaslangic.Checked)
            {
                if (checkbox_siparisarasinda.Checked)
                {
                    queryCustom = " and s.siparis_tarihi between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { SSiparisTarihiBaslangic.ToString("yyyy/MM/dd"), SSiparisTarihiBitis.ToString("yyyy/MM/dd") });

                    parametreSirasi += 2;
                }
                else
                {
                    queryCustom = " and s.siparis_tarihi=@parametre" + parametreSirasi + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { SSiparisTarihiBaslangic.ToString("yyyy/MM/dd") });

                    parametreSirasi += 1;
                }
            }

            // teslimat tarihinde arama yapacak mı?
            if (checkbox_teslimattarihibaslangic.Checked)
            {
                if (checkbox_teslimatarasinda.Checked)
                {
                    queryCustom += " and s.teslim_tarihi between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { STeslimatTarihiBaslangic.ToString("yyyy/MM/dd"), STeslimatTarihiBitis.ToString("yyyy/MM/dd") });

                    parametreSirasi += 2;
                }
                else
                {
                    queryCustom += " and s.teslim_tarihi=@parametre" + parametreSirasi + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { STeslimatTarihiBaslangic.ToString("yyyy/MM/dd") });

                    parametreSirasi += 1;
                }
            }

            // maliyet araması yapacak mı ?
            if (checkbox_maliyet.Checked)
            {
                if (checkbox_maliyet_arasinda.Checked)
                {
                    if (SMaliyetMax != "" && SMaliyetMin != "")
                    {
                        if (int.Parse(SMaliyetMax) < int.Parse(SMaliyetMin))
                        {
                            MessageBox.Show("Lütfen Maliyet Bilgilerini Kontrol Ediniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                        queryCustom += " and " + toplamFiyatSql + " between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
                        constArray = stringArrayBirlestir(constArray, new string[] { SMaliyetMin == "" ? "0" : SMaliyetMin, SMaliyetMax });

                        parametreSirasi += 2;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Maliyet Giriniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                else
                {
                    if (SMaliyetMin != "")
                    {
                        queryCustom += " and " + toplamFiyatSql + "=@parametre" + parametreSirasi + " ";
                        constArray = stringArrayBirlestir(constArray, new string[] { SMaliyetMin });

                        parametreSirasi += 1;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Maliyet Giriniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
            }

            string queryFull = "SELECT " + toplamFiyatSql + " as [Toplam Fiyat], " +
                               " s.id, fis_no as [Fiş Numarası], p.ad + ' ' + p.soyad as [Kayıt Personeli], s.siparis_tarihi as [Sipariş Tarihi], teslim_tarihi as [Teslim Tarihi], h.ad as [Hastane], d.isim + ' ' + d.soyisim as [Doktor], hasta_ad_soyad as [Hasta İsmi], pr.adi as [Protez Tipi], renk.isim as [Renk] from Siparis as s " +
                               " inner join Personel as p on s.personel_id = p.personel_no " +
                               " inner join Doktorlar as d on d.id = s.doktor_id " +
                               " inner join Hastane as h on h.Id = d.hastane_id " +
                               " inner join Protez as pr on pr.id = s.protez_id " +
                               " inner join Renk as renk on renk.id = s.renk_id" +
                               " where s.fis_no like '%'+@parametre1+'%' and s.hasta_ad_soyad like '%'+@parametre2+'%' and s.doktor_id like '%'+@parametre3+'%' and d.hastane_id like '%'+@parametre4+'%' and s.personel_id like '%'+@parametre5+'%' and s.protez_id like '%'+@parametre6+'%' and s.renk_id like '%'+@parametre7+'%' ";

            datagridview_ara_siparis.DataSource = Sc.GET_DATATABLE(queryFull + " " + queryCustom, constArray);
            if (datagridview_ara_siparis.Columns.Count > 2)
            {
                datagridview_ara_siparis.Columns[2].Visible = false;

                datagridview_ara_siparis.Columns["Sipariş Tarihi"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
            }
        }

        public static string[] stringArrayBirlestir(string[] dizi1, string[] dizi2)
        {
            string[] sonuc = new string[dizi1.Length + dizi2.Length];
            dizi1.CopyTo(sonuc, 0);
            dizi2.CopyTo(sonuc, dizi1.Length);
            return sonuc;
        }

        private void datagridview_ara_siparis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ayrinti"].Index && e.RowIndex >= 0)
            {
                Info_Siparis infSiparis = new Info_Siparis()
                {
                    siparisid = datagridview_ara_siparis.Rows[e.RowIndex].Cells["id"].Value.ToString()
                };
                infSiparis.ShowDialog();
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            if (datagridview_ara_siparis.Rows.Count > 0)
            {
                DialogResult Dr = MessageBox.Show("Seçilen Sipariş Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Dr == DialogResult.OK)
                {
                    if (Sc.QUERY_TABLE("delete from Siparis where id=@parametre1", new String[] { datagridview_ara_siparis.Rows[datagridview_ara_siparis.CurrentCell.RowIndex].Cells["id"].Value.ToString() }))
                    {
                        MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        search();
                        Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis);
                    }
                }
            }
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = datagridview_ara_siparis;
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
                search();
            }
        }

        private void textbox_sadeceHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textbox_sadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void checkbox_maliyet_arasinda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_maliyet_arasinda.Checked)
            {
                checkbox_maliyet.Text = "Maliyet (Min)";
            }
            else
            {
                checkbox_maliyet.Text = "Maliyet";
            }
            
        }
    }
}