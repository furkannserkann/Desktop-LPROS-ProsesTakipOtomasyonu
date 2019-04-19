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

namespace LPROS.Forms.Table.Info
{
    public partial class Info_Talimat : Form
    {
        public Info_Talimat()
        {
            InitializeComponent();
        }

        private SqlConnector Sc = new SqlConnector();


        public String _SelectedId = "";
        public String _SelectedKod = "";
        public String _SelectedIsim = "";
        public String _SelectedAciklama = "";

        private String loadTable = "select p.Id, tp.sira as [Sıra], p.kod as [Kod], p.isim as [İsim] from Talimat_Prosesleri as tp " +
    "inner join Proses as p on p.Id=tp.proses_id " +
    "inner join Talimat as t on t.Id = tp.talimat_id " +
    "where tp.talimat_id=@parametre1 order by tp.sira asc";

        private void Info_Talimat_Load(object sender, EventArgs e)
        {
            new FormTasima(panel_head, label_head, this, pictureBox_close);

            textbox_isim.Text = _SelectedIsim;
            textbox_kod.Text = _SelectedKod;
            textbox_aciklama.Text = _SelectedAciklama;

            datagridview_proses.DataSource = Sc.GET_DATATABLE(loadTable, new String[] { _SelectedId });

            datagridview_proses.Columns[2].Visible = false;
            for (int i = 0; i < datagridview_proses.Rows.Count; i++)
            {
                datagridview_proses.Rows[i].Cells[0].Value = true;
                datagridview_proses.Rows[i].Cells[1].Value = datagridview_proses.Rows[i].Cells[3].Value.ToString();
            }
            datagridview_proses.Columns[3].Visible = false;
            datagridview_proses.Columns["Kod"].ReadOnly = true;
            datagridview_proses.Columns["İsim"].ReadOnly = true;

            for (int i = 0; i < datagridview_proses.Columns.Count; i++)
                datagridview_proses.Columns[i].SortMode = DataGridViewColumnSortMode.Programmatic;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
