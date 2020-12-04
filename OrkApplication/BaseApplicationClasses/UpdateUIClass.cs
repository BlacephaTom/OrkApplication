using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OrkApplication.BaseApplicationClasses
{
    public class UpdateUIClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string PropertyChangedName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyChangedName));
        }

    }
}
