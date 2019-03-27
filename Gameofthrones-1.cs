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

    // Complete the gameOfThrones function below.
    static string gameOfThrones(string s) {
   var keyvaluepair = s.ToCharArray().GroupBy(element => element).ToDictionary(key => key.Key, value => value.Count());            
            if(s.Length%2==0)
            {
                return keyvaluepair.Select(item => item.Value).Where(itemVal => itemVal % 2 == 0).Count() == keyvaluepair.Count() ? "YES" : "NO";
            }
            else
            {
               return keyvaluepair.Select(item => item.Value).Where(itemVal => itemVal % 2 == 0).Count() == keyvaluepair.Count() - 1 ?
               "YES" : "NO";
            }

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
