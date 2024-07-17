using Demo.Interfaces;
using System.Runtime.InteropServices;

namespace Demo
{
    internal class Program
    {

        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series != null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(series.Current);
                    series.GetNext();
                }
                series.Reset();
            }

        }


        static void Main(string[] args)
        {

            #region InterFace

            //IMyType myType = new MyType(); // invaild
            // you cant create object from interface


            //IMyType myType;

            //you can create interface from interface
            // clr will allocate 4 bytes for ref "myType"
            // ref "myType"refer to null 
            // ref "myType"  can refer to object from class or struct


            //myType.Id = 20; //"myType"refer to null 
            //myType.Print(); //"myType"refer to null 
            //myType.MyFun(1); //"myType"refer to null 


            // IMyType myType1= new MyType();
            //  myType1.Id = 20;
            //  myType1.Print(); 
            //  myType1.MyFun(1);


            //IMyType myType = new MyType();

            //myType.Id = 60;
            //myType.MyFun(600);
            //myType.Print(); 

            #endregion

            #region InterFace Ex 01


            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            ////024681012141618

            //Console.WriteLine("\n ===========================");


            //SeriesByThree seriesByThree = new SeriesByThree();  
            //Print10NumbersFromSeries(seriesByThree);            
            ////0369121518212427


            //Console.WriteLine("\n ===========================");

            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesByFour);
            ////04812162024283236

            #endregion


            #region InterFace Ex 02

            //AirPlane airPlane = new AirPlane();
            ////airPlane.Backward(); // invaled

            //IMovable movable = new AirPlane();
            //movable.Backward();
            //IFlayable Flyable = new AirPlane();
            //Flyable.Backward();

            #endregion

            #region Shallow Copy And Deep Copy 

            #region Array of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"HC of Arr01 = {Arr01.GetHashCode()}");  //HC of Arr01 = 43942917
            //Console.WriteLine($"HC of Arr02 = {Arr02.GetHashCode()}");  //HC of Arr02 = 59941933
            #region Shallow Copy [Stack]
            //Arr02 = Arr01;

            //Console.WriteLine("After Shallow Copy");

            //Console.WriteLine($"HC of Arr01 = {Arr01.GetHashCode()}");  //HC of Arr01 = 43942917
            //Console.WriteLine($"HC of Arr02 = {Arr02.GetHashCode()}");  //HC of Arr02 = 43942917




            //Console.WriteLine($"Arr01[0]={Arr01[0]}"); //1

            //Arr02[0] = 100;

            //Console.WriteLine($"After     Arr02[0]={Arr02[0]}"); //100

            //Console.WriteLine($"HC of Arr01 = {Arr01[0]}");
            //Console.WriteLine($"HC of Arr02 = {Arr02[0]}"); 
            #endregion

            #region Deep Copy 

            //Arr02 = (int[])Arr01.Clone();

            ///Clone => Deep Copy 
            ///Deep Copy Occured At heap
            ///Creat new object with different and new Identity
            /// that object will be the same object state [Data] of Caller [Arr01]

            //Console.WriteLine("After Deep Copy ");
            //Console.WriteLine($"HC of Arr01 = {Arr01.GetHashCode()}");  //HC of Arr01 = 43942917
            //Console.WriteLine($"HC of Arr02 = {Arr02.GetHashCode()}");  //HC of Arr02 = 2606490


            //Console.WriteLine($"HC of Arr01 = {Arr01[0]}"); // 1
            //Console.WriteLine($"HC of Arr02 = {Arr02[0]}"); // 1


            //Arr01[0] = 100;

            //Console.WriteLine("After arr01[0]=100");
            //Console.WriteLine($"HC of Arr01 = {Arr01[0]}"); //100
            //Console.WriteLine($"HC of Arr02 = {Arr02[0]}"); //1


            #endregion


            #endregion

            #endregion

        }
    }
}
