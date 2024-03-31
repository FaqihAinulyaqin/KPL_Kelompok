using System;
using System.Text.Json;

public class DataMahasiswa_1302220086_PRAKTIKAN
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public Nama nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa_1302220086_PRAKTIKAN() { }
    public static DataMahasiswa_1302220086_PRAKTIKAN FromJsonString(string jsonString)
    {
        return JsonSerializer.Deserialize<DataMahasiswa_1302220086_PRAKTIKAN>(jsonString);
    }
    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas{fakultas}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        string jsonString = "{\"nama\": {\"depan\": \"Muhammad Faqih\", \"belakang\": \"Ainulyaqin\"}, \"nim\": 1302220086, \"fakultas\": \"Informatika\"}";

        DataMahasiswa_1302220086_PRAKTIKAN mahasiswa = DataMahasiswa_1302220086_PRAKTIKAN.FromJsonString(jsonString);

        mahasiswa.PrintData();
    }
}