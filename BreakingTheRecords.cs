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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int startpoint=s;
        int endpoint=t;
        int appletree=a;
        int orangetree=b;
        int noOfApples=apples.Length;
        int noOfOranges=oranges.Length;

        var doubleapples = apples.Select(item => (double)item).ToArray();
        var doublesoranges = oranges.Select(item => (double)item).ToArray();

       Console.WriteLine(doubleapples.Select(item => item + appletree).Where( itemdata => (itemdata >= startpoint && itemdata<=endpoint)).Count());
       Console.WriteLine(doublesoranges.Select(item => item + orangetree).Where(itemdata => (itemdata >= startpoint && itemdata<=endpoint)).Count());



    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
