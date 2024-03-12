using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string a;

        KodePos kodePosObj = new KodePos();

        System.Console.Write("Pilih kelurahan yang ingin dicari kode posnya: ");
        a = System.Console.ReadLine();

        if (a == "Batununggal")
        {
            string kelurahan = "Batununggal";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Kujangsari")
        {
            string kelurahan = "Kujangsari";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Mengger")
        {
            string kelurahan = "Mengger";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Wates")
        {
            string kelurahan = "Wates";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Cijaura")
        {
            string kelurahan = "Cijaura";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Jatisari")
        {
            string kelurahan = "Jatisari";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Margasari")
        {
            string kelurahan = "Margasari";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        }
        else if (a == "Sekejati")
        {
            string kelurahan = "Sekejati";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        } else if (a == "Kebonwaru")
        {
            string kelurahan = "Kebonwaru";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        } else if (a == "Maleer")
        {
            string kelurahan = "Maleer";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        } else if (a == "Samoja")
        {
            string kelurahan = "Samoja";
            string kodePos = kodePosObj.getKodePos(kelurahan);
            System.Console.WriteLine($"Kode pos untuk kelurahan {kelurahan}: {kodePos}");
        } else
        {
            System.Console.WriteLine("Eweuh kelurahan na euy");
        }
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
            return "Eweuh kelurahan na euy";
        }
    }
}