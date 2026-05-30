# Enterprise Employee Management System (EMS)

## Overview

Enterprise Employee Management System (EMS) is a full-stack web application developed using ASP.NET Core MVC, Entity Framework Core, ASP.NET Identity, and SQL Server. The system is designed to streamline employee management processes within an organization by providing role-based access control, attendance tracking, leave management, and real-time business insights through interactive dashboards.

The application supports multiple users simultaneously and follows a secure role-based architecture to ensure that each user can access only the features relevant to their responsibilities.

---

## Key Features

### Role-Based Access Control

The system implements three distinct roles:

#### Administrator

* Create and manage employee accounts
* Assign usernames and passwords to employees
* Manage employee records
* View organization-wide analytics
* Monitor attendance records
* Approve or reject leave requests
* Manage user roles and permissions

#### Human Resources (HR)

* Manage employee attendance
* Review employee information
* Approve or reject leave requests
* Access workforce analytics and reports
* Monitor organizational attendance trends

#### Employee

* Secure login using credentials provided by the administrator
* View personal profile information
* Submit leave requests
* Track leave request status
* View attendance records

---

## Employee Registration Workflow

Unlike traditional systems where users can self-register, this EMS follows an enterprise-style onboarding process.

* Employees cannot create their own accounts.
* Administrators register employees within the system.
* Usernames and passwords are generated and assigned by administrators.
* Employees use these credentials to access the platform.

This approach improves security and reflects real-world corporate workflows.

---

## Attendance Management System

The attendance module allows administrators and HR personnel to:

* Record employee attendance
* Monitor attendance history
* Track employee presence and absence
* Generate attendance insights

The system is designed to efficiently handle attendance data for a growing workforce.

---

## Leave Management System

Employees can submit leave requests directly through the application.

Workflow:

1. Employee submits leave request.
2. Request is forwarded to HR and Administrator.
3. HR/Admin reviews the request.
4. Request is either:

   * Approved
   * Rejected
5. Employee can view the updated status in real time.

---

## Real-Time Dashboard & Analytics

The EMS dashboard provides live organizational insights through dynamic visualizations.

### Dashboard Features

* Live employee statistics
* Attendance summaries
* Leave request tracking
* Department-wise analytics
* Interactive charts and graphs
* Dynamic pie charts for data visualization

The dashboard updates using real-time database-driven data, allowing management to make informed decisions quickly.

---

## Security Features

The application incorporates enterprise-grade security practices:

* ASP.NET Identity Authentication
* Role-Based Authorization
* Secure Login System
* Protected Routes
* Session Management
* Access Restrictions Based on User Roles
* User Credential Management by Administrators

---

## Technology Stack

### Backend

* ASP.NET Core MVC
* C#
* Entity Framework Core
* LINQ

### Frontend

* HTML5
* CSS3
* Bootstrap
* JavaScript
* jQuery

### Database

* SQL Server

### Authentication & Security

* ASP.NET Identity
* Authentication
* Authorization
* Role Management

### Development Tools

* Visual Studio
* SQL Server Management Studio (SSMS)
* Git
* GitHub

---

## System Architecture

The project follows the MVC (Model-View-Controller) design pattern.

* Models handle application data and business logic.
* Views provide a responsive user interface.
* Controllers process requests and coordinate application flow.
* SQL Server stores application data.
* Entity Framework Core manages database interactions.

---

## Demo Credentials

For demonstration purposes:

### Administrator Account

Email:
[admin@ems.com](mailto:admin@ems.com)

Password:
Admin@123

---

## Database Setup

1. Open SQL Server Management Studio.
2. Create a database for the application.
3. Execute the SQL script located in the SQLScripts folder.
4. Update the connection string in appsettings.json.
5. Run the application.

---

## How to Run the Project

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Configure the SQL Server connection string.
5. Run database setup scripts.
6. Start the application.

---

## Highlights

* Enterprise-level Employee Management System
* Role-Based Access Control (Admin, HR, Employee)
* Secure Authentication and Authorization
* Attendance Management Module
* Leave Request Workflow
* Dynamic Dashboard with Pie Charts
* SQL Server Integration
* ASP.NET Identity Security
* Multi-User Support
* Responsive User Interface

---

## Future Enhancements

* Payroll Management
* Employee Performance Evaluation
* Email Notifications
* Department Management Module
* Export Reports to Excel/PDF
* Audit Logging
* Cloud Deployment

---

## Author

Developed as a full-stack enterprise web application using ASP.NET Core MVC and SQL Server to simulate real-world employee management workflows and organizational operations.
