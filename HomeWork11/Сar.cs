using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork11
{
    public class Car
    {
        private string name { get; set; }
        private int years { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Years
        {
            get { return years; }
            set { years = value; }
        }

        public Car(string name, int years)
        {
          this.Name = name;
           this.Years = years;
        }
    }
}
