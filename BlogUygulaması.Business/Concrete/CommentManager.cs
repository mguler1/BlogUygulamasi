using BlogUygulaması.Business.Interfaces;
using BlogUygulaması.DataAccess.Interfaces;
using BlogUygulaması.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.Concrete
{
    public class CommentManager:GenericManager<Comment>,ICommentService
    {
        private readonly IGenericDal<Comment> _genericDal;
        public CommentManager(IGenericDal<Comment> genericDal):base(genericDal)
        {
            _genericDal = genericDal;
        }
    }
}
