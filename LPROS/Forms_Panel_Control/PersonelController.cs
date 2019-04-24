using LPROS.Custom;
using LPROS.Forms;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Search;
using LPROS.Forms.Table.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPROS.Forms_Panel_Control
{
    public partial class PersonelController : Form
    {
        public PersonelController()
        {
            InitializeComponent();
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Add_Personel adPer = new Add_Personel()
            {
                isUpdate = false

            };
            adPer.ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {

        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView dtg = Items.panelPersonel.dataGridview;
            if (dtg.Rows.Count > 0)
            {
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
        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Personel()).ShowDialog();
        }

        SqlConnector Sc = new SqlConnector();
        private void button_sil_Click_1(object sender, EventArgs e)
        {
            if (Items.panelPersonel.dataGridview.Rows.Count > 0)
            {
                DialogResult Dr = MessageBox.Show("Seçilen Personel Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (Dr == DialogResult.OK)
                {
                    DataGridView Dtg = Items.panelPersonel.dataGridview;

                    if (User.id != Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["personel_no"].Value.ToString())
                    {
                        if (Sc.QUERY_TABLE("delete from Personel where personel_no=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["personel_no"].Value.ToString() }))
                        {
                            MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Items.panelPersonel.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Oturum Kullanıcısı Silinemez!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_Personel();
        }
        private void Search_Personel()
        {
            DataGridView Dtg = Items.panelPersonel.dataGridview;

            Items.panelPersonel.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonel + " where ad like '%'+@parametre1+'%' and soyad like '%'+@parametre2+'%' and durumu like '%'+@parametre3+'%' and yetki_id like '%'+@parametre4+'%'  ",
                new String[] { textBox_isim.Text, textBox_soyisim.Text, Combo_durumu.SelectedIndex == 0 ? "" : Combo_durumu.SelectedIndex == 1 ? "1" : "0", (int)Combo_yetki.SelectedValue == 0 ? "" : Combo_yetki.SelectedValue.ToString() });

            //Items.panelPersonel.dataGridview.Columns[0].Visible = false;
        }

        private void PersonelController_Load(object sender, EventArgs e)
        {
            DataTable yetki = Sc.GET_DATATABLE(SqlConnector.TableYetki);

            DataRow emptyRow = yetki.NewRow();
            emptyRow["id"] = 0;
            emptyRow["Yetki Türü"] = "";
            yetki.Rows.Add(emptyRow);

            DataView newView = new DataView(yetki, "", "Yetki Türü", DataViewRowState.CurrentRows);

            Combo_yetki.DataSource = newView;
            Combo_yetki.ValueMember = "id";
            Combo_yetki.DisplayMember = "Yetki Türü";

            Combo_durumu.SelectedIndex = 0;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_isim.Text = "";
            textBox_soyisim.Text = "";
            Combo_durumu.Text = "";
            Combo_yetki.Text = "";
            Search_Personel();
        }
    }
}
