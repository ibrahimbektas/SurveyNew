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
	public class UploadedFileManager : IUploadedFileService
	{
		private readonly IUploadedFileDal _uploadedFileDal;

		public UploadedFileManager(IUploadedFileDal uploadedFileDal)
		{
			_uploadedFileDal = uploadedFileDal;
		}

		public void TDelete(FileAnswer t)
		{
			_uploadedFileDal.Delete(t);
		}

		public FileAnswer TGetById(int id)
		{
			return _uploadedFileDal.GetByID(id);
		}

		public List<FileAnswer> TGetList()
		{
			return _uploadedFileDal.GetList();
		}

		public void TInsert(FileAnswer t)
		{
			_uploadedFileDal.Insert(t);
		}

		public void TUpdate(FileAnswer t)
		{
			_uploadedFileDal.Update(t);
		}
	}
}
