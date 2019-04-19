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
    public partial class Talimatlar : Form
    {
        public Talimatlar()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();
        String SelectedTalimatID = "";

        private void Talimatlar_Load(object sender, EventArgs e)
        {
            Items.panelTalimat = new PanelGridViewTwo
            {
                form = this,
                dataGridUst = datagridview_talimatlar,
                dataGridAlt = datagridview_talimat_prosesleri
            };

            datagridview_talimatlar.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
            datagridview_talimatlar.Columns[0].Visible = false;


            if (datagridview_talimatlar.RowCount > 0)
            {
                SelectedTalimatID = datagridview_talimatlar.Rows[0].Cells[0].Value.ToString();
                datagridview_talimat_prosesleri.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { SelectedTalimatID });
                datagridview_talimat_prosesleri.Columns[0].Visible = false;

                label_proses_malzemeleri_head.Text = datagridview_talimatlar.Rows[0].Cells["Talimat İsmi"].Value.ToString() + " Talimatına Ait Prosesler";
            }
        }

        private void datagridview_talimatlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (SelectedTalimatID != datagridview_talimatlar.Rows[e.RowIndex].Cells[0].Value.ToString())
                {
                    SelectedTalimatID = datagridview_talimatlar.Rows[e.RowIndex].Cells[0].Value.ToString();
                    datagridview_talimat_prosesleri.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProsesByTalimatid, new String[] { SelectedTalimatID });
                    datagridview_talimat_prosesleri.Columns[0].Visible = false;

                    label_proses_malzemeleri_head.Text = datagridview_talimatlar.Rows[e.RowIndex].Cells["Talimat İsmi"].Value.ToString() + " Talimatına Ait Prosesler";
                }
            }
        }
    }
}
