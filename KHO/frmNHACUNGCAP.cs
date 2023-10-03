using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHO
{
    public partial class frmNHACUNGCAP : DevExpress.XtraEditors.XtraForm
    {
        NHACC _ncc;
        public frmNHACUNGCAP()
        {
            InitializeComponent();
        }
        private void frmNHACUNGCAP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kHODataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.kHODataSet.NHACUNGCAP);
            _ncc = new NHACC();
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            LoadData();
        }
        public void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _ncc.GetAll();
        }

    }
}