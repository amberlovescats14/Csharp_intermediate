﻿using System;
namespace Mosh_Part2.dbConnection
{
    public interface IDB
    {
        string ConnectionString { get; set; }

        //methods
        void OpenConnection();
        void CloseConnection();
    }
}
