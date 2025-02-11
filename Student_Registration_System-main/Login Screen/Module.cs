using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Registration_System
{
   public class Module
    {
        private string code;
        private string name;
        private int credit;

        public Module() { }
        public Module(string code, string name, int credit) { 
            this.code = code;
            this.name = name;
            this.credit = credit;
        }


        public string getCode()
        {
            return this.code;
        }

        public string getName()
        {
            return this.name;
        }

        public int getCredit()
        {
            return this.credit;
        }
    }
}
