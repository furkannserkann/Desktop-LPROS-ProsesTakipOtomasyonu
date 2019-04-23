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

namespace LPROS.Forms
{
    public partial class Barkod : Form
    {
        public Barkod()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Barkod_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            textbox_personel.Text = User.ad + " " + User.soyad;
            textbox_fisno.Text = DateTime.Now.Year.ToString() + "-";
            textbox_fisno.Focus();
        }

        private void Barkod_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.isOpenBarkod = false;
        }

        private void textbox_personel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            giriscikis();
        }

        private void giriscikis()
        {
            string QueryProses = "select p.Id as id, p.kod+' - '+p.isim as [kodisim] from Proses as p " +
                    " inner join Talimat_Prosesleri as tp on tp.proses_id = p.Id " +
                    " inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
                    " inner join Siparis as s on s.protez_id = pt.protez_id " +
                    " where s.fis_no=@parametre1";

            // bitiş tarihi null olan
            string QueryBitisTarihi = "select top 1 * from Anlik_Prosesler as ap " +
                                      " where ap.siparis_id = (select s.Id from Siparis as s where s.fis_no=@parametre1) " +
                                      " and bitis_tarihi is null " +
                                      " order by proses_sirasi";

            string QueryBasTarihi = "select top 1 * from Anlik_Prosesler as ap " +
                                    " where ap.siparis_id = (select s.Id from Siparis as s where s.fis_no=@parametre1) " +
                                    " and baslangic_tarihi is null " +
                                    " order by proses_sirasi";

            if (textbox_fisno.Text.Length > 5)
            {
                DataTable dtProses = Sc.GET_DATATABLE(QueryProses, new string[] { textbox_fisno.Text });
                dtBas = Sc.GET_DATATABLE(QueryBasTarihi, new string[] { textbox_fisno.Text });
                dtBitis = Sc.GET_DATATABLE(QueryBitisTarihi, new string[] { textbox_fisno.Text });

                if (dtProses.Rows.Count > 0)
                {
                    if (dtBitis.Rows.Count > 0)
                    {
                        if (dtBas.Rows.Count > 0)
                        {
                            if (dtBas.Rows[0]["proses_id"].Equals(dtBitis.Rows[0]["proses_id"]))
                            {
                                // Giriş İşlemi
                                textbox_hareket.Text = "Giriş";
                                isGiris = true;
                            }
                            else
                            {
                                // Çıkış İşlemi
                                textbox_hareket.Text = "Çıkış";
                                isGiris = false;
                            }

                            textbox_proses.Text = Sc.GET_DATATABLE("select id, kod+' - '+isim as [kodisim] from Proses where Id=@parametre1", new string[] { dtBitis.Rows[0]["proses_id"].ToString() }).Rows[0]["kodisim"].ToString();
                            //combobox_proses.SelectedValue = dtBitis.Rows[0]["proses_id"];
                        }
                        else
                        {
                            // Çıkış İşlemi
                            textbox_hareket.Text = "Çıkış";
                            isGiris = false;
                            textbox_proses.Text = Sc.GET_DATATABLE("select id, kod+' - '+isim as [kodisim] from Proses where Id=@parametre1", new string[] { dtBitis.Rows[0]["proses_id"].ToString() }).Rows[0]["kodisim"].ToString();

                        }
                    }
                }
                else
                {
                    textbox_hareket.Text = "";
                    textbox_proses.Text = "";
                }
            }
        }

        DataTable dtBas, dtBitis;
        private bool isGiris = true;

        private void button_giris_cikis_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                string sipari_id = Sc.GET_TEKDEGER("Select top 1 Id from Siparis where fis_no=@parametre1", new string[] { textbox_fisno.Text });
                if (isGiris)
                {
                    // Giriş
                    query = "update Anlik_Prosesler set baslangic_tarihi=@parametre1, personel_no=@parametre5 where siparis_id=@parametre2 and proses_id=@parametre3 and talimat_id=@parametre4";
                    if (Sc.QUERY_TABLE(query, new string[] { DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), dtBas.Rows[0]["siparis_id"].ToString(), dtBas.Rows[0]["proses_id"].ToString(), dtBas.Rows[0]["talimat_id"].ToString(), User.id.ToString() }))
                    {
                        MessageBox.Show("Başarılı");
                        loadDataGrid(sipari_id);
                    }
                }
                else
                {
                    // Çıkış
                    query = "update Anlik_Prosesler set bitis_tarihi=@parametre1, personel_no=@parametre5 where siparis_id=@parametre2 and proses_id=@parametre3 and talimat_id=@parametre4";
                    if (Sc.QUERY_TABLE(query, new string[] { DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), dtBitis.Rows[0]["siparis_id"].ToString(), dtBitis.Rows[0]["proses_id"].ToString(), dtBitis.Rows[0]["talimat_id"].ToString(), User.id.ToString() }))
                    {
                        MessageBox.Show("Başarılı");
                        loadDataGrid(sipari_id);
                    }
                }

                giriscikis();
            } catch (Exception h)
            {
                MessageBox.Show("Sipariş Proses İşlemleri Tamamlanmış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadDataGrid(string siparis_id)
        {
            datagridview_anlikproses.DataSource = Sc.GET_DATATABLE("select ap.baslangic_tarihi as [Başlangıç Tarihi], ap.bitis_tarihi as [Bitiş Tarihi], ap.proses_sirasi as [Sıra], p.kod+' - '+p.isim as [Proses], t.talimat_kodu+' - '+t.talimat_adi as [Talimat] from Anlik_Prosesler as ap" +
                " right join Proses as p on p.Id=ap.proses_id " +
                " right join Talimat as t on t.Id=ap.talimat_id " +
                " where siparis_id=@parametre1 order by proses_sirasi asc", new string[] { siparis_id });
            if (datagridview_anlikproses.Columns.Count > 2)
            {
                datagridview_anlikproses.Columns["Başlangıç Tarihi"].DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss";
                datagridview_anlikproses.Columns["Bitiş Tarihi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string sipari_id = Sc.GET_TEKDEGER("Select top 1 Id from Siparis where fis_no=@parametre1", new string[] { textbox_fisno.Text });
            loadDataGrid(sipari_id);
        }

        private void textbox_fisno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sipari_id = Sc.GET_TEKDEGER("Select top 1 Id from Siparis where fis_no=@parametre1", new string[] { textbox_fisno.Text });
                loadDataGrid(sipari_id);
            }
        }
    }
}