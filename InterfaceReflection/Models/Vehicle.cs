using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceReflection.Models
{
    abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }
        
        //Surreti tapaq uchun method.
        public  double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public abstract string ShowInfo();


    }
}
