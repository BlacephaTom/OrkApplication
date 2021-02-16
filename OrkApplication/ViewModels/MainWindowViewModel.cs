using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrkApplication.Views;
using OrkApplication.ViewModels;


namespace OrkApplication.ViewModels
{
    public class MainWindowViewModel : BaseApplicationClasses.UpdateUIClass
    {

        public MainWindowViewModel()
        {
            



        }

        #region Properties

      
        public object TabViewModel
        {
            get
            {
                return new ViewModels.ScreenViewModels.TroopsViewModel();
            }
        }


        #endregion



        }
    }
