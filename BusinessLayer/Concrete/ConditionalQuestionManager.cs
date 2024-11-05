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
	public class ConditionalQuestionManager : IConditionalQuestionService
	{
		public readonly IConditionalQuestionDal _conditionalQuestionDal;

		public ConditionalQuestionManager(IConditionalQuestionDal conditionalQuestionDal)
		{
			_conditionalQuestionDal = conditionalQuestionDal;
		}

		public void TDelete(ConditionalQuestion t)
		{
			_conditionalQuestionDal.Delete(t);
		}

		public ConditionalQuestion TGetById(int id)
		{
			return _conditionalQuestionDal.GetByID(id);
		}

		public List<ConditionalQuestion> TGetList()
		{
			return _conditionalQuestionDal.GetList();
		}

		public void TInsert(ConditionalQuestion t)
		{
			_conditionalQuestionDal.Insert(t);
		}

		public void TUpdate(ConditionalQuestion t)
		{
			_conditionalQuestionDal.Update(t);
		}
	}
}

