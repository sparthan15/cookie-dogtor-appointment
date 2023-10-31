using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Packages.Domain
{
    public class DogtorClient
    {
        public List<Appointment> Appointments { get; }

        public DogtorClient()
        {
            Appointments = new List<Appointment>();
        }

        public static DogtorClient Start()
        {            
            return new DogtorClient();
        }

        public void Book(Appointment appointment)
        {
           this.Appointments.Add(appointment);
        }
    }
}
