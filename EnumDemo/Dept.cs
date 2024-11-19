using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public struct Dept
    {
        private int id;
        private string name;

        public Dept(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Print()
        {
            return $"Id:{id} Name:{name}";
        }
    }
}
