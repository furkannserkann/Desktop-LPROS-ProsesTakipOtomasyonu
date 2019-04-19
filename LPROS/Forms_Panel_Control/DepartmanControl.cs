using LPROS.Custom;
using LPROS.Custom.ItemControl;
using LPROS.Forms.Table.Add;
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
    public partial class DepartmanControl : Form
    {
        public DepartmanControl()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void DepartmanControl_Load(object sender, EventArgs e)
        {
            groupBox1.Paint += PaintBorderlessGroupBox1;
            groupBox2.Paint += PaintBorderlessGroupBox2;

            YetkiLoad();

            itemDepartmanControl.PersonelIsim = textbox_personel_isim;
            itemDepartmanControl.PersonelSoyisim = textbox_personel_soyisim;
            itemDepartmanControl.PersonelDurum = combobox_durum;
            itemDepartmanControl.PerosnelYetki = combobox_yetki;
        }

        private void YetkiLoad()
        {
            DataTable dt = Sc.GET_DATATABLE(SqlConnector.TableYetki);

            combobox_yetki.Items.Clear();
            combobox_yetki.Items.Add("");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                combobox_yetki.Items.Add(dt.Rows[i][1].ToString());
            }
            combobox_yetki.SelectedIndex = 0;
            combobox_durum.SelectedIndex = 0;
        }

        private void PaintBorderlessGroupBox1(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 95, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void PaintBorderlessGroupBox2(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 66, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void button_ekledepartman_Click(object sender, EventArgs e)
        {
            Add_Departman addDep = new Add_Departman()
            {
                isUpdate = false
            };
            addDep.ShowDialog();
        }

        private void button_eklepersonel_Click(object sender, EventArgs e)
        {
            (new Add_Personel()).ShowDialog();
        }

        private void button_guncelle_departman_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelDepartman.dataGridUst;
            Add_Departman addDep = new Add_Departman()
            {
                isUpdate = true,
                _SelectedId = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["id"].Value.ToString(),
                _SelectedIsim = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["İsim"].Value.ToString()
            };

            addDep.ShowDialog();
        }

        private void textbox_ara_departmanisim_TextChanged(object sender, EventArgs e)
        {
            SearchDepartman();
        }

        private bool _SearchDepartmanClear = false;
        private void SearchDepartman()
        {
            if (!_SearchDepartmanClear)
            {
                String _Isim = textbox_ara_departmanisim.Text;
                Items.panelDepartman.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman + " Where isim like '%'+@parametre1+'%'", new String[] { _Isim });
            }
            else
            {
                if (textbox_ara_departmanisim.Text != "")
                {
                    textbox_ara_departmanisim.Text = "";

                    Items.panelDepartman.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
                    _SearchDepartmanClear = false;
                }
            }
        }

        private void button_temizle_departmanisim_Click(object sender, EventArgs e)
        {
            _SearchDepartmanClear = true;
            SearchDepartman();
        }

        private void button_sil_departman_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Departman Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = Items.panelDepartman.dataGridUst;

                if (Sc.QUERY_TABLE("delete from Departman where id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelDepartman.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDepartman);
                }
            }
        }

        private void button_personel_ara_Click(object sender, EventArgs e)
        {
            searchPersonel();
        }

        private void searchPersonel()
        {
            DataGridView Dtg = Items.panelDepartman.dataGridUst;
            string departman_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString();
            Items.panelDepartman.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TablePersonelFilterByDepartmanid + " and p.ad like '%'+@parametre2+'%' and p.soyad like '%'+@parametre3+'%' and y.yetki_turu like '%'+@parametre4+'%' and [Durumu] like '%'+@parametre5+'%'", new String[] { departman_id, textbox_personel_isim.Text, textbox_personel_soyisim.Text, combobox_yetki.SelectedItem.ToString(), combobox_durum.SelectedItem == "Aktif" ? "1" : combobox_durum.SelectedItem == "" ? "" : "0" });
            Items.panelDepartman.dataGridAlt.Columns[0].Visible = false;
        }

        private void button_ara_personel_temizle_Click(object sender, EventArgs e)
        {
            textbox_personel_isim.Text = "";
            textbox_personel_soyisim.Text = "";
            combobox_durum.SelectedIndex = 0;
            combobox_yetki.SelectedIndex = 0;
            searchPersonel();
        }
    }
}
