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

    // Complete the funnyString function below.
    static string funnyString(string s) {
              int [] chararrayValue= s.ToCharArray().Select(item => (int)item).ToArray();
           int [] diffarray = chararrayValue.Where((element, index) => index < chararrayValue.Length - 1)
                .Select((x, idx) => Math.Abs(chararrayValue[idx + 1] - x)).ToArray();
                      
           int [] revchararrayValue = s.Reverse().ToArray().Select(item => (int)item).ToArray();
           int [] revdiffarray = revchararrayValue.Where((element, index) => index < revchararrayValue.Length - 1)
                .Select((x, idx) => Math.Abs(revchararrayValue[idx + 1] - x)).ToArray();

          return (diffarray.Where((item, index) => diffarray[index] == revdiffarray[index]).Count() == diffarray.Count())
           ?  "Funny": "Not Funny";

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
