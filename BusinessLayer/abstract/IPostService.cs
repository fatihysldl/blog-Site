using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Abstract
{
    public interface IPostService
    {
        List<post> listing();
        void AddPost(post p);
        post getId(int Id);
        void postDelete(post post);

        void updatePost(post post);
        List<post> List(Expression<Func<post, bool>> filter);
    }
}
