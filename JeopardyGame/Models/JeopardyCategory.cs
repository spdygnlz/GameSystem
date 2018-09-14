using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace JeopardyGame
{
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
