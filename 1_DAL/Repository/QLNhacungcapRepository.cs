using _1_DAL.Entities;
using _1_DAL.IRepository;
using _1_DAL.QuanLyDBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class QLNhacungcapRepository : IQLNhacungCapRepository
    {
        QuanLyDatabaseContext _dbContext = new QuanLyDatabaseContext();
        public bool Add(Supplier Supplier)
        {
            _dbContext.Add(Supplier);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Supplier Supplier)
        {
            _dbContext.Remove(Supplier);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Supplier> GetAll()
        {
            return _dbContext.Suppliers.ToList();
        }

        public SupplierDetail GetById(int id)
        {
           throw new NotImplementedException();
        }

        public bool Update(Supplier supplier)
        {
            try
            {
                _dbContext.Update(supplier);
                _dbContext.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                // Xử lý ngoại lệ DbUpdateException
                // Lấy nội dung của ngoại lệ nội bộ (inner exception)
                var innerException = ex.InnerException;
                if (innerException != null)
                {
                    // Xem thông tin chi tiết của ngoại lệ nội bộ
                    Console.WriteLine("Lỗi: " + innerException.Message);
                }
                return false; // Trả về false để đánh dấu thất bại
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác
                Console.WriteLine("Lỗi: " + ex.Message);
                return false; // Trả về false để đánh dấu thất bại
            }
        }


    }
}
