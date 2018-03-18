using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp
{
    class Program : output
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.LoadApplication();
            Console.WriteLine(obj.returnString);
            Console.WriteLine("*** PRESS ANY KEY TO EXIT ***");
            Console.ReadKey();
        }


    }

    class output
    {
        public string returnString;
        public void LoadApplication()
        {
            var appSettings = ConfigurationManager.AppSettings;
            string _mode = appSettings.Get("DisplayMode");

            switch (_mode)
            {
                case "CONSOLE":
                    toConsole cons = new toConsole();
                    returnString = cons.GetData().ToString();
                    break;
                case "DB":
                    toDatabase db = new toDatabase();
                    returnString = db.GetData().ToString();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

    }
     class toConsole : output
    {
       
        public string GetData()
        {
            return API.GetHelloWorld().ToString();

        }


        
    }
    class toDatabase : output
    {
        // TODO: DB Interface code
        public string GetData()
        {
            return API.GetHelloWorld().ToString();

        }
    }

}
