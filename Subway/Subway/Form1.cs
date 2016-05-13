using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subway
{

        public partial class Form1 : Form
    {

            List<int> a = new List<int>();
            List<int> b = new List<int>();
            List<int> c = new List<int>();
            List<int> d = new List<int>();
            List<int> f = new List<int>();
            Order ord; 
           

        public Form1(  Order order)
        {
            ord = order;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {






                a.Add(1);
                button2.Enabled = false;
                button3.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;
        
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.Add(2);
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.Add(3);
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.Add(4);
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b.Add(1);
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b.Add(2);
            button6.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b.Add(3);
            button12.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b.Add(4);
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b.Add(5);
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b.Add(6);
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b.Add(7);
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b.Add(8);
            button11.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            c.Add(1);
            button20.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c.Add(2);
            button19.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c.Add(3);
            button13.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            c.Add(4);
            button18.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            c.Add(5);
            button17.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c.Add(6);
            button16.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            d.Add(1);
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            d.Add(2);
            button15.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            d.Add(3);
            button21.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            f.Add(1);
            button27.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            f.Add(2);
            button26.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            f.Add(3);
            button22.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            f.Add(4);
            button25.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            f.Add(5);
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            f.Add(6);
            button23.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            subwayfactory mysubfac = subwayfactory.getInstance();
            bread mybread = mysubfac.getsubway(a, b, c, d, f);
           
            MessageBox.Show("Your Order Id is 1 \nYour Order Description\n\n"+mybread.Description+"\n\n"+"Price = "+mybread.Cost());
            this.Hide();
            ord.setValue(1,mybread);
            

            

           
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = true;
            button4.Enabled = true;
            a.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
            this.DoubleBuffered = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
        public abstract class bread
        {

            private string description = "Unknown Bread";

            public abstract double Cost();

            public virtual string Description
            {
                get
                {
                    return description;
                }
            }

        }

        public class wheatBread : bread
        {

            public override double Cost()
            {
                return 0;
            }


            public override string Description
            {
                get
                {
                    return "Wheat Bread\n";
                }
            }

        }

        public class honeyOat : bread
        {

            public override double Cost()
            {
                return 0;
            }


            public override string Description
            {
                get
                {
                    return "Honey Oat\n";
                }
            }

        }

        public class parmesanOregano : bread
        {
            public override double Cost()
            {
                return 0;
            }


            public override string Description
            {
                get
                {
                    return "Parmesan Oregano\n";
                }
            }

        }

        public class brownBread : bread
        {
            public override double Cost()
            {
                return 0;
            }


            public override string Description
            {
                get
                {
                    return "Brown Bread\n";
                }
            }

        }

        public abstract class decorator : bread
        {
            public abstract override string Description
            {
                get;
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        public class meat : decorator
        {
            private bread bread;
            private string description;
            private double cost;

            public meat(bread bread, string s, double c)
            {
                this.bread = bread;
                this.description = s;
                this.cost = c;
            }



            public override double Cost()
            {
                return (cost + bread.Cost());
            }



            public override string Description
            {
                get { return bread.Description + this.description; }
            }


        }

        ////////////////////----------------------types------------------------////////////////////

        public class meatBall : meat
        {


            public meatBall(bread bread)
                : base(bread, "Meat Ball\n", 500)
            {
            }


        }

        public class chickenTeriyaki : meat
        {

            public chickenTeriyaki(bread bread)
                : base(bread, "Chicken Teriyaki\n", 500)
            {
            }

        }

        public class chickenFajita : meat
        {

            public chickenFajita(bread bread)
                : base(bread, "Chicken Fajita\n", 500)
            {
            }

        }

        public class roastedChicken : meat
        {

            public roastedChicken(bread bread)
                : base(bread, "Roasted Chicken\n", 500)
            {
            }

        }

        public class chickenBreast : meat
        {

            public chickenBreast(bread bread)
                : base(bread, "Chicken Breast\n", 500)
            {
            }

        }

        public class steak : meat
        {

            public steak(bread bread)
                : base(bread, "Steak\n", 500)
            {
            }

        }

        public class turkeyBreast : meat
        {


            public turkeyBreast(bread bread)
                : base(bread, "Turkey Breast\n", 500)
            {
            }

        }

        public class roastBeef : meat
        {

            public roastBeef(bread bread)
                : base(bread, "Roast Beef\n", 500)
            {
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////


        public class cheese : decorator
        {

            private bread bread;
            private string description;


            public cheese(bread bread, string s)
            {
                this.bread = bread;
                this.description = s;

            }



            public override double Cost()
            {
                return (0 + bread.Cost());
            }



            public override string Description
            {
                get { return bread.Description + this.description; }
            }


        }

        ////////////////////----------------------types------------------------////////////////////

        public class mozzarella : cheese
        {

            public mozzarella(bread bread)
                : base(bread, "Mozzarella Cheese\n")
            {
            }



        }

        public class cheddar : cheese
        {

            public cheddar(bread bread)
                : base(bread, "Cheddar Cheese\n")
            {
            }

        }

        public class swiss : cheese
        {

            public swiss(bread bread)
                : base(bread, "swiss Cheese\n")
            {
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////

        public class veggies : decorator
        {

            private bread bread;
            private string description;


            public veggies(bread bread, string s)
            {
                this.bread = bread;
                this.description = s;

            }



            public override double Cost()
            {
                return (0 + bread.Cost());
            }



            public override string Description
            {
                get { return bread.Description + this.description; }
            }


        }

        ////////////////////----------------------types------------------------////////////////////

        public class cucumbers : veggies
        {

            public cucumbers(bread bread)
                : base(bread, "Cucumbers\n")
            {
            }

        }

        public class onions : veggies
        {

            public onions(bread bread)
                : base(bread, "Onions\n")
            {
            }
        }

        public class tomatoes : veggies
        {

            public tomatoes(bread bread)
                : base(bread, "Tomatoes\n")
            {
            }
        }

        public class jalapenos : veggies
        {

            public jalapenos(bread bread)
                : base(bread, "Jalapenos\n")
            {
            }

        }

        public class olives : veggies
        {

            public olives(bread bread)
                : base(bread, "Olives\n")
            {
            }
        }

        public class pickles : veggies
        {

            public pickles(bread bread)
                : base(bread, "Pickles\n")
            {
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        public class sauces : decorator
        {

            private bread bread;
            private string description;


            public sauces(bread bread, string s)
            {
                this.bread = bread;
                this.description = s;

            }



            public override double Cost()
            {
                return (0 + bread.Cost());
            }



            public override string Description
            {
                get { return bread.Description + this.description; }
            }


        }

        ////////////////////----------------------types------------------------////////////////////

        public class ketchup : sauces
        {

            public ketchup(bread bread)
                : base(bread, "Ketchup\n")
            {
            }
        }

        public class chipotle : sauces
        {

            public chipotle(bread bread)
                : base(bread, "Chipotle\n")
            {
            }
        }

        public class mustard : sauces
        {

            public mustard(bread bread)
                : base(bread, "Mustard\n")
            {
            }

        }

        public class mayonnaise : sauces
        {

            public mayonnaise(bread bread)
                : base(bread, "Mayonnaise\n")
            {
            }

        }

        public class sweetOnion : sauces
        {

            public sweetOnion(bread bread)
                : base(bread, "SweetOnion\n")
            {
            }

        }

        public class barbeque : sauces
        {

            public barbeque(bread bread)
                : base(bread, "Barbeque\n")
            {
            }

        }


        public class subwayfactory
        {

            bread mysubway;


            /////////////////////////////////////////////////////////////////////
            private static subwayfactory uniqueInstance = new subwayfactory();


            private subwayfactory() { }


            public static subwayfactory getInstance()
            {
                return uniqueInstance;
            }
            /////////////////////////////////////////////////////////




            public bread getsubway(List<int> a, List<int> b, List<int> c, List<int> d, List<int> e)
            {

                if (a.Contains(1))
                {
                    bread mbread = new wheatBread();
                    this.mysubway = mbread;
                }

                if (a.Contains(2))
                {
                    bread mbread = new honeyOat();
                    this.mysubway = mbread;
                }

                if (a.Contains(3))
                {
                    bread mbread = new parmesanOregano();
                    this.mysubway = mbread;
                }

                if (a.Contains(4))
                {
                    bread mbread = new brownBread();
                    this.mysubway = mbread;
                }

                if (b.Contains(1))
                {
                    bread mbreadwsteak = new meatBall(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(2))
                {
                    bread mbreadwsteak = new chickenTeriyaki(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(3))
                {
                    bread mbreadwsteak = new chickenFajita(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(4))
                {
                    bread mbreadwsteak = new roastedChicken(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(5))
                {
                    bread mbreadwsteak = new chickenBreast(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(6))
                {
                    bread mbreadwsteak = new steak(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(7))
                {
                    bread mbreadwsteak = new turkeyBreast(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (b.Contains(8))
                {
                    bread mbreadwsteak = new roastBeef(this.mysubway);
                    this.mysubway = mbreadwsteak;
                }

                if (c.Contains(1))
                {
                    bread mbwswpickle = new cucumbers(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (c.Contains(2))
                {
                    bread mbwswpickle = new onions(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (c.Contains(3))
                {
                    bread mbwswpickle = new tomatoes(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (c.Contains(4))
                {
                    bread mbwswpickle = new jalapenos(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (c.Contains(5))
                {
                    bread mbwswpickle = new olives(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (c.Contains(6))
                {
                    bread mbwswpickle = new pickles(this.mysubway);
                    this.mysubway = mbwswpickle;
                }

                if (d.Contains(1))
                {
                    bread addcheese = new mozzarella(this.mysubway);
                    this.mysubway = addcheese;
                }

                if (d.Contains(2))
                {
                    bread addcheese = new cheddar(this.mysubway);
                    this.mysubway = addcheese;
                }

                if (d.Contains(3))
                {
                    bread addcheese = new swiss(this.mysubway);
                    this.mysubway = addcheese;
                }

                if (e.Contains(1))
                {
                    bread addsause = new ketchup(this.mysubway);
                    this.mysubway = addsause;
                }

                if (e.Contains(2))
                {
                    bread addsause = new chipotle(this.mysubway);
                    this.mysubway = addsause;
                }

                if (e.Contains(3))
                {
                    bread addsause = new mustard(this.mysubway);
                    this.mysubway = addsause;
                }

                if (e.Contains(4))
                {
                    bread addsause = new mayonnaise(this.mysubway);
                    this.mysubway = addsause;
                }

                if (e.Contains(5))
                {
                    bread addsause = new sweetOnion(this.mysubway);
                    this.mysubway = addsause;
                }

                if (e.Contains(6))
                {
                    bread addsause = new barbeque(this.mysubway);
                    this.mysubway = addsause;
                }



                return mysubway;
            }
        }




}




