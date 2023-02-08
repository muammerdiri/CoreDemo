using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Linq;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository:GenericRepository<Blog>, IBlogDal
    {
    }
}
