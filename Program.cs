namespace InventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Users\\niket\\source\\repos\\InventoryManagement\\InventoryManagement\\inventory.json";

            ReadInventory obj = new ReadInventory();

            InventoryDetails data = obj.Read(path);

            for(int i=0; i<data.typesofRice.Count; i++)
            {
                Console.WriteLine("Tupes of Rices");
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].Weight);
                Console.WriteLine(data.typesofRice[i].Price);

                int val = data.typesofRice[i].Weight * data.typesofRice[i].Price;
                Console.WriteLine("The Price of {0} and {1} kg is {3} Rs " , data.typesofRice[i].name, data.typesofRice[i].Weight, data.typesofRice[i].Price, val);

                Console.WriteLine("*************************************************************");
            }

            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine("Tupes of Wheat");
                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].Weight);
                Console.WriteLine(data.typesofWheat[i].Price);

                int val = data.typesofWheat[i].Weight * data.typesofWheat[i].Price;
                Console.WriteLine("The Price of {0} and {1} kg is {3} Rs ", data.typesofWheat[i].name, data.typesofWheat[i].Weight, data.typesofWheat[i].Price, val);

                Console.WriteLine("*************************************************************");
            }

            for (int i = 0; i < data.typesofPulses.Count; i++)
            {
                Console.WriteLine("Types of Pulses");
                Console.WriteLine(data.typesofPulses[i].name);
                Console.WriteLine(data.typesofPulses[i].Weight);
                Console.WriteLine(data.typesofPulses[i].Price);

                int val = data.typesofPulses[i].Weight * data.typesofPulses[i].Price;
                Console.WriteLine("The Price of {0} and {1} kg is {3} Rs ", data.typesofPulses[i].name, data.typesofPulses[i].Weight, data.typesofPulses[i].Price, val);

                Console.WriteLine("*************************************************************");
            }
        }

    }
}