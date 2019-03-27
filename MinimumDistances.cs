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

    // Complete the minimumDistances function below.
    static int minimumDistances(int[] a) {
              var ValueIndexObjectArray = a.Select((item, index) => new { Value = item, Index = index });
            var GrpByval = ValueIndexObjectArray.GroupBy(element => element.Value).Where(grpdata => grpdata.Count() % 2 == 0);
            if(GrpByval.Any())
            {
                var ValueIndexArray = GrpByval.Select(data => new
                {
                    dataval = data.Select(t => t.Value).FirstOrDefault(),
                    dataIndex = data.Select(t => t.Index).ToArray()
                });
                return ValueIndexArray.Select(diff => Math.Abs(diff.dataIndex[0] - diff.dataIndex[1])).Min();
            }
            else
            {
                return -1;
            } 
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
