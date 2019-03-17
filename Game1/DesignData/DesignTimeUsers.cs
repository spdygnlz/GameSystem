using Game1.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.DesignData
{
    public class DesignTimeUsers
    {
        public ObservableCollection<UserViewModel> Users { get; set; }
        public DesignTimeUsers()
        {
            Users = new ObservableCollection<UserViewModel>();

            Users.Add(new UserViewModel() { FirstName = "Jackson", ButtonId = 1, Score=200 });
            Users.Add(new UserViewModel() { FirstName = "Katie", ButtonId = 2, Score=-300 });
            Users.Add(new UserViewModel() { FirstName = "Cassidy", ButtonId = 3, Score=100 });
            Users.Add(new UserViewModel() { FirstName = "Riley", ButtonId = 4, Score=-100 });
        }
    }
}
