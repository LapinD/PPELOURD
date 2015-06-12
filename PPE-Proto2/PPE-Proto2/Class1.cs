using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1 
    {
        public string DBName = "bddbibliotheque";
        public string DBPass = "";
        public string DBSource = "LocalHost";
        public string CMDPerso = "";

        public Class1(string name,string dbpasse,string dbsource,string cmdperso)
        {
            this.DBName = name;
            this.DBPass = dbpasse;
            this.DBSource = dbsource;
            this.CMDPerso = cmdperso;
        }

        public Class1()
        {
            this.DBName = "bddbibliotheque";
            this.DBPass = "";
            this.DBSource = "LocalHost" ;
        }

        public string getDBName()
        {
            string GDBName=this.DBName;
            return GDBName;
        }

        public string getDBPass()
        {
            string GDBPass = this.DBPass;
            return GDBPass;
        }

        public string getDBSource()
        {
            string GDBSource = this.DBSource;
            return GDBSource;
        }

        public string getCMDPerso()
        {
            string GCMD = this.CMDPerso;
            return GCMD;
        }
    }
}
