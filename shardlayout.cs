<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - HospitalSystem</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">

    <style>
            body {
                background-image: url('https://img.freepik.com/free-photo/medical-banner-with-doctor-wearing-gown.jpg');
                background-size: cover;
                background-attachment: fixed;
                background-position: center;
                min-height: 100vh;
            }
            .glass-card {
                background: rgba(255, 255, 255, 0.92);
                backdrop-filter: blur(10px);
                border-radius: 15px;
                padding: 30px;
                margin-top: 30px;
                box-shadow: 0 8px 32px 0 rgba(31, 38, 135, 0.2);
            }
            .navbar {
                background: rgba(255, 255, 255, 0.8)!important;
                backdrop-filter: blur(10px);
            }
    </style>
</head>
<body>
    <nav class="navbar navbar-expand-lg shadow-sm">
        <div class="container">
            <a class="navbar-brand fw-bold text-primary" asp-controller="Home" asp-action="Index">❤️ HospitalSystem</a>
            <div>
                <a class="btn btn-outline-primary me-2" asp-controller="Doctor" asp-action="Index">Make Appointment</a>
                <a class="btn btn-outline-success" asp-controller="Appointment" asp-action="Index">View Appointments</a>
            </div>
        </div>
    </nav>

    <div class="container">
        <main role="main" class="pb-3">
            @RenderBody()
        </main>
    </div>

    <footer class="border-top footer text-muted mt-4">
        <div class="container text-center">
            &copy; 2026 - HospitalSystem
        </div>
    </footer>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
