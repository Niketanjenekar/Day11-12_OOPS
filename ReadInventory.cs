using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class ReadInventory
    {
        public InventoryDetails Read(string path)
        {
            try
            {
                using (StreamReader file = new StreamReader(path))
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);
                }

            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
