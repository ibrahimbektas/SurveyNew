using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SurveyManager : ISurveyService
	{
		private readonly ISurveyDal _surveyDal;

		public SurveyManager(ISurveyDal surveyDal)
		{
			_surveyDal = surveyDal;
		}

		public void TDelete(Survey t)
		{
			_surveyDal.Delete(t);
		}

		public Survey TGetById(int id)
		{
			return _surveyDal.GetByID(id);
		}

		public List<Survey> TGetList()
		{
			return _surveyDal.GetList();
		}

		public void TInsert(Survey t)
		{
			_surveyDal.Insert(t);
		}

		public void TUpdate(Survey t)
		{
			_surveyDal.Update(t);
		}
	}
}
