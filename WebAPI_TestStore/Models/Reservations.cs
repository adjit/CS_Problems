using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_TestStore.Models
{
    public class Reservations
    {
        public int ID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public int HotelID { get; set; }
        public Hotel Hotel { get; set; }
    }
}