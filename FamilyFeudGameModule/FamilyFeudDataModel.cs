using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FamilyFeudGameModule
{

    public static class FamilyFeudModelHelper
    {
        public static FamilyFeudDataModel OpenModel(string filename)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new XmlSerializer(typeof(FamilyFeudDataModel), new[] { typeof(Answer)});
            // To write to a file, create a StreamWriter object.
            StreamReader myReader = new StreamReader(filename);
            var newModel = mySerializer.Deserialize(myReader);
            myReader.Close();

            return newModel as FamilyFeudDataModel;
        }

        public static void WriteModel(string filename, FamilyFeudDataModel model)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new XmlSerializer(typeof(FamilyFeudDataModel), new[] {typeof(Answer)});
            // To write to a file, create a StreamWriter object.
            StreamWriter myWriter = new StreamWriter(filename);
            mySerializer.Serialize(myWriter, model);
            myWriter.Close();
        }
    }

    public class FamilyFeudDataModel
    {
        public string Question { get; set; }

        public List<Answer> Answers { get; set; }

        [XmlIgnore]
        public int Multiplier { get; set; }

        public FamilyFeudDataModel()
        {
            Answers = new List<Answer>();
        }
    }
}
