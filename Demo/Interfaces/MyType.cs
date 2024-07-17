using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    //class : interface =>implement
    //struct: inteface=>  implement
    //interface:interface =>inherite

    internal class MyType : IMyType
    {
        public int Id { get; set; }

        public void MyFun(int X)
        {
            Console.WriteLine( $"Hello Route : X  = {X} , id = {Id}" );
        }
    }
}
