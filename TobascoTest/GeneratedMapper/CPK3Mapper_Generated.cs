﻿using System;
using System.CodeDom.Compiler;
using TobascoTest.GeneratedMapper;
using TobascoTest.GeneratedEntity;

namespace TobascoTest.GeneratedMapper
{
	[GeneratedCode("Tobasco", "1.0.0.0")]
	public  partial class CPK3Mapper : ICPK3Mapper
	{
		public CPK3 MapToObject(TobascoTest.GeneratedEntity2.CPK3 objectToMapFrom)
    {
        var objectToMapTo = new CPK3
        {
            Training = objectToMapFrom.Training,
            Duur = objectToMapFrom.Duur,
            Kosten = objectToMapFrom.Kosten,
        };

        return objectToMapTo;
    }
	
	}
}