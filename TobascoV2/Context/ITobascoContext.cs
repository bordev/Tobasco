﻿namespace TobascoV2.Context
{
    public interface ITobascoContext
    {
        XmlEntity EntityContext { get; }

        DatabaseContext DatabaseContext { get; }        

        bool AddBusinessRules { get; }

        string BaseClass { get; }
    }
}
