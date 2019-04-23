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

namespace LPROS.Forms_Panel
{
    public partial class Prosesler : Form
    {
        public Prosesler()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        public static String SelectedProsesID = "";

        private void Prosesler_Load(object sender, EventArgs e)
        {
            Items.panelProses = new PanelGridViewTwo
            {
                form = this,
                dataGridUst = datagridview_prosesler,
                dataGridAlt = datagridview_proses_malzemeleri
            };

            datagridview_prosesler.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
            datagridview_prosesler.Columns[0].Visible = false;


            if (datagridview_prosesler.RowCount > 0)
            {
                SelectedProsesID = datagridview_prosesler.Rows[0].Cells[0].Value.ToString();
                datagridview_proses_malzemeleri.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { SelectedProsesID });
                datagridview_proses_malzemeleri.Columns[0].Visible = false;

                label_proses_malzemeleri_head.Text = datagridview_prosesler.Rows[0].Cells["İsim"].Value.ToString() + " Proses'inde Kullanılan Malzemeler";
            }
        }

        private void datagridview_prosesler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (SelectedProsesID != datagridview_prosesler.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    SelectedProsesID = datagridview_prosesler.Rows[e.RowIndex].Cells[0].Value.ToString();
                    datagridview_proses_malzemeleri.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemelerByProsesid, new String[] { SelectedProsesID });
                    datagridview_proses_malzemeleri.Columns[0].Visible = false;

                    label_proses_malzemeleri_head.Text = datagridview_prosesler.Rows[e.RowIndex].Cells["İsim"].Value.ToString() + " Proses'inde Kullanılan Malzemeler";
                }
            }
        }
    }
}
