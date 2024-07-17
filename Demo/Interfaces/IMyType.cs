using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    //Default Access Modifier of Interface => Internal

    internal interface IMyType
    {
        //Default Access Modifier Inside Interface => Public
        //Private Access Modifier is not allowed inside interface



        //Signature for Property
        //Signature for Method
        //Default Implemented Method 

        // What You Can Write Inside The Interface

        //1. sigature for prop [Name - Type - get - set] 

        public int Id { get; set; }

        // inside class or struct => automatic prop
        // compiler will generate priv hidden atr [backing field]

        //2. sigature for method [Name - return type - paramter] 

        public void MyFun(int X);


        //3. default implemented method

        public void Print()
        {
            Console.WriteLine("Hello Default implemented Method from interface");
        }

    }
}
