using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    internal class AirPlane : Vehicle, IMovable, IFlayable
    {
        void IMovable.Backward()
        {
            Console.WriteLine("AirPlane Move backword on Groud");
        }

        void IFlayable.Backward()
        {
            Console.WriteLine("AirPlane Move backword on Air");
            ;
        }

        void IMovable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlayable.Forward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlayable.Left()
        {
            throw new NotImplementedException();
        }

        void IMovable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlayable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
