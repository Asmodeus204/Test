using DTO_QLBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public class DAL_KhachHang : DAL_IKhachHang
    {
        public int Delete(Khach khach)
        {
           // throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Khaches.Attach(khach);
                db.Khaches.Remove(khach);
                return db.SaveChanges();
            }
        }
        public Khach Get(string dienThoai)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Khaches.Find(dienThoai);
            }
        }

        public List<Khach> GetAll()
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Khaches.ToList();
            }
        }

        public int Insert(Khach khach)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Khaches.Add(khach);
                return db.SaveChanges();
            }
        }

        public List<Khach> Search(string key)
        {
            throw new NotImplementedException();
            if (string.IsNullOrEmpty(key))
                return GetAll();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                return db.Khaches.Where(k => k.TenKhach.Contains(key)).ToList();
            }
        }

        public int Update(Khach khach)
        {
            //throw new NotImplementedException();
            using (QLBanHangEntities db = new QLBanHangEntities())
            {
                db.Khaches.Attach(khach);
                db.Entry(khach).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
        }
    }
}
