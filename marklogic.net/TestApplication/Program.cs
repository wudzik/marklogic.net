﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marklogic.net;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new MarkLogicConnection("localhost", "admin", "water1", 8091);

            using (var sesion = connection.OpenSession())
            {
                
            }
        }
    }
}
