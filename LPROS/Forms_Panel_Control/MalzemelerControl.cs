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
            if (textBox5.Text == "" && textBox1.Text == "" && textBox4.Text == "")
            {
                Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
            }
            else if (textBox5.Text == "")
            { 
                if (textBox4.Text !="" && textBox1.Text == "")
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat<=@parametre1", new string[] { textBox4.Text});
                }
                else if (textBox1.Text != "" && textBox4.Text == "")
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat>=@parametre1", new string[] { textBox1.Text });
                }
                else if (textBox4.Text != "" && textBox1.Text != "" && Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(textBox4.Text))
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat BETWEEN @parametre1 AND @parametre2", new string[] { textBox1.Text, textBox4.Text });
                }
            }
            else if (textBox5.Text != "")
            {
                if (textBox4.Text != "")
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where  fiyat<=@parametre1 AND adi=@parametre2 ", new string[] { textBox4.Text, textBox5.Text});
                }
                else if (textBox1.Text != "")
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where fiyat>=@parametre1  AND adi=@parametre2", new string[] { textBox1.Text, textBox5.Text });
                }
                else if (textBox4.Text != "" && textBox1.Text != "" && Convert.ToInt16(textBox1.Text) < Convert.ToInt16(textBox4.Text))
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where adi=@parametre1 AND fiyat BETWEEN @parametre2 AND @parametre3", new string[] { textBox5.Text, textBox1.Text,textBox4.Text });
                }
                else
                {
                    Items.panelMalzemeler.dataGridview.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler + " where adi=@parametre1", new string[] { textBox5.Text });
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
    }
}
