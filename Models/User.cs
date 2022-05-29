using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_webapi_postgres_example.Models
{
    public class User
    {
        public int Id {get; set;}

        public string Name {get; set;} = String.Empty;

        public DateTime Birthday {get; set;}
    }
}