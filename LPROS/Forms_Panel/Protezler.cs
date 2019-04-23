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
    public partial class Protezler : Form
    {
        public Protezler()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        public static String SelectedProtezid = "";

        private void Protezler_Load(object sender, EventArgs e)
        {
            Items.panelProtez = new PanelGridViewTwo
            {
                form = this,
                dataGridUst = datagridview_protezler,
                dataGridAlt = datagridview_protez_talimatlari
            };

            datagridview_protezler.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);
            datagridview_protezler.Columns[0].Visible = false;


            if (datagridview_protezler.RowCount > 0)
            {
                SelectedProtezid = datagridview_protezler.Rows[0].Cells[0].Value.ToString();
                datagridview_protez_talimatlari.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimatByProtezid, new String[] { SelectedProtezid });
                datagridview_protez_talimatlari.Columns[0].Visible = false;

                label_proses_malzemeleri_head.Text = datagridview_protezler.Rows[0].Cells["İsim"].Value.ToString() + " Protezine Ait Talimatlar";
            }
        }

        private void datagridview_protezler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (SelectedProtezid != datagridview_protezler.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    SelectedProtezid = datagridview_protezler.Rows[e.RowIndex].Cells[0].Value.ToString();
                    datagridview_protez_talimatlari.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimatByProtezid, new String[] { SelectedProtezid });
                    datagridview_protez_talimatlari.Columns[0].Visible = false;

                    label_proses_malzemeleri_head.Text = datagridview_protezler.Rows[e.RowIndex].Cells["İsim"].Value.ToString() + " Protezine Ait Talimatlar";
                }
            }
        }
    }
}
