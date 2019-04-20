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

namespace LPROS.Forms.Table.Info
{
    public partial class Info_Siparis : Form
    {
        public Info_Siparis()
        {
            InitializeComponent();
        }

        public string siparisid;
        string tmaliyet;
        DateTime siparistarihi, teslimtarihi;

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        SqlConnector Sc = new SqlConnector();

        private void Info_Siparis_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            if (siparisid != "")
            {
                string siparistablosu = "SELECT s.id, fis_no as [Fiş Numarası], p.ad + ' ' + p.soyad as [Kayıt Personeli], " +
                    "siparis_tarihi as [Sipariş Tarihi], teslim_tarihi as [Teslim Tarihi], h.ad as [Hastane], " +
                    "d.isim + ' ' + d.soyisim as [Doktor], hasta_ad_soyad as [Hasta İsmi], " +
                    "pr.adi as [Protez Tipi], s.protez_id as [protez_id], renk.isim as [Renk] from Siparis as s " +
                    "inner join Personel as p on s.personel_id = p.personel_no " +
                    "inner join Doktorlar as d on d.id = s.doktor_id " +
                    "inner join Hastane as h on h.Id = d.hastane_id " +
                    "inner join Protez as pr on pr.id = s.protez_id " +
                    "inner join Renk as renk on renk.id = s.renk_id " +
                    "where s.id=@parametre1";
                DataTable TableSiparis = Sc.GET_DATATABLE(siparistablosu, new string[] { siparisid });

                datagridview_anlikproses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableAnlikProsesBySiparis, new String[] { siparisid });
                datagridview_anlikproses.Columns["Id"].Visible = false;

                siparistarihi = DateTime.Parse(TableSiparis.Rows[0]["Sipariş Tarihi"].ToString());
                teslimtarihi = DateTime.Parse(TableSiparis.Rows[0]["Teslim Tarihi"].ToString());

                tmaliyet = Sc.GET_TEKDEGER("select sum(m.fiyat*pm.adet) as [Toplam Fiyat] from Malzemeler as m "+
" inner join Proses_Malzemeleri pm on pm.malzeme_id = m.id"+
" inner join Talimat_Prosesleri tp on pm.proses_id = tp.proses_id"+
" inner join Protez_Talimatlari pt on pt.talimat_id = tp.talimat_id"+
" where pt.protez_id=@parametre1", new string[] { TableSiparis.Rows[0]["protez_id"].ToString() });

                textbox_fisno.Text = TableSiparis.Rows[0]["Fiş Numarası"].ToString();
                textbox_kayitpersoneli.Text = TableSiparis.Rows[0]["Kayıt Personeli"].ToString();
                textbox_hastane.Text = TableSiparis.Rows[0]["Hastane"].ToString();
                textbox_doktor.Text = TableSiparis.Rows[0]["Doktor"].ToString();
                textbox_hastaadsoyad.Text = TableSiparis.Rows[0]["Hasta İsmi"].ToString();
                textbox_siparistarihi.Text = siparistarihi.ToString("dd/mm/yyyy");
                textbox_teslimattarihi.Text = teslimtarihi.ToString("dd/mm/yyyy");
                textbox_proteztipi.Text = TableSiparis.Rows[0]["Protez Tipi"].ToString();
                textbox_renk.Text = TableSiparis.Rows[0]["Renk"].ToString();
                textbox_tmaliyet.Text = tmaliyet;
            }
        }
    }
}
