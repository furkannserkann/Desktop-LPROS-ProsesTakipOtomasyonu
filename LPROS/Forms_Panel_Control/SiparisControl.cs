using LPROS.Custom;
using LPROS.Forms;
using LPROS.Forms.Table.Add;
using LPROS.Forms.Table.Search;
using LPROS.Forms.Table.Update;
using System;
using System.Windows.Forms;

namespace LPROS.ControlPanelForms
{
    public partial class SiparisControl : Form
    {
        public SiparisControl()
        {
            InitializeComponent();
        }

        private void SiparisControl_Load(object sender, EventArgs e)
        {
            datetimepicker_teslimtarihi.Value = DateTime.Now.AddDays(1);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            Add_Siparis addSip = new Add_Siparis()
            {
                isUpdate = false
            };
            addSip.ShowDialog();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {


        }

        private void button_arama_Click(object sender, EventArgs e)
        {
            (new Search_Siparis()).ShowDialog();
        }

        private void button_düzenle_Click(object sender, EventArgs e)
        {
            DataGridView Dtg = Items.panelSiparis.dataGridview;
            Add_Siparis addSip = new Add_Siparis()
            {
                isUpdate = false,
                fisno = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["fis_no"].Value.ToString(),
                hasta_adsoyad = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Hasta İsmi"].Value.ToString(),
                protez_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Protez Tipi"].Value.ToString(),
                hastane_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Hastane"].Value.ToString(),
                doktor_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Doktor"].Value.ToString(),
                siparis_tarihi = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Sipariş Tarihi"].Value.ToString(),
                teslimat_tarihi = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Teslim Tarihi"].Value.ToString(),
                renk_id = Dtg.Rows[Dtg.CurrentCell.RowIndex].Cells["Renk"].Value.ToString()
            };
            addSip.ShowDialog();
        }
    }
}
