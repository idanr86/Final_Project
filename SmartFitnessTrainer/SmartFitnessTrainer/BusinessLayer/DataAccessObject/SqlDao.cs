using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFitnessTrainer.BusinessLayer.DataAccessObject
{
    class SqlDao
    {
        String dbUser;

        public String DbUser
        {
            get { return dbUser; }
            set { dbUser = value; }
        }
        String dbPass;

        public String DbPass
        {
            get { return dbPass; }
            set { dbPass = value; }
        }
        String dbUrl;

        public String DbUrl
        {
            get { return dbUrl; }
            set { dbUrl = value; }
        }
        int dbPort;

        public int DbPort
        {
            get { return dbPort; }
            set { dbPort = value; }
        }
    }
}
