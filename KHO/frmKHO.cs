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
    public partial class frmKHO : DevExpress.XtraEditors.XtraForm
    {
        DVIKHO _kho;

        private void frmKHO_Load(object sender, EventArgs e)
        {
            _kho = new DVIKHO();
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            LoadData();
        }

        public void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _kho.GetAll();
        }
        public frmKHO()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();    
            frmMain.Show();
        }
    }
}