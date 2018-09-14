using System.IO;
using System.Xml.Serialization;

namespace JeopardyGame
{
    public class JeopardyModelHelper
    {
        public static JeopardyModel OpenModel(string filename)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(JeopardyModel), new[] { typeof(JeopardyCategory), typeof(JeopardyQuestion) });
            // To write to a file, create a StreamWriter object.
            StreamReader myReader = new StreamReader(filename);
            var newModel = mySerializer.Deserialize(myReader);
            myReader.Close();

            return newModel as JeopardyModel;
        }

        public static void WriteModel (string filename, JeopardyModel model)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(JeopardyModel));
            // To write to a file, create a StreamWriter object.
            StreamWriter myWriter = new StreamWriter(filename);
            mySerializer.Serialize(myWriter, model);
            myWriter.Close();
        }
    }
}
