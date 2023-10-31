using ConsoleApp2.Packages.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Test.Packages.Domain
{
    public class AppointmentTest
    {
        public static string DATETIME = "2023-10-31 10:00:00,000";
        public static string BAD_DATETIME = "2023-10-31 10:00:,000";
        [Fact]
        public void CanCReateAppointment()
        {
            Appointment appointment = Appointment.Create("Charlie", DATETIME);
            Assert.NotNull(appointment);
            Assert.Equal("Charlie", appointment.Name);
            Assert.Equal(Appointment.ParseDateTime(DATETIME), appointment.DateTime);
            Assert.True(appointment.IsScheduled());
        }

        [Fact]
        public void an_appointmen_canBeCanceled()
        {
            Appointment appointment = Appointment.Create("Charlie", DATETIME);
            appointment.Cancel();
            Assert.False(appointment.IsScheduled());
        }


        [Fact]
        public void given_theDateTImeHasNotTheRightFormat_then_catchTheException()
        {
            Assert.Throws<FormatException>(() => Appointment.Create("Charlie", BAD_DATETIME));
        }

       
    }

}
