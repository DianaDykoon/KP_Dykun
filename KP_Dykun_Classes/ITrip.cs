using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public interface ITrip
    {
        DateTime Date { get; set; }
        string PointOfDeparture { get; set; }
        string Destination { get; set; }
        short NumberOfSeats { get; set; }
        Driver Driver { get; set; }
        string TripInfo();
    }

}
