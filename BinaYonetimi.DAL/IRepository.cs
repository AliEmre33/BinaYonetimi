using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaYonetimi.Entities;

namespace BinaYonetimi.DAL
{
    public interface IRepository<T> where T : class , IEntity , new()
    {
        T Select();
        List<T> SelectAll();
        void Insert(T Entity);
        int Update(int id);
        void Delete(int id);
    }
}
