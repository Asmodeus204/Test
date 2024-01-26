using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    internal class DAL_Hang : DAL_IHang
    {
        public int Delete(Hang hang)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Hangs.Attach(hang);
                db.Hangs.Remove(hang);
                return db.SaveChanges();
            }
        }

        public Hang Get(int maHang)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Hangs.Find(maHang);
            }
        }

        public List<Hang> GetAll()
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Hangs.ToList();
            }
        }

        public Hang Insert(Hang hang)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Hangs.Add(hang);
                db.SaveChanges();
                return hang;
            }
        }

        public List<Hang> Search(string key)
        {
            //   throw new NotImplementedException();
            if (string.IsNullOrEmpty(key))
                return GetAll();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Hangs.Where(h => h.TenHang.Contains(key)).ToList();
            }
        }

        public int Update(Hang hang)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Hangs.Attach(hang);
                db.Entry(hang).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
