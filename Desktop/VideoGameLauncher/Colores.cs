using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameLauncher
{
    class Colores
    {
        private string r;

        public string R
        {
            get { return r; }
            set { r = value; }
        }
        private string g;

        public string G
        {
            get { return g; }
            set { g = value; }
        }
        private string b;

        public string B
        {
            get { return b; }
            set { b = value; }
        }


        public Colores(string r, string g, string b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
