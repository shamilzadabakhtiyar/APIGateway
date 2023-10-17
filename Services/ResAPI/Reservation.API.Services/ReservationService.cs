using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResById(int id)
        {
            return new ReservationDTO
            {
                Id = id,
                Amount = new Random().Next(1000),
                Bkgdate = DateTime.Now,
                Checkindate = DateTime.Now.AddDays(30),
                Checkoutdate = DateTime.Now.AddDays(40),
                BkgNumber = new Random().Next(100)
            };
        }
    }
}
