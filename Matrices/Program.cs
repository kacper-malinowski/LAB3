using System.IO;

namespace Threads {
    internal class Program {
        static void Main(string[] args) {
            
            Matrix matrix = new Matrix();
            int nTests = 1;
            long[] tests = new long[nTests];
            for (int i = 0; i < nTests; i++) {
                matrix.InitializeMatrices();
                long time = matrix.ParallelMultiplyMatrices();
                tests[i] = time;
            }
            long mean = 0;
            foreach(int time in tests) {
                mean += time;
                mean = mean / nTests;
            }
            Console.WriteLine("Średnia czasu: " + mean + " ms");
            //matrix.displayMatrices();
        }
    }
}
