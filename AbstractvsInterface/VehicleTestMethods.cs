using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractvsInterface
{
    //interfaceler kod yazmaktan çok oluşturulan yapının sözleşmeleridir taslağı belirler,yeteneklerini kapsar
    //c# 8 den önce interfaceler içerisinde kod yazılamıyordu 8'den sonra sadece "static kodlar" yazılabilmektedir.
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

    public class Car : IVehicle
    {
        public void Go()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public class Bike : IVehicle, IRideable
    {
        public void Go()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
        public void Ride()
        {
            throw new NotImplementedException();
        }

       
    }
}
