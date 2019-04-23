using LPROS.Custom;
using LPROS.Forms.Table.Info;
using LPROS.Forms.Table.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms_Panel
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Personel_Load(object sender, EventArgs e)
        {
            Items.panelPersonel = new PanelGridView
            {
                form = this,
                dataGridview = datagridview_personel
            };


            datagridview_personel.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel);
            datagridview_personel.Columns[1].Visible = false;
            datagridview_personel.Columns["sifre"].Visible = false;
        }

        private void datagridview_personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["ayrinti"].Index && e.RowIndex >= 0)
            {
                Info_Personel ifp = new Info_Personel()
                {
                    _SelectedTc = datagridview_personel.Rows[e.RowIndex].Cells["TC Kimlik Numarası"].Value.ToString(),
                    _SelectedIsim = datagridview_personel.Rows[e.RowIndex].Cells["Adı"].Value.ToString(),
                    _SelectedSoyisim = datagridview_personel.Rows[e.RowIndex].Cells["Soyadı"].Value.ToString(),
                    _SelectedKullaniciAdi = datagridview_personel.Rows[e.RowIndex].Cells["Kullanıcı Adı"].Value.ToString(),
                    _SelectedSifre = datagridview_personel.Rows[e.RowIndex].Cells["sifre"].Value.ToString(),
                    _SelectedEposta = datagridview_personel.Rows[e.RowIndex].Cells["E_Posta"].Value.ToString(),
                    _SelectedAdres = datagridview_personel.Rows[e.RowIndex].Cells["Adres"].Value.ToString(),
                    _SelectedSSKNo = datagridview_personel.Rows[e.RowIndex].Cells["SSK Numarası"].Value.ToString(),
                    _SelectedSSKBas = datagridview_personel.Rows[e.RowIndex].Cells["SSK Başlangıç Tarihi"].Value.ToString(),
                    _SelectediseGiris = datagridview_personel.Rows[e.RowIndex].Cells["İşe Giriş Tarihi"].Value.ToString(),
                    _SelectedCinsiyet = datagridview_personel.Rows[e.RowIndex].Cells["Cinsiyet"].Value.ToString(),
                    _SelectedDepartman = datagridview_personel.Rows[e.RowIndex].Cells["Departman"].Value.ToString(),
                    _SelectedYetki = datagridview_personel.Rows[e.RowIndex].Cells["Yetki"].Value.ToString(),
                    _SelectedMaas = datagridview_personel.Rows[e.RowIndex].Cells["Maaş"].Value.ToString(),
                    _SelectedDurumu = datagridview_personel.Rows[e.RowIndex].Cells["Durumu"].Value.ToString(),
                    _SelectedTelefon = datagridview_personel.Rows[e.RowIndex].Cells["Telefon Numarası"].Value.ToString(),
                    _SelectedId = datagridview_personel.Rows[e.RowIndex].Cells["personel_no"].Value.ToString(),
                    _SelectedGuvenlik = datagridview_personel.Rows[e.RowIndex].Cells["Güvenlik Sorusu"].Value.ToString(),
                    _SelectedGuvenlikcvp = datagridview_personel.Rows[e.RowIndex].Cells["Güvenlik Sorusu Cevabı"].Value.ToString(),
                };
                ifp.ShowDialog();
            }
        }
    }
}
