using InterfaceReflection.Models;
using System;

namespace InterfaceReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //console hissesini tam yaza bilmedim.
            WinCode(out string winCode);
            DrivePath(out double drivePath);
            DriveTime(out double driveTime);
            HorsePower(out int horsePower);
            TankSize(out double tankSize);
            CurrentOil(out double currentOil);
            FuelType(out string fuelType);
            Whtc(out double wheelThickness);
            TransmissionKind(out string transmissionKind);
            DoorCount(out int doorCount);
            Car car = new Car(winCode, drivePath,driveTime, horsePower,tankSize, currentOil, fuelType, wheelThickness, transmissionKind, doorCount);
            
            
        }
        static void WinCode(out string winCode)
        {
            Start:
            try
            {
                Console.WriteLine("Enter the Win Code :");
                winCode = Console.ReadLine();
                if (string.IsNullOrEmpty(winCode) && string.IsNullOrWhiteSpace(winCode))
                {
                    throw new Exception("null ola bilmez !");
                }               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void DrivePath(out double drivePath)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Drive Path");
                drivePath = double.Parse(Console.ReadLine());
                if (drivePath<0)
                {
                    throw new Exception("Duzgun daxil edin !");
                }
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void DriveTime(out double driveTime)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Drive Time");
                driveTime = double.Parse(Console.ReadLine());
                if (driveTime<0)
                {
                    throw new Exception("Duzgun daxil edin !");
                }
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void HorsePower(out int horsePower)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Horse Power");
                horsePower = int.Parse(Console.ReadLine());
                if (horsePower<0)
                {
                    throw new Exception("duzgun daxil edin !");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void TankSize(out double tankSize)
        {Start:
            try
            {
                Console.WriteLine("Enter Tank size ");
                tankSize = double.Parse(Console.ReadLine());
                if (tankSize<0)
                {
                    throw new Exception("Duzgun daxil edin !");
                }
            }
            catch (Exception ex )
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void CurrentOil (out double currentOil)
        {
            Start:
            try
            {
                Console.WriteLine("Enter  Curret Oil");
                currentOil = double.Parse(Console.ReadLine());
                if (currentOil<0)
                {
                    throw new Exception("Duzgun daxil edin !");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void FuelType(out string fuelType)
        {
            Start:
            try
            {
                Console.WriteLine("Enter the Fuel Type");
                fuelType = Console.ReadLine();
                if (string.IsNullOrEmpty(fuelType) && string.IsNullOrWhiteSpace(fuelType))
                {
                    throw new Exception("Duzgun daxil edin!");
                }
            }
            catch (Exception ex) 
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void Whtc(out double whth)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Wheel Thickness");
                whth = double.Parse(Console.ReadLine());
                if (whth<0)
                {
                    throw new Exception("Duzgun daxil edin !");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void TransmissionKind(out string transmassionKind)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Transmission Kind ");
                transmassionKind = Console.ReadLine();
                if (string.IsNullOrEmpty(transmassionKind) && string.IsNullOrWhiteSpace(transmassionKind))
                {
                    throw new Exception("Duzgun daxil edin !");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void DoorCount(out int doorCount)
        {
            Start:
            try
            {
                Console.WriteLine("Enter Door count ");
                doorCount = int.Parse(Console.ReadLine());
                if (doorCount<0)
                {
                    throw new Exception("Duzgun daxil edin");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
    }
}
