using System;
using System.Text.Json;

public class DataMahasiswa1302220063
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public Nama nama { get; set; }
    public long NIM { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa1302220063() { }

    public static DataMahasiswa1302220063 FromJsonString(string jsonString)
    {
        return JsonSerializer.Deserialize<DataMahasiswa1302220063>(jsonString);
    }

    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {NIM} dari fakultas {fakultas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string jsonString = "{\"nama\": {\"depan\": \"Irham\", \"belakang\": \"Baehaqi\"}, \"NIM\": 1302220063, \"fakultas\": \"Informatika\"}";

        DataMahasiswa1302220063 mahasiswa = DataMahasiswa1302220063.FromJsonString(jsonString);

        mahasiswa.PrintData();
    }
}
