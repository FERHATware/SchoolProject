# SchoolProject – ASP.NET Core 8 Web Application

SchoolProject is a modern ASP.NET Core 8 web application built with Entity Framework Core, SQL Server, and ASP.NET Core Identity.  
The project demonstrates a clean and scalable architecture for managing school-related data, providing authentication, database operations, and structured service layers.

---

## 🚀 Features

- **ASP.NET Core 8** – Fast and modern web framework  
- **Entity Framework Core 8 (EF Core)** – Database ORM  
- **SQL Server Integration**  
- **ASP.NET Core Identity** – User authentication & authorization  
- **Layered Architecture**  
- **Configuration via `appsettings.json`**  
- **Dependency Injection**  
- **Logging Integration**

---

## 🏗️ Technologies Used

| Technology | Version |
|-----------|---------|
| ASP.NET Core | 8.0 |
| Entity Framework Core | 8.0 |
| Identity | 8.0 |
| SQL Server | Latest |
| C# | .NET 8 |
| Microsoft.Data.SqlClient | 5.1.1 |

---

## 📁 Project Structure


SchoolProject/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── Migrations/
├── appsettings.json
├── Program.cs
└── SchoolProject.csproj


## 📸 Screenshots

<table>
  <tr>
    <td align="center"><strong>Landing</strong><br><img src="screenshots/Home.png" width="150"></td>
    <td align="center"><strong>Services</strong><br><img src="screenshots/Courses.png" width="150"></td>
    <td align="center"><strong>Portfolio</strong><br><img src="screenshots/CreateNewStudent.png" width="150"></td>
    <td align="center"><strong>About</strong><br><img src="screenshots/RegisterStudent.png" width="150"></td>
    <td align="center"><strong>Contact</strong><br><img src="screenshots/Room.png" width="150"></td>
<td align="center"><strong>Contact</strong><br><img src="screenshots/Student.png" width="150"></td>
<td align="center"><strong>Contact</strong><br><img src="screenshots/Teacher.png" width="150"></td>
  </tr>
</table>



## ⚙️ Database Configuration

"ConnectionStrings": {
  "MyConnection": "Data Source=DESKTOP-KM1QQQ9; Initial Catalog=SchoolDb; Integrated Security=true; TrustServerCertificate=True"
}


## 🔧 Entity Framework Core Commands

dotnet ef migrations add InitialCreate
dotnet ef database update

## 📝 Logging Configuration

"Logging": {
  "LogLevel": {
    "Default": "Information",
    "Microsoft.AspNetCore": "Warning"
  }
}

## ▶️ How to Run

Clone the repository

Update your SQL Server connection string

Run database migrations

Start the project: dotnet run

## 👤 Author

Ferhat
GitHub: [your profile link](https://github.com/FERHATware)
LinkedIn: [your profile link](https://www.linkedin.com/in/ferhat-osman-ba7131323/)

## ⭐ Contributions

Pull requests are welcome!
If you like this project, consider giving it a ⭐ on GitHub.
