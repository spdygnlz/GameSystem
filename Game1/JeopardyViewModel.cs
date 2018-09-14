using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class JeopardyViewModel
    {
        public DataTable table = new DataTable();
        private JeopardyModel model;        

        public JeopardyViewModel()
        {
            
        }

        public JeopardyViewModel(string filename)
        {
            model = JeopardyModelHelper.OpenModel(filename);
        }

        public List<JeopardyCategory> Categories
        {
            get
            {
                return model.Categories;
            }
        }

        public void WriteModel(string filename)
        {            
            JeopardyModelHelper.WriteModel(filename, model);
        }
    }
}
