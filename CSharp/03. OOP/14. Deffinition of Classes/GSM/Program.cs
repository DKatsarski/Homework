using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{

    public class GSM
    {
        ////declaring fields
        public static readonly GSM IPhone4S = new GSM("iPhone 4s", "Apple", 300, "Gosho", new Battery(), new Display(5.5, 250000));
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory = new List<Calls>();

        //constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string model, string manufacture, decimal price)
                : this(model, manufacture)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacture, decimal price, string owner)
           : this(model, manufacture, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacture, decimal price, string owner, Battery baterry)
            : this(model, manufacture, price, owner)
        {
            this.Battery = baterry;
        }

        public GSM(string model, string manufacture, decimal price, string owner, Battery baterry, Display display)
           : this(model, manufacture, price, owner, baterry)
        {
            this.Display = display;
        }

        //properties

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }


        //override the ToString() 
        public override string ToString()
        {
            StringBuilder characteristics = new StringBuilder();

            characteristics.Append(string.Format("Model: {0}", this.model))
                .Append("\n")
                .Append(string.Format("Manufacture: {0}", this.manufacturer))
                .Append("\n");

            string value;

            if (this.price >= 0)
            {
                value = string.Format("{0:C2} ", this.price);
            }
            else
            {
                throw new ArgumentException();
            }

            characteristics.Append(string.Format("Price: {0}", value))
                .Append("\n");

            if (!string.IsNullOrEmpty(this.owner))
            {
                value = this.owner;
            }
            else
            {
                throw new ArgumentException();
            }

            characteristics.Append(string.Format("Owner: {0} ", value))
                .Append("\n");

            if (this.battery != null)
            {
                value = this.battery.ToString();
            }
            else
            {
                throw new ArgumentException();
            }

            characteristics.Append(string.Format("Battery: {0}", value))
                .Append("\n");

            if (this.display != null)
            {
                value = this.display.ToString();
            }
            else
            {
                throw new ArgumentException();
            }

            characteristics.Append(string.Format("Display: {0}", value))
                .Append("\n");

            return characteristics.ToString();
        }



        public void AddCall(Calls currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void DeleteCall(Calls currentCall)
        {
            this.callHistory.Remove(currentCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            var totalSeconds = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalSeconds += this.callHistory[i].DurationInSeconds;
            }

            decimal price = totalSeconds * (pricePerMinute / 60);
        

            return price;
        }
        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();

            if (this.callHistory.Count == 0)
            {
                return "Call history is empty!";
            }

            callHistoryInfo.Append("Date\t\tTime\t\tDailed number\tDuration seconds\n");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callHistoryInfo.Append(this.callHistory[i].ToString());
                callHistoryInfo.Append("\n");
            }

            return callHistoryInfo.ToString();
        }



    }









    class Program
    {
        static void Main(string[] args)
        {


        }
    }


}