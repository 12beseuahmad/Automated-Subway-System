using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Order order = new SubwayOrder();
            order.attach(new Manager());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(order));
        }
    }


    //Subject (Order)
    public abstract class Order
    {
        protected List<IManager> Managers = new List<IManager>();
        protected MyCustomer c = new MyCustomer();
        public abstract void attach(IManager I);
        public abstract void detach(IManager I);
        public abstract void notifyall();
        public abstract void notifycustomer(int value);


        public abstract int getValue();
        public abstract void setValue(int Value, bread b);
    }

    //ConcreteSubject (ShoeOrder) 
    public class SubwayOrder : Order
    {
        private int OrderValue;

        private bread b;
        public override int getValue()
        {
            return OrderValue;
        }
        public override void setValue(int Value, bread myb)
        {
            OrderValue = Value;
            this.b = myb;
            notifyall();
        }

        public override void attach(IManager I)
        {
            Managers.Add(I);
        }
        public override void detach(IManager I)
        {
            Managers.Remove(I);
        }
        public override void notifyall()
        {
            foreach (IManager I in Managers)
            {
                I.update(OrderValue, this.b);
            }
        }

        public override void notifycustomer(int value)
        {
            c.update(value);
        }

    }

    //Observer (IManager)
    public interface IManager
    {
        void update(int Value, bread b);
    }

    //ConcreteObserver (Investor)
    public class Manager : IManager
    {

        private int OrderValue;
        public void update(int Value, bread b)
        {
            OrderValue = Value;
            string sends = "\nNew Order Value Notification. \n Order #" + OrderValue + "\nDescription\n\n" + b.Description + "\n\n" + "Price = " + b.Cost();
            Form2 f = new Form2(sends);
            f.Show();
  
        }

       


    }


     public class MyCustomer
        {

            private int OrderValue;
            public void update(int Value)
            {
                OrderValue = Value;
                string sss = "Customer with order id = " + Value + "Your Order is Ready Please Pay and Recieve From The Counter";
                Form3 f = new Form3(sss);
                f.Show();
            }

        }
}
