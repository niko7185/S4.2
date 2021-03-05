using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Airport
    {

        private string name;

        public string Name => name;

        public Airport(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
