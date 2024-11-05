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
	public class AnswerManager : IAnswerService
	{
		public readonly IAnswerDal _answerDal;

		public AnswerManager(IAnswerDal answerDal)
		{
			_answerDal = answerDal;
		}

		public void TDelete(Answer t)
		{
			_answerDal.Delete(t);
		}

		public Answer TGetById(int id)
		{
			return _answerDal.GetByID(id);
		}

		public List<Answer> TGetList()
		{
			return _answerDal.GetList();	
		}

		public void TInsert(Answer t)
		{
			_answerDal.Insert(t);
		}

		public void TUpdate(Answer t)
		{
			_answerDal.Update(t);
		}
	}
}
