@model Appointment
<div class="glass-card">
    <h3 class="text-center mb-4">Book Appointment with @ViewBag.Doctor.Name</h3>
    <form asp-action="Create" asp-controller="Appointment" method="post">
        @Html.AntiForgeryToken()

        <input type="hidden" asp-for="DoctorId" />

        <div class="mb-3">
            <label asp-for="PatientName" class="form-label">Patient Name</label>
            <input asp-for="PatientName" class="form-control" />
            <span asp-validation-for="PatientName" class="text-danger"></span>  
        </div>

        <div class="mb-3">
            <label asp-for="AppointmentDate" class="form-label">Date</label>
            <input asp-for="AppointmentDate" type="date" class="form-control" />
            <span asp-validation-for="AppointmentDate" class="text-danger"></span>  
        </div>

        <div class="mb-3">
            <label asp-for="AppointmentTime" class="form-label">Time</label>
            <select asp-for="AppointmentTime" class="form-select" asp-items="@(new SelectList(ViewBag.TimeSlots))"></select>
            <span asp-validation-for="AppointmentTime" class="text-danger"></span> 
        </div>







                @model List<Appointment>
<div class="glass-card">
    <h2 class="text-center mb-4">All Appointments</h2>
    <table class="table table-striped table-hover">
        <thead class="table-dark">
            <tr>
                <th>Patient Name</th>
                <th>Doctor Name</th>
                <th>Specialization</th>
                <th>Appointment Date</th>
                <th>Appointment Time</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var a in Model)
            {
                <tr>
                    <td>@a.PatientName</td>
                    <td>@a.Doctor.Name</td>
                    <td>@a.Doctor.Specialization</td>
                    <td>@a.AppointmentDate.ToString("yyyy-MM-dd")</td>
                    <td>@a.AppointmentTime</td>
                </tr>
            }
        </tbody>
    </table>
</div>

        <div asp-validation-summary="All" class="text-danger mb-3"></div>
        <button type="submit" class="btn btn-primary w-100">Save Appointment</button>
    </form>
</div>
