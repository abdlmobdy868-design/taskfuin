@model List<Doctor>
<div class="glass-card">
    <h2 class="text-center mb-4">Our Doctors</h2>
    <form method="get" class="row mb-4">
        <div class="col-md-5"><input name="searchName" value="@ViewBag.SearchName" placeholder="Filter by Doctor Name" class="form-control" /></div>
        <div class="col-md-5"><input name="searchSpec" value="@ViewBag.SearchSpec" placeholder="Filter by Specialization" class="form-control" /></div>
        <div class="col-md-2"><button class="btn btn-primary w-100">Search</button></div>
    </form>

    <div class="row">
        @foreach (var d in Model)
        {
            <div class="col-md-4 mb-4">
                <div class="card h-100">
                    <img src="@d.ImageUrl" class="card-img-top" style="height:220px;object-fit:cover">
                    <div class="card-body text-center">
                        <h5>@d.Name</h5>
                        <p class="text-muted">@d.Specialization</p>
                        <a asp-controller="Appointment" asp-action="Create" asp-route-DoctorId="@d.Id" class="btn btn-success">Book Appointment</a>
                    </div>
                </div>
            </div>
        }
    </div>

    <!-- Pagination -->
    <nav>
        <ul class="pagination justify-content-center">
            @for (int i = 1; i <= ViewBag.TotalPages; i++)
            {
                <li class="page-item @(i == ViewBag.CurrentPage ? "active" : "")">
                    <a class="page-link" asp-action="Index" asp-route-page="@i" asp-route-searchName="@ViewBag.SearchName" asp-route-searchSpec="@ViewBag.SearchSpec">@i</a>
                </li>
            }
        </ul>
    </nav>
</div>
