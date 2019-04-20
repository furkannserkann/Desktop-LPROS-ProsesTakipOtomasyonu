using LPROS.Custom;
using LPROS.Forms.Table.Add;
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
    public partial class HastanelerDoktorlarControl : Form
    {
        public HastanelerDoktorlarControl()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void HastanelerDoktorlarControl_Load(object sender, EventArgs e)
        {
            groupBox1.Paint += PaintBorderlessGroupBox1;
            groupBox2.Paint += PaintBorderlessGroupBox2;
            comboBox1.SelectedIndex = 2;
        }

        private void PaintBorderlessGroupBox1(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 80, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void PaintBorderlessGroupBox2(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 1);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, 70, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void button_eklehastane_Click(object sender, EventArgs e)
        {
            (new Add_Hastane()).ShowDialog();
        }

        private void button_ekledoktor_Click(object sender, EventArgs e)
        {
            DataGridView Dtg2 = Items.panelHastaneDoktor.dataGridUst;
            DataGridView Dtg = Items.panelHastaneDoktor.dataGridAlt;
            Add_Doktor addDoktor = new Add_Doktor()
            {
                isUpdate = false,
                _Select_hastane_id = Dtg2.Rows[Dtg2.CurrentCell.RowIndex].Cells["ID"].Value.ToString()

            };

            addDoktor.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_isim.Text == "" && textBox1.Text == "" && textBox2.Text == "")
            {
                Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
            }
            if (textBox2.Text != "" || textBox1.Text != "" || textBox_isim.Text != "")
            {
                Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane + " where adres like '%'+@parametre1+'%' AND ad like '%'+@parametre2+'%' AND kod like '%'+@parametre3+'%'", new string[] { textBox2.Text, textBox1.Text, textBox_isim.Text });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox_isim.Text = "";
            Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Hastane Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = Items.panelHastaneDoktor.dataGridUst;

                if (Sc.QUERY_TABLE("delete from Hastane where id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["ID"].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelHastaneDoktor.dataGridUst.DataSource = Sc.GET_DATATABLE(SqlConnector.TableHastane);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Doktor Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {

                DataGridView Dtg2 = Items.panelHastaneDoktor.dataGridUst;
                DataGridView Dtg = Items.panelHastaneDoktor.dataGridAlt;

                if (Sc.QUERY_TABLE("delete from Doktorlar where id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["ID"].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelHastaneDoktor.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new String[] { Dtg2.Rows[Dtg2.CurrentCell.RowIndex].Cells["ID"].Value.ToString() });
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataGridView Dtg2 = Items.panelHastaneDoktor.dataGridUst;
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.SelectedIndex = 2;
            Items.panelHastaneDoktor.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid, new String[] { Dtg2.Rows[Dtg2.CurrentCell.RowIndex].Cells["ID"].Value.ToString() });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView Dtg2 = Items.panelHastaneDoktor.dataGridUst;
            Items.panelHastaneDoktor.dataGridAlt.DataSource = Sc.GET_DATATABLE(SqlConnector.TableDoktorByHastaneid + " AND isim like '%'+@parametre2+'%' AND soyisim like '%'+@parametre3+'%' AND aktif like '%'+@parametre4+'%'", new String[] { Dtg2.Rows[Dtg2.CurrentCell.RowIndex].Cells["ID"].Value.ToString(), textBox5.Text, textBox4.Text, comboBox1.SelectedIndex == 0 ? "1" : comboBox1.SelectedIndex == 1 ? "0" : "" });

        }
    }
}