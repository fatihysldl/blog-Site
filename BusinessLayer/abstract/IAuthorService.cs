using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.Abstract
{
    public interface IAuthorService
    {
        List<author> listing();
        void addAuthor(author p);
        author getId(int Id);
        void updateAuthor(author p);
        void deleteAuthor(author p);
    }
}
