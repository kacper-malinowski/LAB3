using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Threads {
    internal class Matrix {
        private int[,] matrix1 { get; set; }
        private int[,] matrix2 { get; set; }
        private int[,] resultMatrix { get; set; }
        private int rows { get; set; }
        private int cols { get; set; }
        public Matrix() {
            
        }

        internal void InitializeMatrices() {
            rows = 500;
            cols = rows;
            matrix1 = new int[rows, cols];
            matrix2 = new int[rows, cols];
            resultMatrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrix1[i, j] = rand.Next(10);
                    matrix2[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    resultMatrix[i, j] = 0;
                }
            }
        }

        internal void CalculateSum(int offset, int nThreads) {

            for (int i = offset; i < cols * rows; i += nThreads) {
                for (int k = 0; k < cols; k++) {
                    resultMatrix[i / rows, i % cols] += matrix1[i / rows, k] * matrix2[k, i % cols];
                }
            }

        }

        public long ThreadMultiplyMatrices() {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nThreads = 5;
            Thread[] threads = new Thread[nThreads];
            for (int t = 0; t < nThreads; t++) {
                int threadIndex = t;
                threads[threadIndex] = new Thread(() => CalculateSum(threadIndex, nThreads));
                threads[threadIndex].Start();
            }
            foreach (Thread thread in threads) {
                thread.Join();
            }
            stopwatch.Stop();
            long timeElapsed = stopwatch.ElapsedMilliseconds;
            return timeElapsed;

        }

        public long ParallelMultiplyMatrices() {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nThreads = 1;
            ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = nThreads };
            Thread[] threads = new Thread[Environment.ProcessorCount];
            Parallel.For(0, cols * rows, opt, i => {
                for (int k = 0; k < cols; k++) {
                    resultMatrix[i / rows, i % cols] += matrix1[i / rows, k] * matrix2[k, i % cols];
                }
            });
            stopwatch.Stop();
            long timeElapsed = stopwatch.ElapsedMilliseconds;
            return timeElapsed;

        }

        public void displayMatrices() {
            string matrixString = "Matrix A:\n";
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrixString += matrix1[i, j] + " ";
                }
                matrixString += "\n";
            }
            matrixString += "\n";
            matrixString += "Matrix B:\n";
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrixString += matrix2[i, j] + " ";
                }
                matrixString += "\n";
            }
            matrixString += "\n";
            matrixString += "Result matrix:\n";
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    matrixString += resultMatrix[i, j] + " ";
                }
                matrixString += "\n";
            }
            Console.WriteLine(matrixString);
        }
    }
}
