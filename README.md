# Employee Management System

This ASP.NET project named **EmployeeManagement** allows performing CRUD operations on employee records. The application uses the Identity Framework for authentication and authorization. Only users with the Admin role can perform CRUD operations, while users with the User role can only read employee data.

## Features
- **CRUD Operations**: Create, Read, Update, Delete employee records.
- **Role-based Authorization**: 
  - **Admin**: Full access to perform CRUD operations.
  - **User**: Read-only access to employee data.

## Getting Started

### Prerequisites
- .NET SDK
- SQL Server or a compatible database system

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/EmployeeManagement.git
   cd EmployeeManagement
   ```

2. **Configure the connection string:**
   - Open `appsettings.json`.
   - Update the connection string according to your local machine configuration:
     ```json
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=EmployeeManagement;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
     ```

3. **Update the database:**
   - Open Package Manager Console in Visual Studio.
   - Run the following command to apply migrations and update the database:
     ```bash
     Update-Database
     ```

4. **Run the project:**
   - Press `F5` in Visual Studio or use the command:
     ```bash
     dotnet run
     ```

### Credentials

To log in as an admin, use the following credentials:
- **Email:** Admin@Gmail.com
- **Password:** Admin@123

## Usage

- **Admin Role:**
  - Can perform Create, Read, Update, and Delete operations on employee records.
  
- **User Role:**
  - Can only view employee records.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License

This project is licensed under the MIT License.

---

Feel free to reach out if you have any questions or need further assistance. Happy coding!
