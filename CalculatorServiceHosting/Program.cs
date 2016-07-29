using MyServices;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceHosting {
    class Program {
        static void Main(string[] args) {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService))) {
                host.Opened += delegate {
                    Console.WriteLine("Calculator has been started.");
                    Console.WriteLine("Press any key to stop it.");
                };
                host.Open();
                Console.ReadKey();
            }
        }
    }
}
