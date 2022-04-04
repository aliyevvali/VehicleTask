using InterfaceReflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceReflection.Models
{
    class Plane:Vehicle,IEngine,IWheel,ITransmission
    {
        
        private int _horsePower;
        private double _tankSize;
        private double _currentOil;
        private double _wingLength;
        private string _fuelType;
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;
        private string _transmissionKind;

        public double WingLength 
        {
            get
            {
                return _wingLength;
            }
            set
            {
                if (value>0)
                {
                    _wingLength = value;
                }
            }
        }
        public string TransmissionKind
        {
            get
            {
                return _transmissionKind;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _transmissionKind = value;
                }
            }
        }
        public int HorsePower
        {
            get
            {
                return _horsePower;
            }
            set
            {
                if (value > 0)
                {
                    _horsePower = value;
                }
            }
        }
        public double TankSize
        {
            get
            {
                return _tankSize;
            }
            set
            {
                if (value < 80 && value > 0)
                {
                    _tankSize = value;
                }
                
            }
        }
        public double CurrentOil
        {
            get
            {
                return _currentOil;
            }
            set
            {
                if (CurrentOil <= TankSize && value > 0)
                {
                    _currentOil = value;
                }
            }
        }
        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _fuelType = value;
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

        //ctor
        public Plane(double drivePath, double driveTime, int horsePower, double tankSize, double currentOil, string fuelType, double wheelThickness, string transmissionKind, double wingLength)
        {
            WingLength = wingLength;TransmissionKind = transmissionKind;HorsePower = horsePower;
            TankSize = tankSize;CurrentOil = currentOil;FuelType = fuelType;WheelThickness = wheelThickness;DrivePath = drivePath;DriveTime = driveTime;

        }
     
        //Qalan benzin miqdarini qaytarir.
        public double RemainOilAmount()
        {
            return TankSize - CurrentOil;
        }

        //Infonu qaytarir .
        public override string ShowInfo()
        {
            return $@"Drive Time --> {DriveTime} hour
Drive path --> {DrivePath} km
Hours power --> {HorsePower} hp
Tank size --> {TankSize} l
Current oil --> {CurrentOil} l
Fuel type --> {FuelType}
Wheel thickness --> {WheelThickness}
Transmission kind --> {TransmissionKind}
Wing length --> {WingLength}";
        }
    }
}
