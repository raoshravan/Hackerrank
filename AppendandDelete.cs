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

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k) {
                     int index = s.Zip(t, (source, tocomparewith) => source == tocomparewith).TakeWhile(b => b).Count();
            if (s.Length + t.Length - 2 * index > k) // comparison of diff between 2 string > k 
                return "No";
            else if (((s.Length + t.Length) - 2 * index) % 2 == k % 2) // this condition dint get
                return "Yes";
            else if ((s.Length + t.Length) - k < 0)// condition means 1 string all value deletion + other string all value addition < k then yes
                return "Yes";
            else
                return "No";

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
