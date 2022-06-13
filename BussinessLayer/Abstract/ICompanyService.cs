using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICompanyService
    {
        void CompanyAdd(Company company);
        void CommentRemove(Company company);
        void CommentUpdate(Company company);
        List<Company> GetList();
        Company GetById(int id);
    }
}
