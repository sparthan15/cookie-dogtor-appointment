using ConsoleApp2.Packages.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Test.Packages.Domain
{
    public class DogtorClientTest
    {
        [Fact]
        public void clientStartWithEmptyCalendar()
        {
            DogtorClient dogtorClient = DogtorClient.Start();
            Assert.NotNull(dogtorClient);
            Assert.Empty(dogtorClient.Appointments);
        }

        [Fact]
        public void client_couldHaveMoreThantOneAppointment()
        {
            Appointment appointment = Appointment.Create("Charlie", AppointmentTest.DATETIME);
            DogtorClient dogtorClient = DogtorClient.Start();
            dogtorClient.Book(appointment);
            Assert.NotNull(dogtorClient);
            Assert.NotEmpty(dogtorClient.Appointments);
        }
    }
}
