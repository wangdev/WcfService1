using CalculatorClient.CalculatorServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClient {
    class Program {
        static void Main(string[] args) {
            using (CalculatorServiceClient proxy = new CalculatorServiceClient()) {
                double x = proxy.Add(1, 2);
                Console.WriteLine(x);
            }
        }
    }
}
