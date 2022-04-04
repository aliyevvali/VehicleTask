using InterfaceReflection.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceReflection.Models
{
    class Car : Vehicle, IEngine, ITransmission, IWheel
    {
        private int _doorCount;
        private int _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _winCode;
        private string _fuelType;
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;
        private string _transmissionKind;

        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
            {
                if (value <= 6 && value > 0)
                {
                    _doorCount = value;
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
        public string WinCode
        {
            get { return _winCode; }
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _winCode = value;
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
                if (value >0)
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
                if (value>0)
                {
                    _wheelThickness = value;
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

        //ctor
        public Car(string winCode, double drivePath, double driveTime, int horsePower, double tankSize, double currentOil, string fuelType, double wheelThickness, string transmissionKind, int doorCount)
        {
            DoorCount = doorCount; HorsePower = horsePower; TankSize = tankSize;
            CurrentOil = currentOil; FuelType = fuelType; WinCode = winCode;
            WheelThickness = wheelThickness; TransmissionKind = transmissionKind; DriveTime = driveTime;
            DrivePath = drivePath;
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
Win code --> {WinCode}
Wheel thickness --> {WheelThickness} cm
Transmission kind --> {TransmissionKind}
Door count --> {DoorCount}";
        }
    }
}
