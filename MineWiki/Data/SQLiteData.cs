﻿using MineWiki.Model;
using SQLite;

namespace MineWiki.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDB;

        public UsuarioData UsuarioDataTable { get; set; }

        public SQLiteData(string path)
        {
            _conexaoDB = new SQLiteAsyncConnection(path);
            _conexaoDB.CreateTableAsync<Usuario>().Wait();

            UsuarioDataTable = new UsuarioData (_conexaoDB);
        }

    }
}
