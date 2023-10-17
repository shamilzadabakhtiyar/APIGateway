using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }

        [HttpGet("{bkgNumber}")]
        public ReservationDTO Get(int id)
        {
            return reservationService.GetResById(id);
        }
    }
}
