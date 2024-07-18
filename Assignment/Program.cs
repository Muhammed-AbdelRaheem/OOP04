namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q01

            //b) To define a blueprint for a class

            #endregion


            #region Q02

            //a) private

            #endregion


            #region Q03

            //a) Yes

            #endregion

            #region Q04

            //b) Yes, interfaces can inherit from multiple interfaces




            #endregion

            #region Q05

            //d) implements



            #endregion

            #region Q06


            //a) Yes




            #endregion

            #region Q07


            //b) No, all members are implicitly public


            #endregion



            #region Q08

            //b) To provide a clear separation between interface and class members


            #endregion

            #region Q09

            //b) No, interfaces cannot have constructors



            #endregion


            #region Q10
            //c) By separating interface names with commas
            #endregion
            #endregion



            #region Part02

            #region Q01


            //ICircle circle = new Circle(10.5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(10, 5);
            //rectangle.DisplayShapeInfo();


            #endregion

            #region Q02


            //////////////////////////////////////////////////////////////


            #endregion

            #region Q03

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string Name = "Muhammed Abdel Raheem ";
            string message = "Hello, Muhammed ! This is a test message.";

            emailService.SendNotification(Name, message);
            smsService.SendNotification(Name, message);
            pushService.SendNotification(Name, message);




            #endregion


            #endregion

        }
    }
}
