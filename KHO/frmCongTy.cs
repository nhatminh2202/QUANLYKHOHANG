using BusinessLayer;
using DataLayer;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraPrinting;

namespace KHO
{

    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        CTY _cty;
        bool _them;


        public frmCongTy()
        {
            InitializeComponent();
        }

        private void DataDisAppear()
        {
            txtTen.Enabled = false;
            txtMaThue.Enabled = false;
            txtDiaChi.Enabled = false;
            txtNguoiDD.Enabled = false;
            txtSDT.Enabled = false;
            dtpHD.Enabled = false;
            cbLoaiHinh.Enabled = false;
            cbTinhTrang.Enabled = false;
        }

        private void DataAppear()
        {
            txtTen.Enabled = true;
            txtMaThue.Enabled = true;
            txtDiaChi.Enabled = true;
            txtNguoiDD.Enabled = true;
            txtSDT.Enabled = true;
            dtpHD.Enabled = true;
            cbLoaiHinh.Enabled = true;
            cbTinhTrang.Enabled = true;
        }

        private void Reset()
        {
            DataAppear();
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMaThue.Text = "";
            txtNguoiDD.Text = "";
            txtSDT.Text = "";
            dtpHD.Text = "";
            cbLoaiHinh.Text = "";
            cbTinhTrang.Text = "";
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _cty = new CTY();
            gvDanhSach.OptionsView.ShowGroupPanel = false;
            LoadData();
        }

        public void LoadData()
        {
            gvDanhSach.OptionsBehavior.Editable = false;
            gcDanhSach.DataSource = _cty.GetAll();
        }
     

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo");
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataAppear();
            Reset();
            _them = true;
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                txtTen.Text = gvDanhSach.GetFocusedRowCellValue("TENCTY").ToString();
                txtMaThue.Text = gvDanhSach.GetFocusedRowCellValue("MASO_THUE").ToString();
                txtDiaChi.Text = gvDanhSach.GetFocusedRowCellValue("DIA_CHI").ToString();
                txtNguoiDD.Text = gvDanhSach.GetFocusedRowCellValue("NGUOI_DD").ToString();
                txtSDT.Text = gvDanhSach.GetFocusedRowCellValue("DIEN_THOAI").ToString();
                dtpHD.Text = gvDanhSach.GetFocusedRowCellValue("NGAY_HD").ToString(); ;
                cbLoaiHinh.Text = gvDanhSach.GetFocusedRowCellValue("LOAI_HINH").ToString();
                cbTinhTrang.Text = gvDanhSach.GetFocusedRowCellValue("TINH_TRANG").ToString();
                DataDisAppear();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataAppear();
            _them = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string k = txtTen.Text;
            CONGTY object1 = _cty.getItem(k);
            _cty.delete(object1);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string k = txtTen.Text;
            if (_them)
            {
                CONGTY object1 = new CONGTY();
                object1.TENCTY = txtTen.Text;
                object1.MASO_THUE = int.Parse(txtMaThue.Text.ToString());
                object1.DIA_CHI = txtDiaChi.Text;
                object1.NGUOI_DD = txtNguoiDD.Text;
                object1.DIEN_THOAI = txtSDT.Text;
                object1.NGAY_HD = dtpHD.Value;
                object1.LOAI_HINH = cbLoaiHinh.Text;
                object1.TINH_TRANG = cbTinhTrang.Text;
                _cty.add(object1);
                gcDanhSach.DataSource = _cty.GetAll();
            } else
            {
                CONGTY object1 = _cty.getItem(k);
                object1.TENCTY = txtTen.Text;
                object1.MASO_THUE = int.Parse(txtMaThue.Text.ToString());
                object1.DIA_CHI = txtDiaChi.Text;
                object1.NGUOI_DD = txtNguoiDD.Text;
                object1.DIEN_THOAI = txtSDT.Text;
                object1.NGAY_HD = dtpHD.Value;
                object1.LOAI_HINH = cbLoaiHinh.Text;
                object1.TINH_TRANG = cbTinhTrang.Text;
                _cty.update(object1);
            }
            _them = false;
            LoadData();

        }
        Bitmap bitmap;

        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt";

            try
            {
                GridView gridView = gcDanhSach.MainView as GridView;
                if (gridView != null)
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = sfd.FileName; // Lấy tên file từ SaveFileDialog

                        using (FileStream fs = new FileStream(filename, FileMode.Create))
                        {
                            TextExportOptions options = new TextExportOptions();
                            options.Encoding = Encoding.UTF8;

                            gridView.ExportToText(fs, options);
                        }

                        Console.WriteLine($"Xuất file {filename} thành công.");
                    }
                }
                else
                {
                    Console.WriteLine("Không thể xuất dữ liệu từ GridControl.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}