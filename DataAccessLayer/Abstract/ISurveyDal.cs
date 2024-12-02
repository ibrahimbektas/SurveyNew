using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface ISurveyDal:IGenericDal<Survey>
	{
		List<Survey> GetSurveyList(int id);
	}
}
