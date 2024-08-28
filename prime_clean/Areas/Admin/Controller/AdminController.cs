using Entity.Services;
using Microsoft.AspNetCore.Mvc;

namespace prime_clean.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IRoomService _roomService;
        private readonly ICleaningTaskService _cleaningTaskService;
        private readonly IReservationService _reservationService;
        private readonly IReservationDetailService _reservationDetailService;

        public AdminController(
            ICustomerService customerService,
            IRoomService roomService,
            ICleaningTaskService cleaningTaskService,
            IReservationService reservationService,
            IReservationDetailService reservationDetailService)
        {
            _customerService = customerService;
            _roomService = roomService;
            _cleaningTaskService = cleaningTaskService;
            _reservationService = reservationService;
            _reservationDetailService = reservationDetailService;
        }

        // Müşteri Yönetimi
        public async Task<IActionResult> ManageCustomers()
        {
            var customers = await _customerService.GetAllCustomersAsync();
            return View(customers);
        }

        // Oda Yönetimi
        public async Task<IActionResult> ManageRooms()
        {
            var rooms = await _roomService.GetAllRoomsAsync();
            return View(rooms);
        }

        // Temizlik Görevleri Yönetimi
        public async Task<IActionResult> ManageCleaningTasks()
        {
            var cleaningTasks = await _cleaningTaskService.GetAllCleaningTasksAsync();
            return View(cleaningTasks);
        }

        // Rezervasyon Yönetimi
        public async Task<IActionResult> ManageReservations()
        {
            var reservations = await _reservationService.GetAllReservationsAsync();
            return View(reservations);
        }

        // Rezervasyon Detayları Yönetimi
        public async Task<IActionResult> ManageReservationDetails()
        {
            var reservationDetails = await _reservationDetailService.GetAllReservationDetailsAsync();
            return View(reservationDetails);
        }

        // CRUD işlemleri için diğer metotları da buraya ekleyebilirsiniz (Create, Edit, Delete, Details vb.)
    }
}
