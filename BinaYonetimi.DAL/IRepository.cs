using BinaYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.DAL
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T Select(int ID);
        List<T> SelectAll();
        void Insert(T Entity);
        int Update(int ID); // Veritabanında güncellemeden etkilenen satır varsa bize satır sayısını döndürecek
        int Delete(int ID);
    }
}
