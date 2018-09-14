using GameInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FamilyFeudGameModule
{
    public class FamilyFeudGameViewModel
    {

        

        public Answer Answer1 { get; set; }
        public Answer Answer2 { get; set; }
        public Answer Answer3 { get; set; }
        public Answer Answer4 { get; set; }
        public Answer Answer5 { get; set; }
        public Answer Answer6 { get; set; }
        public Answer Answer7 { get; set; }
        public Answer Answer8 { get; set; }

        public string Question { get => _model.Question; }

        private FamilyFeudDataModel _model;


        public FamilyFeudGameViewModel()
        {
            WriteModel();

            _model = FamilyFeudModelHelper.OpenModel(@".\FamFeudGame2.ffd");
            var answers = _model.Answers.OrderBy(a => a.SurveyCount).ToList();
            var maxIndex = answers.Count - 1;

            Answer1 = 0 <= maxIndex ? answers[0] : new Answer();
            Answer2 = 1 <= maxIndex ? answers[1] : new Answer();
            Answer3 = 2 <= maxIndex ? answers[2] : new Answer();
            Answer4 = 3 <= maxIndex ? answers[3] : new Answer();
            Answer5 = 4 <= maxIndex ? answers[4] : new Answer();
            Answer6 = 5 <= maxIndex ? answers[5] : new Answer();
            Answer7 = 6 <= maxIndex ? answers[6] : new Answer();
            Answer8 = 7 <= maxIndex ? answers[7] : new Answer();

            Answer1.Number = 1;
            Answer2.Number = 2;
            Answer3.Number = 3;
            Answer4.Number = 4;
            Answer5.Number = 5;
            Answer6.Number = 6;
            Answer7.Number = 7;
            Answer8.Number = 8;
        }

        private void WriteModel()
        {
            FamilyFeudDataModel model = new FamilyFeudDataModel();
            model.Question = "Name a bad job for someone who is accident prone.";
            model.Answers.Add(new Answer { Response = "Driver", SurveyCount = 33 });
            model.Answers.Add(new Answer { Response = "Construction", SurveyCount = 20 });
            model.Answers.Add(new Answer { Response = "Police Officer", SurveyCount = 11 });
            model.Answers.Add(new Answer { Response = "Food Service", SurveyCount = 10 });
            model.Answers.Add(new Answer { Response = "Glass Maker", SurveyCount = 9 });
            model.Answers.Add(new Answer { Response = "Window Washer", SurveyCount = 7 });
            model.Answers.Add(new Answer { Response = "Surgeon", SurveyCount = 6 });

            FamilyFeudDataModel model2 = new FamilyFeudDataModel();
            model2.Question = "Name a Place You Visit Where You Aren't Allowed to Touch Anything.";
            model2.Answers.Add(new Answer { Response = "Museum Gallery", SurveyCount = 68 });
            model2.Answers.Add(new Answer { Response = "Zoo", SurveyCount = 20 });
            model2.Answers.Add(new Answer { Response = "Gentlemen's Club", SurveyCount = 5 });
            model2.Answers.Add(new Answer { Response = "Baseball", SurveyCount = 18 });
            model2.Answers.Add(new Answer { Response = "China Shop", SurveyCount = 5 });

            FamilyFeudDataModel model3 = new FamilyFeudDataModel();
            model3.Question = "Name a Recreational Activity Traditionally Done in Hot Weather.";
            model3.Answers.Add(new Answer { Response = "Swimming", SurveyCount = 44 });
            model3.Answers.Add(new Answer { Response = "Baseball", SurveyCount = 18 });
            model3.Answers.Add(new Answer { Response = "Volleyball", SurveyCount = 17 });
            model3.Answers.Add(new Answer { Response = "Surfing", SurveyCount = 11 });
            model3.Answers.Add(new Answer { Response = "Boating", SurveyCount = 9 });

            FamilyFeudDataModel model4 = new FamilyFeudDataModel();
            model4.Question = "Name an Article of Clothing You Can't Wash in the Washing Machine.";
            model4.Answers.Add(new Answer { Response = "Shoe", SurveyCount = 29 });
            model4.Answers.Add(new Answer { Response = "Bra", SurveyCount = 21 });
            model4.Answers.Add(new Answer { Response = "Hat", SurveyCount = 16 });
            model4.Answers.Add(new Answer { Response = "Coat", SurveyCount = 13 });
            model4.Answers.Add(new Answer { Response = "Sweater", SurveyCount = 9 });
            model4.Answers.Add(new Answer { Response = "Suit", SurveyCount = 7 });
            model4.Answers.Add(new Answer { Response = "Gown", SurveyCount = 3 });

            FamilyFeudDataModel model5 = new FamilyFeudDataModel();
            model5.Question = "Name Something People Are Often Chased by in Movies.";
            model5.Answers.Add(new Answer { Response = "Monsters", SurveyCount = 37 });
            model5.Answers.Add(new Answer { Response = "Cars", SurveyCount = 22 });
            model5.Answers.Add(new Answer { Response = "Cops", SurveyCount = 19 });
            model5.Answers.Add(new Answer { Response = "Bad Guys", SurveyCount = 10 });
            model5.Answers.Add(new Answer { Response = "Dogs", SurveyCount = 10 });

            FamilyFeudModelHelper.WriteModel(@".\FamFeudGame1.ffd", model);
            FamilyFeudModelHelper.WriteModel(@".\FamFeudGame2.ffd", model2);
            FamilyFeudModelHelper.WriteModel(@".\FamFeudGame3.ffd", model3);
            FamilyFeudModelHelper.WriteModel(@".\FamFeudGame4.ffd", model4);
            FamilyFeudModelHelper.WriteModel(@".\FamFeudGame5.ffd", model5);
        }
    }
}
