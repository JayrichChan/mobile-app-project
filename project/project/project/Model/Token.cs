using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Model
{
    public class Token
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expiry_date { get; set; }
        public int expire_in { get; set; }

        public Token() { }

    }
}
