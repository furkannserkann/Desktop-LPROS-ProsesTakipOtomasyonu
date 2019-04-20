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


        private void Add_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (isUpdate)
            {

            }
            else
            {
                textbox_fisno.Text = DateTime.Now.Year.ToString() + "-";
                datepicker_siparis.MaxDate = DateTime.Now;
                datepicker_teslimat.MinDate = DateTime.Now.AddDays(1);

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

                combobox_renk.DataSource = Sc.GET_DATATABLE("select id, kod+' '+isim as [kodisim] from Renk");
                combobox_renk.DisplayMember = "kodisim";
                combobox_renk.ValueMember = "id";

                button_kaydet.Click += button_kaydet_Click;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
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
                    new String[] { siparis_tarihi , User.id.ToString(), doktor_id, protez_id, hasta_adsoyad, teslimat_tarihi, renk_id }))
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