using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractvsInterface
{
    //interfaceler kod yazmaktan çok oluşturulan yapının sözleşmeleridir taslağı belirler,yeteneklerini kapsar
    //c# 8 den önce interfaceler içerisinde kod yazılamıyordu 8'den sonra sadece "static kodlar" yazılabilmektedir.
    //Classlar veya abstract classlar 1 kez inherit edilebilir interfaceler birden fazla olabilir.
    public interface IVehicle
    {
        void Go();
        void Stop();
    }

    public interface IRideable
    {
        void Ride();
    }
    public interface IFlyable
    {//süzülmek
        void Soar();
    }

    public abstract class BaseVehicle:IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vehicle is going");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle has stopped");

        }
    }

    public class Car : BaseVehicle
    {

    }

    public class Bike : BaseVehicle,  IRideable
    {
        public void Ride()
        {
            throw new NotImplementedException();
        }
    }

    public class Plane : BaseVehicle,  IFlyable
    {
        public void Soar()
        {
            throw new NotImplementedException();
        }
    }
}
