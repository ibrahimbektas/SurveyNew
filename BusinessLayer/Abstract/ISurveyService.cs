﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISurveyService:IGenericService<Survey>
	{
        public List<Survey> TGetSurveyList(int id);

    }
}
