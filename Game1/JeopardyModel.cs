using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Game1
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

    [Serializable]
    [XmlRoot]
    public class JeopardyModel
    {
        [XmlArray]
        public List<JeopardyCategory> Categories { get; set; }
        [XmlArray]
        public List<JeopardyCategory> DoubleJeopardyCategories { get; set; }        
        public JeopardyCategory FinalJeopardy { get; set; }

        public JeopardyModel()
        {
            Categories = new List<JeopardyCategory>();
            DoubleJeopardyCategories = new List<JeopardyCategory>();
            FinalJeopardy = new JeopardyCategory();
            //FinalJeopardy.AddQuestion(new JeopardyQuestion() { Question = "Question", Answer = "Answer", Used = false, Value = 0 });

            //for (int cat = 0; cat < 6; cat++)
            //{
            //    var category = new JeopardyCategory() { Name = $"Potent Potables {cat}" };
            //    for (uint ques = 1; ques < 6; ques++)
            //    {
            //        var question = new JeopardyQuestion () { Question = $"Q{ques}C{cat}", Answer = $"A{ ques }C{ cat }", Value = ques * 100};
            //        category.AddQuestion(question);
            //    }
            //    Categories.Add(category);
            //    DoubleJeopardyCategories.Add(category);
            //}
        }

        public void ReadModel(string filename)
        {
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(JeopardyModel));
            // To write to a file, create a StreamWriter object.
            StreamReader myReader = new StreamReader(filename);
            var newModel = mySerializer.Deserialize(myReader);
            myReader.Close();            
        }

        public void WriteModel(string filename)
        {            
            // Insert code to set properties and fields of the object.
            XmlSerializer mySerializer = new
            XmlSerializer(typeof(JeopardyModel));
            // To write to a file, create a StreamWriter object.
            StreamWriter myWriter = new StreamWriter(filename);
            mySerializer.Serialize(myWriter, this);
            myWriter.Close();
        }
    }

    [Serializable]
    public class JeopardyQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public uint Value { get; set; }
        public bool Used { get; set; }        
    }

    [Serializable]
    public class JeopardyCategory
    {
        private List<JeopardyQuestion> _questions = new List<JeopardyQuestion>();

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlArray(ElementName ="Questions")]
        public List<JeopardyQuestion> Questions
        {
            get
            {                
                return _questions;
            }
            set
            {
                _questions = value.OrderBy(x => x.Value).ToList();
            }
        }

        public void AddQuestion (JeopardyQuestion question)
        {
            _questions.Add(question);
        }

        public JeopardyQuestion this[int index]
        {
            get
            {
                if (Questions.Count > index)
                {
                    return Questions[index];
                }

                else return null;
            }
            set
            {
                Questions[index] = value;
            }
        }
  
    }
}
