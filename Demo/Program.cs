using Demo.ICloneable_InterFace;
using Demo.Interfaces;
using System.Runtime.InteropServices;
using System.Text;

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





            #region Array Of Referece Type

            #region Array of String [Immutable Type]

            //string[] Names01 = { "Omar" };
            //string[] Names02 = new string[1]; // null

            //Console.WriteLine($"HC OF Names01 = {Names01.GetHashCode()}"  );    //HC OF Names01 = 43942917
            //Console.WriteLine($"HC OF Names2 = {Names02.GetHashCode()}");       //HC OF Names2 = 59941933



            #region Shallow Copy
            //Names02 = Names01;
            // Shallow Copy  [Ref --- Stack]
            //ref  [Names01 , Names02]=>  Same Object
            //Console.WriteLine( "After Shallow Copy" );

            //Console.WriteLine($"HC OF Names01 = {Names01.GetHashCode()}");//HC OF Names01 = 43942917
            //Console.WriteLine($"HC OF Names2 = {Names02.GetHashCode()}");    //HC OF Names2 = 43942917

            //Console.WriteLine($"Name1[0]={Names01[0]}"  );//omar
            //Console.WriteLine($"Name2[0]={Names02[0]}");  //omar

            //Names02[0] = "Aya";

            //Console.WriteLine($"Name1[0]={Names01[0]}");//Aya
            //Console.WriteLine($"Name2[0]={Names02[0]}");//Aya 
            #endregion

            #region DeepCopy

            //Names02= (string[])Names01.Clone();

            //// create new object  with new  and different Identity 
            //// Object will have same object state  [Data]  Of Caller  Names01


            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"HC OF Names01 = {Names01.GetHashCode()}");//HC OF Names01 = 43942917
            //Console.WriteLine($"HC OF Names2 = {Names02.GetHashCode()}"); //HC OF Names2 = 2606490

            //Console.WriteLine($"Name1[0]={Names01[0]}");//Omar
            //Console.WriteLine($"Name2[0]={Names02[0]}");//Omar
            //Names02[0] = "Aya";
            //Console.WriteLine($"Name1[0]={Names01[0]}");//Omar
            //Console.WriteLine($"Name2[0]={Names02[0]}");//Aya 

            #endregion



            #endregion


            #region Array of StringBuilder [Mutable Type]
            //StringBuilder[] Names01 = new StringBuilder[1];
            ////Names01[0].Append("Omar"); //System.NullReferenceException: 

            //Names01[0] = new StringBuilder("Omar");
            //StringBuilder[] Names02 = new StringBuilder[1];
            //Console.WriteLine($"Name01 HC = {Names01.GetHashCode()} ");//Name01 HC = 43942917
            //Console.WriteLine($"Name02 HC = {Names02.GetHashCode()} "); //Name02 HC = 59941933



            #region Shallow Copy [Stack]
            //Names02 = Names01;


            //Console.WriteLine("Names02 = Names01");
            //Console.WriteLine($"Name01 HC = {Names01.GetHashCode()} " );//Name01 HC = 43942917
            //Console.WriteLine($"Name02 HC = {Names02.GetHashCode()} ");//Name02 HC = 43942917


            //Console.WriteLine($"Names01[0]={Names01[0]}"  );// omar
            //Console.WriteLine($"Names02[0]={Names02[0]}");  // omar

            //Names02[0].Append(" amr");

            //Console.WriteLine($"Names01[0]={Names01[0]}");// omar    amr
            //Console.WriteLine($"Names02[0]={Names02[0]}");  // omar  amr 
            #endregion


            #region Deep Copy [Heap]

            //Names02 = (StringBuilder[])Names01.Clone();

            //Console.WriteLine("Names02 = (StringBuilder[])Names01.Clone();");


            //Console.WriteLine($"Names01[0]={Names01[0]}");//omar
            //Console.WriteLine($"Names02[0]={Names02[0]}");//omar

            //Names02[0].Append(" amr");


            //Console.WriteLine($"Names01[0]={Names01[0]}");// omar amr
            //Console.WriteLine($"Names02[0]={Names02[0]}");// omar amr



            #endregion



            #endregion





            #endregion




            #endregion

            #region Shallow Copy And Deep Copy 

            //Employee employee01 = new Employee() { Id = 10, Name = "Aliaa", Salary = 20000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Mona", Salary = 10000 };

            //Console.WriteLine($"employee01= {employee01}");
            //Console.WriteLine($"HC of employee01 = {employee01.GetHashCode()}");
            ////employee01= id = 10 , Name = Aliaa, Salary = 20000
            ////HC of employee01 = 43942917


            //Console.WriteLine($"employee02= {employee02}");
            //Console.WriteLine($"HC of employee02 = {employee02.GetHashCode()}");
            ////employee02= id = 20 , Name = Mona, Salary = 10000
            ////HC of employee02 = 59941933    

            #region Shallow Copy 

            //employee02 = employee01;


            //Console.WriteLine("After Shallow Copy");


            //Console.WriteLine($"employee01= {employee01}");
            //Console.WriteLine($"HC of employee01 = {employee01.GetHashCode()}");
            ////employee01= id = 10 , Name = Aliaa, Salary = 20000
            ////HC of employee01 = 43942917


            //Console.WriteLine($"employee02= {employee02}");
            //Console.WriteLine($"HC of employee02 = {employee02.GetHashCode()}");
            ////employee02= id = 20 , Name = Mona, Salary = 10000
            ////HC of employee02 = 59941933    


            //employee01.Id= 10;
            //employee01.Name = "aya";
            //employee01.Salary = 50000;

            //Console.WriteLine($"employee01= {employee01}");
            //Console.WriteLine($"employee02= {employee02}");





            #endregion


            #region Deep Copy

            //employee02 = (Employee)employee01.Clone();

            //Console.WriteLine("After Deep Copy");


            //Console.WriteLine($"employee01= {employee01}");
            //Console.WriteLine($"HC of employee01 = {employee01.GetHashCode()}");
            ////employee01= id = 10 , Name = Aliaa, Salary = 20000
            ////HC of employee01 = 43942917


            //Console.WriteLine($"employee02= {employee02}");
            //Console.WriteLine($"HC of employee02 = {employee02.GetHashCode()}");
            ////employee02= id = 20 , Name = Mona, Salary = 10000
            ////HC of employee02 = 59941933    



            //employee02.Id = 10;
            //employee02.Name = "aya";
            //employee02.Salary = 50000;

            //Console.WriteLine("After Changing"  );
            //Console.WriteLine($"employee01= {employee01}");
            //Console.WriteLine($"employee02= {employee02}");



            #endregion



            #endregion


        }
    }
}
