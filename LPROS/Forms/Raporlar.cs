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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        SqlConnector Sc = new SqlConnector();
        double gelir, mgider,pgider, top, kar, masraf;
        string pasta_string;
        DataTable tek;

        private void Raporlar_Load(object sender, EventArgs e)
        {
            ara();
        }

        private void Raporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            MySetting.isOpenRapor = false;
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            ara();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                   chek();
        }

        private void datepicker_tarihbas_ValueChanged(object sender, EventArgs e)
        {
            datepicker_tarihson.MinDate = datepicker_tarihbas.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                datepicker_tarihson.Enabled = true;
            }
            else
            {
                datepicker_tarihson.Enabled = false;
            }
        }
        void chek()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            if(checkBox1.Checked)
            {
                 pasta_string = " select sum([Gelir]) as [Gelir], sum([Maliyet_ Gider]) as [Maliyet_ Gider], sum([Per_Gider]) as [Per_Gider] from ( " +
              " select teslim as [Tarih], sum([Gelir]) as [Gelir], sum([Gider]) as [Maliyet_ Gider], (select sum(maas / 30) " +
              " from Personel where ise_giris_tarih < m.teslim and durumu = 1) as [Per_Gider] from( " +
              " Select s.teslim_tarihi as [teslim], " +
              " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
              "    inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
              "    inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
              "    inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
              "    where pt.protez_id = s.protez_id) as [Gider], " +
              " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
              " inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
              " inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
              " inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
              " where pt.protez_id = s.protez_id) *1.28 as [Gelir] " +
              " from Siparis as s ) m " +
              " group by teslim  having [teslim] between @parametre1 and @parametre2 ) PASTA_T " ;
                tek = Sc.GET_DATATABLE(pasta_string, new string[] { datepicker_tarihbas.Value.ToString("yyyy/MM/dd"), datepicker_tarihson.Value.ToString("yyyy/MM/dd") });
                

            }
            else
            {
              pasta_string = " select sum([Gelir]) as [Gelir], sum([Maliyet_ Gider]) as [Maliyet_ Gider], sum([Per_Gider]) as [Per_Gider] from ( " +
             " select teslim as [Tarih], sum([Gelir]) as [Gelir], sum([Gider]) as [Maliyet_ Gider], (select sum(maas / 30) " +
              " from Personel where ise_giris_tarih < m.teslim and durumu = 1) as [Per_Gider] from( " +
                " Select s.teslim_tarihi as [teslim], " +
                " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
                "    inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
                "    inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
                "    inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
                "    where pt.protez_id = s.protez_id) as [Gider], " +
                " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
                " inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
                " inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
                " inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
                " where pt.protez_id = s.protez_id) *1.28 as [Gelir] " +
                " from Siparis as s ) m " +
                " group by teslim  having [teslim]=@parametre1) PASTA_T ";
                tek = Sc.GET_DATATABLE(pasta_string, new string[] { datepicker_tarihbas.Value.ToString("yyyy/MM/dd") });
            }



            if (tek.Rows[0][0].ToString() != "" && tek.Rows[0][1].ToString() != "" && tek.Rows[0][2].ToString() != "")
            {
                gelir = Convert.ToDouble(tek.Rows[0][0].ToString());
                mgider = Convert.ToDouble(tek.Rows[0][1].ToString());
                pgider = Convert.ToDouble(tek.Rows[0][2].ToString());

                top = pgider + mgider;
                kar = gelir - top;
                masraf = gelir - kar;
                if (checkBox2.Checked)
                {
                    chart1.Series["PASTA"].Points.Add(gelir);
                    chart1.Series["PASTA"].Points.Add(pgider + mgider);

                    chart1.Series["PASTA"].Points[0].AxisLabel = "Toplam Gelir=" + gelir + " ₺";
                    chart1.Series["PASTA"].Points[1].AxisLabel = "Toplam Gider=" + top + " ₺";

                    chart1.Series["PASTA"].Points[0].Color = Color.FromArgb(178, 8, 55);
                    chart1.Series["PASTA"].Points[1].Color = Color.White;
                }
                else
                {
                    chart1.Series["PASTA"].Points.Add(masraf);
                    chart1.Series["PASTA"].Points.Add(kar);
                    chart1.Series["PASTA"].Points.Add(pgider);
                    chart1.Series["PASTA"].Points.Add(mgider);

                    chart1.Series["PASTA"].Points[0].AxisLabel = "Masraf=" + masraf + " ₺";
                    chart1.Series["PASTA"].Points[1].AxisLabel = "Kar=" + kar + " ₺";
                    chart1.Series["PASTA"].Points[2].AxisLabel = "Personel Gider=" + pgider + " ₺";
                    chart1.Series["PASTA"].Points[3].AxisLabel = "Maliyet=" + mgider + " ₺";

                    chart1.Series["PASTA"].Points[0].Color = Color.RoyalBlue;
                    chart1.Series["PASTA"].Points[1].Color = Color.Aqua;
                    chart1.Series["PASTA"].Points[2].Color = Color.Red;
                    chart1.Series["PASTA"].Points[3].Color = Color.Orange;

                }
            }
        }
        void ara()
        {
            if (checkBox1.Checked)
            {
                DataTable tmaliyet = Sc.GET_DATATABLE("select teslim as [Tarih], sum([Gelir]) as [Gelir], (sum([Gider]) +(select sum(maas / 30) " +
              " from Personel where ise_giris_tarih < @parametre1 and durumu = 1)) as [Gider], " +
              " sum([Gelir])-(sum([Gider]) + (select sum(maas / 30) from Personel where ise_giris_tarih < @parametre1 and durumu = 1)) as [Kar] from( " +
              "   Select s.teslim_tarihi as [teslim], " +
              "   (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
              "   inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
              "   inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
              "   inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
              "   where pt.protez_id = s.protez_id) as [Gider], " +
              " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
              " inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
              " inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
              " inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
              " where pt.protez_id = s.protez_id) *1.28 as [Gelir] " +
              " from Siparis as s) m " +
              " group by teslim  having [teslim] between @parametre1 and @parametre2 order by teslim ", new string[] { datepicker_tarihbas.Value.ToString("yyyy/MM/dd"), datepicker_tarihson.Value.ToString("yyyy/MM/dd") });

                datagridview_Siparis.DataSource = tmaliyet;



            }
            else
            {
                DataTable tmaliyet = Sc.GET_DATATABLE("select teslim as [Tarih], sum([Gelir]) as [Gelir], (sum([Gider]) +(select sum(maas / 30) " +
                    " from Personel where ise_giris_tarih < @parametre1 and durumu = 1)) as [Gider], " +
                    " sum([Gelir])-(sum([Gider]) + (select sum(maas / 30) from Personel where ise_giris_tarih < @parametre1 and durumu = 1)) as [Kar] from( " +
                    "   Select s.teslim_tarihi as [teslim], " +
                    "   (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
                    "   inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
                    "   inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
                    "   inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
                    "   where pt.protez_id = s.protez_id) as [Gider], " +
                    " (select sum(m.fiyat * pm.adet) as [Toplam Fiyat] from Malzemeler as m " +
                    " inner join Proses_Malzemeleri as pm on pm.malzeme_id = m.id " +
                    " inner join Talimat_Prosesleri as tp on pm.proses_id = tp.proses_id " +
                    " inner join Protez_Talimatlari as pt on pt.talimat_id = tp.talimat_id " +
                    " where pt.protez_id = s.protez_id) *1.28 as [Gelir] " +
                    " from Siparis as s) m " +
                    " group by teslim  having [teslim]=@parametre1 order by teslim ", new string[] { datepicker_tarihbas.Value.ToString("yyyy/MM/dd") });

                datagridview_Siparis.DataSource = tmaliyet;


            }
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chek();

        }
    }
}
