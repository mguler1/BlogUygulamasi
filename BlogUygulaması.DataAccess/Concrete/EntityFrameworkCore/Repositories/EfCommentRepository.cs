using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
   public class EfCommentRepository:EfGenericRepository<Comment>,ICommentDal
    {
    }
}
