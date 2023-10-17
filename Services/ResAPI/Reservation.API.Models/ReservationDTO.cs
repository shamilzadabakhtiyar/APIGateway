using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? Checkindate { get; set; }
        public DateTime? Checkoutdate { get; set; }
        public DateTime? Bkgdate { get; set; }
        public decimal Amount { get; set; }
    }
}
