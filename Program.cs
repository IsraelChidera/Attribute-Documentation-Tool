using Documentation;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Documentation_client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DocumentDescription.WriteDocsToTxtFile();
            //DocumentDescription.GetDocsTextFile();            
            JsonConverters.Generate();
        }
    }
}