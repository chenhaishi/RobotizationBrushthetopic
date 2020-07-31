using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSourse
{
    /// <summary>
    /// 总数居接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repostitory<T> :IRepostitory<T> where T: class
    {
        private DbContext _dbContext = ContextFactory.Create();

        public int Add(T t)
        {
            _dbContext.Set<T>().Add(t);
            return SaveChanges();
        }

        public int Update(T t)
        {
            _dbContext.Set<T>().AddOrUpdate(t);
            return SaveChanges();
        }

        public int Remove(T t)
        {
            _dbContext.Set<T>().Remove(t);
            return SaveChanges();
        }

        public int RemoveRange(List<T> list)
        {
            _dbContext.Set<T>().RemoveRange(list);
            return SaveChanges();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public List<T> List()
        {
            return _dbContext.Set<T>().ToList();
        }

       
    }
}
