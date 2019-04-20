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

namespace LPROS.Forms.Table.Add
{
    public partial class Add_Siparis : Form
    {
        public Add_Siparis()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        public bool isUpdate = false;
        public string fisno, hasta_adsoyad, protez_id, hastane_id, doktor_id, siparis_tarihi, teslimat_tarihi, renk_id;

        private void datepicker_siparis_ValueChanged(object sender, EventArgs e)
        {
            datepicker_teslimat.MinDate = datepicker_siparis.Value.AddDays(1);
        }

        private void Add_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);


            combobox_protez.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);
            combobox_protez.DisplayMember = "İsim";
            combobox_protez.ValueMember = "id";


            combobox_hastane.DataSource = Sc.GET_DATATABLE("SELECT Id as [ID], ad as [Adı], kod+' - '+ad as [kodad] from Hastane");
            combobox_hastane.DisplayMember = "kodad";
            combobox_hastane.ValueMember = "Id";

            if (combobox_hastane.ValueMember != "" && combobox_hastane.SelectedIndex >= 0)
            {
                combobox_doktor.DataSource = Sc.GET_DATATABLE("SELECT Id as [ID], isim+' '+soyisim as [adsoyad] from Doktorlar where hastane_id=@parametre1", new string[] { combobox_hastane.SelectedValue.ToString() });
                combobox_doktor.DisplayMember = "adsoyad";
                combobox_doktor.ValueMember = "ID";
            }

            combobox_renk.DataSource = Sc.GET_DATATABLE("select id, kod+' - '+isim as [kodisim] from Renk");
            combobox_renk.DisplayMember = "kodisim";
            combobox_renk.ValueMember = "id";


            if (isUpdate)
            {
                label_head.Text = "Sipariş Güncelle";
                button_kaydet.Text = "Sipariş Bilgilerini Güncelle";

                textbox_fisno.Text = fisno;
                textbox_hasta_adsoyad.Text = hasta_adsoyad;
                combobox_protez.SelectedValue = protez_id;
                combobox_hastane.SelectedValue = hastane_id;
                combobox_doktor.SelectedValue = doktor_id;
                combobox_renk.SelectedValue = renk_id;
                datepicker_siparis.Text = siparis_tarihi;
                datepicker_teslimat.Text = teslimat_tarihi;

                datepicker_teslimat.MinDate = datepicker_siparis.Value.AddDays(1);

                button_kaydet.Click += button_guncelle_Click;
            }
            else
            {
                textbox_fisno.Text = DateTime.Now.Year.ToString() + "-";
                datepicker_siparis.MaxDate = DateTime.Now;
                datepicker_teslimat.MinDate = DateTime.Now.AddDays(1);

                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            SiparisKaydet();
        }

        private void SiparisKaydet()
        {
            string hasta_adsoyad = textbox_hasta_adsoyad.Text,
                  protez_id = combobox_protez.SelectedValue.ToString(),
                  hastane_id = combobox_hastane.SelectedValue.ToString(),
                  doktor_id = combobox_doktor.SelectedValue.ToString(),
                  renk_id = combobox_renk.SelectedValue.ToString(),
                  siparis_tarihi = DateTime.Now.ToString("yyyy-MM-dd"),
                  teslimat_tarihi = datepicker_teslimat.Value.ToString("yyyy-MM-dd");

            if (hasta_adsoyad != "")
            {
                if (Sc.ADD_TABLE("Siparis", new String[] { "siparis_tarihi", "personel_id", "doktor_id", "protez_id", "hasta_ad_soyad", "teslim_tarihi", "renk_id" },
                    new String[] { siparis_tarihi, User.id.ToString(), doktor_id, protez_id, hasta_adsoyad, teslimat_tarihi, renk_id }))
                {
                    DataTable talimatCount = Sc.GET_DATATABLE("select * from Protez_Talimatlari where protez_id=@parametre1", new String[] { protez_id });

                    for (int i = 0; i < talimatCount.Rows.Count; i++)
                    {
                        DataTable prosesCount = Sc.GET_DATATABLE("select * from Talimat_Prosesleri where talimat_id=@parametre1", new String[] { talimatCount.Rows[i]["talimat_id"].ToString() });

                        for (int k = 0; k < prosesCount.Rows.Count; k++)
                        {
                            Sc.ADD_TABLE("Anlik_Prosesler", new String[] { "talimat_id", "proses_id", "proses_sirasi", "personel_no", "siparis_id" },
                                                         new String[] { talimatCount.Rows[i]["talimat_id"].ToString(), prosesCount.Rows[k]["proses_id"].ToString(), prosesCount.Rows[k]["sira"].ToString(), User.id.ToString() });
                        }
                    }
                    MessageBox.Show("Kayıt Başarılı!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    textbox_fisno.Text = DateTime.Now.Year.ToString() + "-";
                    datepicker_siparis.MaxDate = DateTime.Now;
                    datepicker_teslimat.MinDate = DateTime.Now.AddDays(1);
                    textbox_hasta_adsoyad.Text = "";
                    combobox_protez.SelectedIndex = 0;
                    combobox_hastane.SelectedIndex = 0;
                    combobox_renk.SelectedIndex = 0;

                    Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis);
                }
                else
                {
                    MessageBox.Show("İşlem Başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lüten Boş Yerleri Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textbox_hasta_adsoyad.Focus();
            }
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            SiparisGuncelle();
        }

        private void SiparisGuncelle()
        {
            string Ufisno = textbox_fisno.Text, 
                   Uhasta_adsoyad = textbox_hasta_adsoyad.Text, 
                   Uprotezid = combobox_protez.SelectedValue.ToString(),
                   Uhastane = combobox_hastane.SelectedValue.ToString(), 
                   Udoktor = combobox_doktor.SelectedValue!=null? combobox_doktor.SelectedValue.ToString() : "0",
                   Urenk = combobox_renk.SelectedValue.ToString();

            DateTime Uteslimat_tarihi = datepicker_teslimat.Value;


            String _UpdateCode = "update Siparis set doktor_id=@parametre1, protez_id=@parametre2, hasta_ad_soyad=@parametre3, teslim_tarihi=@parametre4, renk_id=@parametre5 Where fis_no=@parametre6";

            if (hasta_adsoyad != "")
            {
                if (Udoktor == "0")
                {
                    MessageBox.Show("Lütfen Doktor Seçiniz!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (Sc.QUERY_TABLE(_UpdateCode, new String[] { Udoktor, Uprotezid, Uhasta_adsoyad, Uteslimat_tarihi.ToString("yyyy/MM/dd"), Urenk, Ufisno }))
                {
                    MessageBox.Show("Sipariş Bilgileri Güncellendi!", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelSiparis.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableSiparis);
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
                textbox_hasta_adsoyad.Focus();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_doktor.Enabled = true;

            if (combobox_hastane.ValueMember != "" && combobox_hastane.SelectedIndex >= 0)
            {
                combobox_doktor.DataSource = Sc.GET_DATATABLE("SELECT Id as [ID], isim+' '+soyisim as [adsoyad] from Doktorlar where hastane_id=@parametre1", new string[] { combobox_hastane.SelectedValue.ToString() });
                combobox_doktor.DisplayMember = "adsoyad";
                combobox_doktor.ValueMember = "ID";
            }
        }
    }
}