using LPROS.Custom;
using System;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Info;
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
    public partial class Search_Personel : Form
    {
        public Search_Personel()
        {
            InitializeComponent();
        }
       
        SqlConnector Sc = new SqlConnector();
        private void Search_Personel_Load(object sender, EventArgs e)
        {
            checkMinMaxDate();

            new FormTasima(panel_head, label_head, this, pictureBox_close);


            MySetting.loadComboboxDataTable(comboBox_departman, Sc.GET_DATATABLE(SqlConnector.TableDepartman), "id", "İsim");
            MySetting.loadComboboxDataTable(comboBox_yetki, Sc.GET_DATATABLE(SqlConnector.TableYetki), "id", "Yetki Türü");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagridview_Siparis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkbox_isegiris_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkbox_isegiris.Checked)
            {
                checkbox_arasında.Checked = false;
                checkbox_arasında.Enabled = false;
            }
            else
            {
                checkbox_arasında.Enabled = true;
            }
        }

        private void checkbox_isebaslangıc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_arasında.Checked)
            {
                datepicker_isebasmax.Enabled = true;
                checkbox_isegiris.Text = "İşe Giriş Tarihi Başlangıç";
                checkMinMaxDate();
            }
            else
            {
                datepicker_isebasmax.Enabled = false;
                checkbox_isegiris.Text = "işe Giriş Tarihi";
            }
        }

        private void datepicker_isebaslangic_ValueChanged(object sender, EventArgs e)
        {
            checkMinMaxDate();
        }
        private void checkMinMaxDate()
        {
            datepicker_isebasmax.MinDate = datepicker_isebaslangic.Value.AddDays(1);
            
        }

        private void checkbox_maliyet_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_maas.Checked)
            {
                checkbox_maas_arasinda.Enabled = true;
                textbox_maxmaas.Enabled = true;
            }
            else
            {
                checkbox_maas_arasinda.Enabled = false;
                checkbox_maas_arasinda.Checked = false;
                textbox_maxmaas.Enabled = false;
            }
        }
        private void search()
        {
            


            string Sad = textBox_isim.Text,
                   Ssoyad = textBox_soyisim.Text,
                   Sk_adi = textBox_kullaniciadi.Text,
                   Se_posta = textBox_eposta.Text,
                   Stelefon = textBox_telefon.Text,
                   Stc = TextBox_Tc.Text,
                   Sadres = textBox_adres.Text,
                   Ssskno = textBox_sskno.Text,
                   Syetkiid = comboBox_yetki.SelectedValue != null ? comboBox_yetki.SelectedValue.ToString() : "0",
                   Sdepartmanno = comboBox_departman.SelectedValue != null ? comboBox_departman.SelectedValue.ToString() : "0",
                   Sdurumu = comboBox_durum.SelectedItem != null ? comboBox_durum.SelectedItem.ToString() : "0",
                   
                   SMaasMin = textbox_minmaas.Text,
                   SMaasMax = textbox_maxmaas.Text;

            DateTime Ssskbas = datepicker_sskbaslangic.Value,
                     
                     Sisebasmin = datepicker_isebaslangic.Value,
                     Sisebasmax = datepicker_isebasmax.Value;

            string[] constArray = new string[] { Sad, Ssoyad, Sk_adi, Se_posta, Stelefon, Stc, Sadres, Ssskno, Sdepartmanno == "0" ? "" : Sdepartmanno, Syetkiid == "0" ? "" : Syetkiid, Sdurumu == "Aktif" ? "1" : Sdurumu == "Pasif"? "0" :""};
            string queryCustom = "";

            short parametreSirasi = 12;
            // sipariş tarihinde arama yapacak mı?
            if (checkbox_isegiris.Checked)
            {
                if (checkbox_arasında.Checked)
                {
                    queryCustom = " and convert(DATE, p.ise_giris_tarih) between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { Sisebasmin.ToString("yyyy/MM/dd"), Sisebasmax.ToString("yyyy/MM/dd") });

                    parametreSirasi += 2;
                }
                else
                {
                    queryCustom = " and convert(DATE, p.ise_giris_tarih)=@parametre" + parametreSirasi + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { Sisebasmin.ToString("yyyy/MM/dd") });

                    parametreSirasi += 1;
                }
            }

            // teslimat tarihinde arama yapacak mı?
            if (checkbox_sskbas.Checked)
            {
                    
                              
                    queryCustom += " and p.ssk_bas_tarih=@parametre" + parametreSirasi + " ";
                    constArray = stringArrayBirlestir(constArray, new string[] { Ssskbas.ToString("yyyy/MM/dd") });

                    parametreSirasi += 1;
                
            }

            // maliyet araması yapacak mı ?
            if (checkbox_maas.Checked)
            {
                if (checkbox_maas_arasinda.Checked)
                {
                    if (SMaasMax != "" && SMaasMin != "")
                    {
                        if (int.Parse(SMaasMax) < int.Parse(SMaasMin))
                        {
                            MessageBox.Show("Lütfen Maaş Bilgilerini Kontrol Ediniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }

                        queryCustom += " and maas between @parametre" + parametreSirasi + " and @parametre" + (parametreSirasi + 1) + " ";
                        constArray = stringArrayBirlestir(constArray, new string[] { SMaasMin == "" ? "0" : SMaasMin, SMaasMax });

                        parametreSirasi += 2;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Maaş Giriniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                else
                {
                    if (SMaasMin != "")
                    {
                        queryCustom += " and maas =@parametre" + parametreSirasi + " ";
                        constArray = stringArrayBirlestir(constArray, new string[] { SMaasMin });

                        parametreSirasi += 1;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Maaş Giriniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
            }

            string queryFull = "SELECT personel_no, tc as [TC Kimlik Numarası], ad as [Adı], soyad as [Soyadı], telefon as [Telefon Numarası] ,(CASE WHEN cinsiyet = 'E' THEN 'Erkek' ELSE 'Kadın' END) as [Cinsiyet], ssk_no [SSK Numarası],adres as [Adres], " +
                    " d.isim as [Departman], e_posta as [E_Posta], kullanici_adi as [Kullanıcı Adı], maas as [Maaş], sifre, " +
                    " y.yetki_turu as [Yetki], ssk_bas_tarih as [SSK Başlangıç Tarihi] , ise_giris_tarih as [İşe Giriş Tarihi], (CASE WHEN durumu = 1 THEN 'Aktif' ELSE 'Pasif' END) as [Durumu], guvenlik_soru as [Güvenlik Sorusu], guvenlik_soru_cevap as [Güvenlik Sorusu Cevabı] from Personel as p " +
                    " inner join Departman as d on d.id = p.departman_no " +
                    " inner join Yetkiler as y on y.id = p.yetki_id"+
            " where p.ad like '%'+@parametre1+'%' and p.soyad like '%'+@parametre2+'%' and p.kullanici_adi like '%'+@parametre3+'%' and p.e_posta like '%'+@parametre4+'%' and p.telefon like '%'+@parametre5+'%' and p.tc like '%'+@parametre6+'%' and p.adres like '%'+@parametre7+'%' and p.ssk_no like '%'+@parametre8+'%' and p.yetki_id like '%'+@parametre9+'%' and p.departman_no like '%'+@parametre10+'%' and p.durumu like '%'+@parametre11+'%' ";

            datagridview_Personel.DataSource = Sc.GET_DATATABLE(queryFull + " " + queryCustom, constArray);
            

        }
        public static string[] stringArrayBirlestir(string[] dizi1, string[] dizi2)
        {
            string[] sonuc = new string[dizi1.Length + dizi2.Length];
            dizi1.CopyTo(sonuc, 0);
            dizi2.CopyTo(sonuc, dizi1.Length);
            return sonuc;
        }

        private void comboBox_yetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView dtg = datagridview_Personel;
            Add_Personel adPer = new Add_Personel()
            {
                isUpdate = true,
                _SelectedTc = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["TC Kimlik Numarası"].Value.ToString(),
                _SelectedIsim = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Adı"].Value.ToString(),
                _SelectedSoyisim = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Soyadı"].Value.ToString(),
                _SelectedKullaniciAdi = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Kullanıcı Adı"].Value.ToString(),
                _SelectedSifre = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["sifre"].Value.ToString(),
                _SelectedEposta = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["E_Posta"].Value.ToString(),
                _SelectedAdres = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Adres"].Value.ToString(),
                _SelectedSSKNo = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["SSK Numarası"].Value.ToString(),
                _SelectedSSKBas = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["SSK Başlangıç Tarihi"].Value.ToString(),
                _SelectediseGiris = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["İşe Giriş Tarihi"].Value.ToString(),
                _SelectedCinsiyet = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Cinsiyet"].Value.ToString(),
                _SelectedDepartman = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Departman"].Value.ToString(),
                _SelectedYetki = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Yetki"].Value.ToString(),
                _SelectedMaas = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Maaş"].Value.ToString(),
                _SelectedDurumu = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Durumu"].Value.ToString(),
                _SelectedTelefon = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Telefon Numarası"].Value.ToString(),
                _SelectedId = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["personel_no"].Value.ToString(),
                _SelectedGuvenlik = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Güvenlik Sorusu"].Value.ToString(),
                _SelectedGuvenlikcvp = dtg.Rows[dtg.CurrentCell.RowIndex].Cells["Güvenlik Sorusu Cevabı"].Value.ToString(),


            };
            adPer.ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Personel Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = datagridview_Personel;

                if (Sc.QUERY_TABLE("delete from Personel where personel_no=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["personel_no"].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    search();
                }
            }
        }

        private void datagridview_Personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ayrinti"].Index && e.RowIndex >= 0)
            {
                Info_Personel ifp = new Info_Personel()
                {
                    _SelectedTc = datagridview_Personel.Rows[e.RowIndex].Cells["TC Kimlik Numarası"].Value.ToString(),
                    _SelectedIsim = datagridview_Personel.Rows[e.RowIndex].Cells["Adı"].Value.ToString(),
                    _SelectedSoyisim = datagridview_Personel.Rows[e.RowIndex].Cells["Soyadı"].Value.ToString(),
                    _SelectedKullaniciAdi = datagridview_Personel.Rows[e.RowIndex].Cells["Kullanıcı Adı"].Value.ToString(),
                    _SelectedSifre = datagridview_Personel.Rows[e.RowIndex].Cells["sifre"].Value.ToString(),
                    _SelectedEposta = datagridview_Personel.Rows[e.RowIndex].Cells["E_Posta"].Value.ToString(),
                    _SelectedAdres = datagridview_Personel.Rows[e.RowIndex].Cells["Adres"].Value.ToString(),
                    _SelectedSSKNo = datagridview_Personel.Rows[e.RowIndex].Cells["SSK Numarası"].Value.ToString(),
                    _SelectedSSKBas = datagridview_Personel.Rows[e.RowIndex].Cells["SSK Başlangıç Tarihi"].Value.ToString(),
                    _SelectediseGiris = datagridview_Personel.Rows[e.RowIndex].Cells["İşe Giriş Tarihi"].Value.ToString(),
                    _SelectedCinsiyet = datagridview_Personel.Rows[e.RowIndex].Cells["Cinsiyet"].Value.ToString(),
                    _SelectedDepartman = datagridview_Personel.Rows[e.RowIndex].Cells["Departman"].Value.ToString(),
                    _SelectedYetki = datagridview_Personel.Rows[e.RowIndex].Cells["Yetki"].Value.ToString(),
                    _SelectedMaas = datagridview_Personel.Rows[e.RowIndex].Cells["Maaş"].Value.ToString(),
                    _SelectedDurumu = datagridview_Personel.Rows[e.RowIndex].Cells["Durumu"].Value.ToString(),
                    _SelectedTelefon = datagridview_Personel.Rows[e.RowIndex].Cells["Telefon Numarası"].Value.ToString(),
                    _SelectedId = datagridview_Personel.Rows[e.RowIndex].Cells["personel_no"].Value.ToString(),
                    _SelectedGuvenlik = datagridview_Personel.Rows[e.RowIndex].Cells["Güvenlik Sorusu"].Value.ToString(),
                    _SelectedGuvenlikcvp = datagridview_Personel.Rows[e.RowIndex].Cells["Güvenlik Sorusu Cevabı"].Value.ToString(),
                };
                ifp.ShowDialog();
            }
        }
    }
}
