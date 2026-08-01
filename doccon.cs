namespace WebApplication2.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;
        private const int PageSize = 6;
        public DoctorController(AppDbContext context) { _context = context; }

        public IActionResult Index(string searchName, string searchSpec, int page = 1)
        {
            var doctors = _context.Doctors.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
                doctors = doctors.Where(d => d.Name.Contains(searchName));
            if (!string.IsNullOrEmpty(searchSpec))
                doctors = doctors.Where(d => d.Specialization.Contains(searchSpec));

            var totalDoctors = doctors.Count();
            var doctorsList = doctors.Skip((page - 1) * PageSize).Take(PageSize).ToList();

            ViewBag.TotalPages = (int)Math.Ceiling(totalDoctors / (double)PageSize);
            ViewBag.CurrentPage = page;
            ViewBag.SearchName = searchName;
            ViewBag.SearchSpec = searchSpec;

            return View(doctorsList);
        }
    }
}
