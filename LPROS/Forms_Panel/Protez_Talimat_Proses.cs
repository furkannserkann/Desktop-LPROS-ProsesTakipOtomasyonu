using LPROS.Custom;
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

namespace LPROS.Forms_Panel
{
    public partial class Protez_Talimat_Proses : Form
    {
        public Protez_Talimat_Proses()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Protez_Talimat_Proses_Load(object sender, EventArgs e)
        {
            Items.panelProtezTalimatProses = new PanelProtezTalimatProses
            {
                form = this,
                datagridProses = datagridview_proses,
                datagridProtez = datagridview_protez,
                datagridTalimat = datagridview_talimat
            };

            datagridview_protez.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProtez);
            datagridview_protez.Columns[1].Visible = false;

            datagridview_talimat.DataSource = Sc.GET_DATATABLE(SqlConnector.TableTalimat);
            datagridview_talimat.Columns[0].Visible = false;

            datagridview_proses.DataSource = Sc.GET_DATATABLE(SqlConnector.TableProses);
            datagridview_proses.Columns[0].Visible = false;

        }

        private void datagridview_protez_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["update1"].Index && e.RowIndex >= 0)
            {
                (new Update_Protez()).ShowDialog();
            }
        }

        private void datagridview_talimat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex == senderGrid.Columns["update2"].Index && e.RowIndex >= 0)
            {
                (new Update_Talimat()).ShowDialog();
            }
        }

        private void datagridview_proses_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
