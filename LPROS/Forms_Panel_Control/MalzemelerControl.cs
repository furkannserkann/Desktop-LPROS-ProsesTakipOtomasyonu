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
    public partial class MalzemelerControl : Form
    {
        public MalzemelerControl()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Add_Malzemeler addMalzeme = new Add_Malzemeler()
            {
                isUpdate = false
            };
            addMalzeme.ShowDialog();
        }

        private void button_malzeme_guncelle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelMalzemeler.dataGridview;
            Add_Malzemeler addMalzeme = new Add_Malzemeler()
            {
                isUpdate = true,
                _Selectid = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Id"].Value.ToString(),
                _Selectad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Adı"].Value.ToString(),
                _Selectfiyat = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Fiyat"].Value.ToString()
            };
            addMalzeme.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Seçilen Malzeme Siliniyor!", "Silme İşlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (Dr == DialogResult.OK)
            {
                DataGridView Dtg = Items.panelMalzemeler.dataGridview;

                if (Sc.QUERY_TABLE("delete from Malzemeler where Id=@parametre1", new String[] { Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString() }))
                {
                    MessageBox.Show("Silme İşlemi Başarılı!", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelMalzemeler.dataGridview;
            //string malzeme_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (textBox1.Visible == false && textBox4.Text !="")
            {
                Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat=" + textBox4.Text);
            }
            else if (textBox1.Visible == true && textBox4.Text != "" && textBox1.Text != "")
            {
                Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat BETWEEN " +  textBox4.Text + " AND " +textBox1.Text);
            }
            else
            {
                Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
            }
            Items.panelMalzemeler.dataGridview.Columns[0].Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox2.Checked==true) checkBox1.Checked = false;
            textBox1.Visible = true;
            label4.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) checkBox2.Checked = false;
            textBox1.Visible = false;
            label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            textBox1.Visible = false;
            label4.Visible = false;

        }
    }
}
