using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSurveyDal : GenericRepository<Survey>, ISurveyDal
    {
        public List<Survey> GetSurveyList(int id)
        {
            using var context=new Context();
            var values=context.Surveys.Where(x=>x.CreatorID==id).ToList();
            return values;
        }
    }
}
