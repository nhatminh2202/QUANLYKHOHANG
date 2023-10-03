using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NHACC
    {
        Entities db;

        public NHACC()
        {
            db = Entities.CreateEntities(); 
        }

        public List<NHACUNGCAP> GetAll()
        {
            return db.NHACUNGCAPs.ToList();
        }
        
        public NHACUNGCAP getItem(string ma_ncc)
        {
            return db.NHACUNGCAPs.FirstOrDefault(x => x.MANCC == ma_ncc);
        }
    }
}