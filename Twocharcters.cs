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

    // Complete the alternate function below.
    static int alternate(string s) {
             string stringvalue = s;            
            char[] array = stringvalue.ToCharArray().GroupBy(item => item).Select(itemdata => itemdata.Key).ToArray();
            var finalstringcount = 0;
            for(int i=0;i<array.Length;i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    var finalstringchararray = stringvalue.ToCharArray().Where(item => item == array[i] || item == array[j]).Select(itemdata => itemdata).ToArray();
                    for(int x=0;x<finalstringchararray.Length-1;x++)
                    {
                        if(finalstringchararray[x] == finalstringchararray[x+1])
                        {
                            break;
                        }
                        if(x == finalstringchararray.Length-2)
                        {
                           finalstringcount= finalstringcount > finalstringchararray.Count() ? finalstringcount : finalstringchararray.Count();
                        }
                    }                                                                                   
                }               
            }
            return finalstringcount;
    }
     
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int l = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int result = alternate(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
