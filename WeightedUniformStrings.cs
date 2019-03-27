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

    // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password) {
            int counter = 0;
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            if (numbers.Where( no => password.Contains(no)).Count() == 0)                  
                counter += 1;
            if (lower_case.Where(lower => password.Contains(lower)).Count() == 0)
                counter += 1;
            if (upper_case.Where(upper => password.Contains(upper)).Count() == 0)
                counter += 1;
            if (special_characters.Where(special => password.Contains(special)).Count() == 0)
                counter += 1;
            if ((counter + n) < 6)
                counter += (6 - (counter + n));
            return counter;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
