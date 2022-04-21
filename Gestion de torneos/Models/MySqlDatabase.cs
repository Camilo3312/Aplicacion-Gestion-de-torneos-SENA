using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace work4hours_modules_backend.Models
{
    public class MySqlDatabase
    {
        public MySqlConnection connection;

        public MySqlDatabase()
        {
            connection = new MySqlConnection("datasource=by0bnxgyq7rt95lympsw-mysql.services.clever-cloud.com; port=3306; username=uh7xuem2hmsgrrzi; password=gKmkErl1gpvlz7teISDL;database=by0bnxgyq7rt95lympsw");
        }
    }
}
