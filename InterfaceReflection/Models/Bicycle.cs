using InterfaceReflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceReflection.Models
{
    class Bicycle:Vehicle,IWheel
    {
        private string _pedalKind;
        private double _wheelThickness;
        private double _driveTime;
        private double _drivePath;

        public string PedalKind 
        {
            get
            {
                return _pedalKind;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _pedalKind = value;
                }
            }
        }
        public override double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }
        public override double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }
        public double WheelThickness
        {
            get
            {
                return _wheelThickness;
            }
            set
            {
                if (value > 0)
                {
                    _wheelThickness = value;
                }
            }

        }

        //ctor
        public Bicycle(double driveTime,double drivePath,string pedalKind,double wheelThickness)
        {
            DriveTime = driveTime;DrivePath = drivePath;PedalKind = pedalKind;WheelThickness = wheelThickness;
        }

        


        //Infonu qaytarir .
        public override string ShowInfo()
        {
            return $@"Drive time --> {DriveTime} hour
Drive path --> {DrivePath} km
Wheel thickness --> {WheelThickness}
Pedal kind --> {PedalKind}";
        }
    }
}
