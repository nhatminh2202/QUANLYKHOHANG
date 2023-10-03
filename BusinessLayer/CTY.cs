using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CTY
    {
        Entities db;

       public CTY()
        {
            db = Entities.CreateEntities();
        }

        public CONGTY getItem(string tencty)
        {
            return db.CONGTies.FirstOrDefault(x => x.TENCTY == tencty);
        }

        public List<CONGTY> GetAll()
        {
            return db.CONGTies.ToList();
        }

        public void add(CONGTY congty)
        {
            try
            {
                db.CONGTies.Add(congty);
                db.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra " + ex.Message);
            }
        }

        public void delete(CONGTY congty)
        {
            try
            {
                db.CONGTies.Remove(congty);
                db.SaveChanges();
            }
            catch (Exception ex) { throw new Exception("Có lỗi xảy ra" + ex.Message); }
        }

        public void update(CONGTY congty)
        {
            CONGTY cty = db.CONGTies.FirstOrDefault(x => x.TENCTY == congty.TENCTY);
            cty.TENCTY = congty.TENCTY;
            cty.MASO_THUE =  congty.MASO_THUE;
            cty.DIA_CHI = congty.DIA_CHI;
            cty.NGUOI_DD = congty.NGUOI_DD;
            cty.DIEN_THOAI = congty.DIEN_THOAI;
            cty.NGAY_HD = congty.NGAY_HD;
            cty.LOAI_HINH = congty.LOAI_HINH;
            cty.TINH_TRANG = congty.TINH_TRANG;
            try
            {
                db.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
