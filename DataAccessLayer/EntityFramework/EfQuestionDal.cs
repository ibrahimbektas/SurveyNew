using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfQuestionDal : GenericRepository<Question>, IQuestionDal
    {
        public List<Question> GetPublicQuestionList()
        {
            using var context = new Context();
            var values=context.Questions.Include(y=>y.Survey).ThenInclude(z=>z.Creator).Where(x=>x.IsPublic==true).ToList();
            return values;
        }
    }
}
