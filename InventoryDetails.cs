using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoryDetails
    {
        public List<TypesofRice> typesofRice;
        public List<TypesofWheat> typesofWheat;
        public List<TypesofPulses> typesofPulses;
    }
    public class TypesofRice
    {
        public string name;
        public int Weight;
        public int Price;
    }
    public class TypesofWheat
    {
        public string name;
        public int Weight;
        public int Price;
    }
    public class TypesofPulses
    {
        public string name;
        public int Weight;
        public int Price;
    }

}
