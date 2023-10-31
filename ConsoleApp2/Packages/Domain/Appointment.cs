using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2.Packages.Domain
{
    public class Appointment
    {
        public string Name {  get;  }
        public DateTime DateTime { get; }
        private Status State { get; set; }
        public Appointment(string name, string dateTime)
        {            
            this.Name = name;
            this.DateTime = ParseDateTime(dateTime);
        }
        public static Appointment Create(string name, string dateTime)
        {
            return new Appointment(name, dateTime);
        }

        public static DateTime ParseDateTime(string dateTime)
        {
            return DateTime.ParseExact(dateTime, "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
        }

        public bool IsScheduled()
        {
            return State.Equals(Status.SCHEDULED);
        }

        public void Cancel()
        {
            State = Status.CANCELED;
        }

        internal enum Status
        {
            SCHEDULED,
            CANCELED,
            STARTED
        }
    }
}
