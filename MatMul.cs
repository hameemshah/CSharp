using System;
using System.IO;

namespace Hameem {
    class MatMul {
        static void Main(string[] args) {
            // Specify the file path
            string filePath = "input.txt";

            // Check if the file exists
            if (!File.Exists(filePath)) {
                Console.WriteLine("Input file not found.");
                return;
            }

            Console.WriteLine("Reading values from the file...");

            // Initialize the 2D array
            int[,] Matrix = new int[5, 5];
            
            // Read the file line by line and populate the matrix
            using (StreamReader reader = new StreamReader(filePath)) {
                for (int i = 0; i < 5; i++) {
                    for (int j = 0; j < 5; j++) {
                        string line = reader.ReadLine();
                        if (!int.TryParse(line, out Matrix[i, j])) {
                            Console.WriteLine("Invalid input in the file. Please ensure all lines contain integers.");
                            return;
                        }
                    }
                }
            }

            // Print the matrix
            Console.WriteLine("Matrix values read from the file:");
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 5; j++) {
                    Console.Write("{0, 3}",Matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
