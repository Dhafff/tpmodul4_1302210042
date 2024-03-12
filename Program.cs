using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string a;

        KodePos kodePosObj = new KodePos();

        string kelurahan = "Batununggal";
        string kodePos = kodePosObj.getKodePos(kelurahan);
        System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
    }
}

public class KodePos
{
    public Dictionary<string, string> kodePosTable = new Dictionary<string, string>
        {
            {"Batununggal", "40266" },
            {"Kujangsari", "40287" },
            {"Mengger", "40267" },
            {"Wates", "40256" },
            {"Cijaura", "40287" },
            {"Jatisari", "40286" },
            {"Margasari", "40286" },
            {"Sekejati", "40286" },
            {"Kebonwaru", "40272" },
            {"Maleer", "40274" },
            {"Samoja", "40273" },
        };

    public string getKodePos(string kelurahan)
    {
        if (kodePosTable.ContainsKey(kelurahan))
        {
            return kodePosTable[kelurahan];
        } else
        {
            return "Kode pos gaada bos";
        }
    }
}