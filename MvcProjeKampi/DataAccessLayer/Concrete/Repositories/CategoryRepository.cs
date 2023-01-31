using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();          //context sınıfından c isimli nesne türetildi.
        DbSet<Category> _object;           //DbSet türünde Category sınıfından nesne türerildi

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);     //parametreden gelen degeri _object içerisinde bulunan sınıfa ekle (Category) sınıfı
            c.SaveChanges();    //Değişiklileri Kaydet
        }

        public List<Category> List()
        {
            return _object.ToList();        //ToList verileri listelemek için kullanılan metottur.
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
