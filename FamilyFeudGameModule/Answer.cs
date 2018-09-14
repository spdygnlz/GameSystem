using GameInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace FamilyFeudGameModule
{
    public class Answer : INotifyPropertyChanged
    {
        public string Response { get; set; }
        public int SurveyCount { get; set; }        
        public bool HasQuestion { get => !string.IsNullOrWhiteSpace(Response); }
        public event PropertyChangedEventHandler PropertyChanged;


        [XmlIgnore]
        public int Number { get; set; }

        [XmlIgnore]
        public bool IsRevealed { get; set; }

        [XmlIgnore]
        public ICommand AnswerClick { get; set; }

        public Answer()
        {
            Number = 0;
            IsRevealed = false;
            AnswerClick = new DelegateCommand(ExecuteAnswerClick);
        }

        private void ExecuteAnswerClick(object o)
        {
            IsRevealed = true;
            Trace.WriteLine($"Clicked {Response} for {SurveyCount} points.");
        }

    }
}
