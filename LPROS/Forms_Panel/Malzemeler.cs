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
    public partial class Malzemeler : Form
    {
        public Malzemeler()
        {
            InitializeComponent();
        }

        SqlConnector Sc = new SqlConnector();

        private void Malzemeler_Load(object sender, EventArgs e)
        {
            Items.panelMalzemeler = new PanelGridView
            {
                form = this,
                dataGridview = datagridview_malzemeler
            };

            datagridview_malzemeler.DataSource = Sc.GET_DATATABLE(SqlConnector.TableMalzemeler);
            datagridview_malzemeler.Columns[0].Visible = false;
        }
    }
}
