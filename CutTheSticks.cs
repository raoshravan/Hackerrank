using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the cutTheSticks function below.
    static int[] cutTheSticks(int[] arr) {
            int[] arrcopy = arr;           
            int counter = 0;
            List<int> returndta = new List<int>();
            while (arrcopy.Where(item => item!=0).Any())
            {
                int minValue = arrcopy.Where(item => item != 0).Min();
                for (int i = 0; i < arrcopy.Length; i++)
                {
                    if (arrcopy[i] - minValue >= 0)
                    {
                        arrcopy[i] = arrcopy[i] - minValue;
                        counter ++;
                    }
                }
                returndta.Add(counter);
                counter = 0;
            }
            return returndta.ToArray();

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] result = cutTheSticks(arr);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
