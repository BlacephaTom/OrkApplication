using OrkApplication.Classes.SquadClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkApplication.Factories.OrkSquadCreationFactoryMethod
{
    

    class SluggaSquadCreator : SquadCreatorFactory
    {
        protected override BaseSquadClass CreateSquad()
        {
            return new OrkApplication.Classes.SquadClasses.Troops.SluggaBoyzClass();
        }
    }

    abstract class SquadCreatorFactory
    {
        protected abstract OrkApplication.Classes.SquadClasses.BaseSquadClass CreateSquad();

        public void MakeSquad()
        {
            OrkApplication.Classes.SquadClasses.BaseSquadClass squad = CreateSquad();
        }

    }
}
