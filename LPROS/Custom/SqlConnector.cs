using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Custom
{
    class SqlConnector
    {
        public SqlConnection CON { get; }


        #region Tables

        public static String TableSiparis
        {
            get
            {
                return "SELECT s.id, fis_no as [Fiş Numarası], p.ad + ' ' + p.soyad as [Kayıt Personeli], " +
                    "siparis_tarihi as [Sipariş Tarihi], teslim_tarihi as [Teslim Tarihi], h.ad as [Hastane], " +
                    "d.isim + ' ' + d.soyisim as [Doktor], hasta_ad_soyad as [Hasta İsmi], " +
                    "pr.adi as [Protez Tipi], renk.isim as [Renk] from Siparis as s " +
                    "inner join Personel as p on s.personel_id = p.personel_no " +
                    "inner join Doktorlar as d on d.id = s.doktor_id " +
                    "inner join Hastane as h on h.Id = d.hastane_id " +
                    "inner join Protez as pr on pr.id = s.protez_id " + 
                    "inner join Renk as renk on renk.id = s.renk_id";
            }
        }
        public static String TablePersonel
        {
            get
            {
                return "SELECT personel_no, tc as [TC Kimlik Numarası], ad as [Adı], soyad as [Soyadı], telefon as [Telefon Numarası] ,cinsiyet as [Cinsiyet], ssk_no [SSK Numarası],adres as [Adres], " +
                    " d.isim as [Departman], e_posta as [E_Posta], kullanici_adi as [Kullanıcı Adı], maas as [Maaş], sifre, " +
                    " y.yetki_turu as [Yetki], ssk_bas_tarih as [SSK Başlangıç Tarihi] , ise_giris_tarih as [İşe Giriş Tarihi], (CASE WHEN durumu = 1 THEN 'Aktif' ELSE 'Pasif' END) as [Durumu] from Personel as p " +
                    " inner join Departman as d on d.id = p.departman_no "+
                    " inner join Yetkiler as y on y.id = p.yetki_id";
            }
        }
        public static String TablePersonelFilterByDepartmanid
        {
            get
            {
                return "SELECT personel_no, ad as [Adı], soyad as [Soyadı], " +
                    "(CASE WHEN durumu = 1 THEN 'Aktif' ELSE 'Aktif Değil' END) as [Durumu], " +
                    "e_posta as [E_Posta], y.yetki_turu as [Yetki] from Personel as p " +
                    "inner join Yetkiler as y on y.id = p.yetki_id " +
                    "where departman_no=@parametre1 ";
            }
        }
        public static String TableHastane
        {
            get
            {
                return "SELECT id as [ID], kod as [Kod], ad as [Adı], adres as [Adres] from Hastane";
            }
        }
        public static String TableDoktorByHastaneid
        {
            get
            {
                return "SELECT id as [ID], isim as [İsim], soyisim as [Soyisim], " +
                    "(CASE WHEN aktif = 1 THEN 'Aktif' ELSE 'Pasif' END) as [Durumu] " +
                    "from Doktorlar where hastane_id=@parametre1";
            }
        }
        public static String TableProtez
        {
            get
            {
                return "select id, kod as [Kod], adi as [İsim] from Protez";
            }
        }
        public static String TableTalimat
        {
            get
            {
                return "select id, talimat_kodu as [Talimat Kodu], talimat_adi as [Talimat İsmi] from Talimat";
            }
        }
        public static String TableProses
        {
            get
            {
                return "select id, kod as [Kod], isim as [İsim] from Proses";
            }
        }
        public static String TableDepartman
        {
            get
            {
                return "select id, isim as [İsim] from Departman";
            }
        }
        public static String TableRenk
        {
            get
            {
                return "select id, kod as [Renk Kodu], isim as [İsim] from Renk";
            }
        }
        public static String TableYetki
        {
            get
            {
                return "select id, yetki_turu as [Yetki Türü] from Yetkiler";
            }
        }
        public static String TableMalzemeler
        {
            get
            {
                return "select Id, adi as [Adı], fiyat as [Fiyat] from Malzemeler";
            }
        }
        public static String TableMalzemelerByProsesid
        {
            get
            {
                return "select m.Id, m.adi as [Adı], pm.adet as [Adet], m.fiyat*pm.adet as [Toplam Fiyat] from Proses_Malzemeleri as pm " +
                    " inner join Malzemeler as m on m.Id=pm.malzeme_id " +
                    " inner join Proses as p on p.Id=pm.proses_id where pm.proses_id=@parametre1 order by m.adi asc";
            }
        }
        public static String TableProsesByTalimatid
        {
            get
            {
                return "select tp.id, tp.sira as [Sira], p.kod as [Kod], p.isim as [İsim] from Talimat_Prosesleri as tp " +
                    " inner join Talimat as t on t.Id=tp.talimat_id " +
                    " inner join Proses as p on p.Id=tp.proses_id where tp.talimat_id=@parametre1 order by tp.sira asc";
            }
        }
        public static String TableTalimatByProtezid
        {
            get
            {
                return "select pt.id, pt.sira as [Sıra], t.talimat_kodu as [Talimat Kodu], t.talimat_adi as [Talimat İsmi] from Protez_Talimatlari as pt " +
                    " inner join Talimat as t on t.Id=pt.talimat_id " +
                    " inner join Protez as p on p.Id=pt.protez_id where pt.protez_id=@parametre1 order by pt.sira asc";
            }
        }
        public static String TableAnlikProsesBySiparis
        {
            get
            {
                return "select ap.Id, t.talimat_adi as [Talimat], proses_sirasi as [Sıra], p.isim as [Proses], per.ad+' '+per.soyad as [Personel], ap.baslangic_tarihi as [Başlangıç Tarihi], ap.bitis_tarihi as [Bitiş Tarihi] from Anlik_Prosesler as ap " +
" left join Proses as p on ap.proses_id = p.Id " +
" left join Talimat as t on ap.talimat_id = t.Id " +
" left join Personel as per on ap.personel_no = per.personel_no " +
" where siparis_id = @parametre1 order by talimat_id, proses_sirasi";
            }
        }

        #endregion

        string dbLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        public SqlConnector()
        {
            CON = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbLocation + @"\LPROS.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public void setCON_EMPTY(Boolean OPEN)
        {
            if (OPEN)
            {
                if (CON.State == ConnectionState.Closed)
                    CON.Open();
            }
            else
            {
                if (CON.State == ConnectionState.Open)
                    CON.Close();
            }
        }

        public DataTable GET_DATATABLE(string COMMAND)
        {
            setCON_EMPTY(true);
            DataTable DATA_TABLE = new DataTable();
            SqlCommand SQL_COMMAND = new SqlCommand(COMMAND, CON);
            SqlDataReader SDR = SQL_COMMAND.ExecuteReader();
            DATA_TABLE.Load(SDR);
            setCON_EMPTY(false);
            return DATA_TABLE;
        }

        public DataTable GET_DATATABLE(string COMMAND, string[] parameters)
        {
            try
            {
                setCON_EMPTY(true);
                DataTable DATA_TABLE = new DataTable();
                SqlCommand SQL_COMMAND = new SqlCommand(COMMAND, CON);
                for (int i = 0; i < parameters.Length; i++)
                    SQL_COMMAND.Parameters.AddWithValue("@parametre" + (i + 1), parameters[i]);

                SqlDataReader SDR = SQL_COMMAND.ExecuteReader();
                DATA_TABLE.Load(SDR);
                setCON_EMPTY(false);
                return DATA_TABLE;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString() , "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            setCON_EMPTY(false);
            return new DataTable();
        }

        public String GET_TEKDEGER(string COMMAND, string[] parameters)
        {
            try
            {
                setCON_EMPTY(true);
                SqlCommand SQL_COMMAND = new SqlCommand(COMMAND, CON);
                for (int i = 0; i < parameters.Length; i++)
                    SQL_COMMAND.Parameters.AddWithValue("@parametre" + (i + 1), parameters[i]);

                string VALUE = SQL_COMMAND.ExecuteScalar().ToString();
                setCON_EMPTY(false);
                return VALUE;
            }
            catch (Exception e)
            {
                return "-1";
            }
        }

        public bool ADD_PROSES(String kod, String isim)
        {
            try
            {
                setCON_EMPTY(true);
                string kayit = "insert into Proses(kod,isim) values (@parametre1,@parametre2)";
                SqlCommand komut = new SqlCommand(kayit, CON);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@parametre1", kod);
                komut.Parameters.AddWithValue("@parametre2", isim);
                komut.ExecuteNonQuery();
                setCON_EMPTY(false);
                return true;
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

            setCON_EMPTY(false);
            return false;
        }

        public bool ADD_TABLE(String TabloIsmi, String[] kolon_isimleri, String[] kolon_degerleri)
        {
            if (kolon_degerleri.Length == kolon_isimleri.Length)
            {
                try
                {
                    setCON_EMPTY(true);

                    SqlCommand command = new SqlCommand();

                    string query = "insert into " + TabloIsmi + "(";
                    string paramters = "";
                    for (int i = 0; i < kolon_degerleri.Length; i++)
                    {
                        if (kolon_degerleri.Length == i + 1)
                        {
                            query = query + kolon_isimleri[i];
                            paramters = paramters + " @parametre" + (i + 1);
                        }
                        else
                        {
                            query = query + kolon_isimleri[i] + ",";
                            paramters = paramters + "@parametre" + (i + 1) + ",";
                        }

                        command.Parameters.AddWithValue("@parametre" + (i + 1), kolon_degerleri[i]);
                    }
                    query = query + ") values(" + paramters + ")";

                    command.CommandText = query;
                    command.Connection = CON;

                    //string kayit = "insert into Proses(kod,isim) values (@parametre1,@parametre2)";
                    //SqlCommand komut = new SqlCommand(query, CON);
                        

                    command.ExecuteNonQuery();
                    setCON_EMPTY(false);
                    return true;

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }

            setCON_EMPTY(false);
            return false;
        }

        public bool QUERY_TABLE(String query, String[] parameters)
        {
            try
            {
                setCON_EMPTY(true);
                SqlCommand komut = new SqlCommand(query, CON);

                for (int i = 0; i < parameters.Length; i++)
                    komut.Parameters.AddWithValue("@parametre" + (i + 1), parameters[i]);

                komut.ExecuteNonQuery();
                setCON_EMPTY(false);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            setCON_EMPTY(false);
            return false;
        }

        public void LoadTable(String Com, DataGridView datagridview, SqlConnector scc)
        {
            scc.setCON_EMPTY(true);

            SqlCommand komut = new SqlCommand(Com, scc.CON);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);
            datagridview.DataSource = dt;

            scc.setCON_EMPTY(false);
        }

        public void LoadTable(String Com, String[] parameters, DataGridView datagridview, SqlConnector sqlconnector)
        {
            sqlconnector.setCON_EMPTY(true);

            SqlCommand komut = new SqlCommand(Com, sqlconnector.CON);
            for (int i = 0; i < parameters.Length; i++)
                komut.Parameters.AddWithValue("@parametre" + (i + 1), parameters[i]);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();

            da.Fill(dt);
            //datagridview.Rows.Clear();
            datagridview.DataSource = dt;
            //datagridview.Refresh();

            sqlconnector.setCON_EMPTY(false);
        }
    }
}