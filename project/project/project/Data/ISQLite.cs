using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
