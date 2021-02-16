using OrkApplication.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrkApplication.Structs
{

    public struct SluggaBoy : ISquadPoints
    {
        public int PointsPerModel => 6;

    }

    public struct ShootaBoy : ISquadPoints
    {
        public int PointsPerModel => 6;
    }


}
