using System.Runtime.InteropServices;
using Newtonsoft.Json.Schema.Generation;


namespace PTFDCallbackModel;

public class Program
{
    public static void Main(string[] args)
    {
        var generator = new JSchemaGenerator();
        var schema = generator.Generate(typeof(Dummy));
        var sch = schema.ToString();

        var outpath = @"E:\Projects\PTFDCallbackServer\PTFDCallbackModel\model.json";
        
        File.WriteAllText(outpath, sch);

        Console.WriteLine("Schema generated and saved to " + outpath);

    }
}