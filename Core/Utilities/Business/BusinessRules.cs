﻿using System.Linq;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logic)
        {
            return logic.FirstOrDefault(l => !l.Success);
        }
    }
}
