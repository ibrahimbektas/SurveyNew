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
	public class ResponseManager : IResponseService
	{
		private readonly IResponseDal _responseDal;

		public ResponseManager(IResponseDal responseDal)
		{
			_responseDal = responseDal;
		}

		public void TDelete(Response t)
		{
			_responseDal.Delete(t);
		}

		public Response TGetById(int id)
		{
			return _responseDal.GetByID(id);
		}

		public List<Response> TGetList()
		{
			return _responseDal.GetList();
		}

		public void TInsert(Response t)
		{
			_responseDal.Insert(t);
		}

		public void TUpdate(Response t)
		{
			_responseDal.Update(t);
		}
	}
}
