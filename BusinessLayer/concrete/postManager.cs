using businessLayer.Abstract;
using DataAccessLayer.abstracts;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.concrete
{
    public class postManager : IPostService
    {
        IPostDal _postDal;

        public postManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public void AddPost(post p)
        {
            _postDal.insert(p);
        }

        public post getId(int Id)
        {
            return _postDal.get(x => x.postId == Id);
        }

        public List<post> List(Expression<Func<post, bool>> filter)
        {
            return _postDal.List(filter);
        }

        //public List<post> List(int Id)
        //{
        //    return _postDal.List(x => x.postId == Id);
        //}

        public List<post> listing()
        {
            return _postDal.list();
        }

        public void postDelete(post post)
        {
            _postDal.delete(post);
        }

        public void updatePost(post post)
        {
            _postDal.update(post);
        }
    }
}
