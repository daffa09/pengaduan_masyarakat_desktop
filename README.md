<!-- portfolio -->
<!-- slug: pengaduan-masyarakat-desktop -->
<!-- title: Pengaduan Masyarakat Desktop -->
<!-- description: Public complaint management system desktop application built with VB.NET for handling citizen reports -->
<!-- image: https://github.com/user-attachments/assets/a4ca777b-2419-4135-888f-129fd051a701 -->
<!-- tags: vb.net, .net, mysql, desktop-app, complaint-system -->

# Public Complaint Management System (Pengaduan Masyarakat)

<img width="1536" height="1024" alt="pengaduan-masyarakat-desktop" src="https://github.com/user-attachments/assets/a4ca777b-2419-4135-888f-129fd051a701" />

A desktop-based public complaint management system built with VB.NET. This application provides a comprehensive solution for managing citizen complaints, enabling efficient tracking and resolution of public issues through different user roles.

## 📋 Overview

The public complaint system (Aplikasi Pengaduan Masyarakat) is designed to streamline the process of submitting, tracking, and resolving public complaints. Built as a simple desktop application using VB.NET, it features role-based access for citizens, officers, and administrators.

## ✨ Features

### For Citizens (Masyarakat)
- **Submit Complaints**: File new public complaints with details
- **Track Status**: Monitor complaint progress and resolution
- **View History**: Access previously submitted complaints
- **Update Information**: Edit pending complaints

### For Officers (Petugas)
- **View Complaints**: Access assigned complaints
- **Update Status**: Change complaint status and add notes
- **Respond to Reports**: Provide responses and solutions
- **Generate Reports**: Create complaint resolution reports

### For Administrators
- **User Management**: Manage citizen and officer accounts
- **System Overview**: Dashboard with statistics
- **Complaint Monitoring**: Oversee all complaints system-wide
- **Data Management**: CRUD operations on all records

## 🛠️ Technologies Used

- **VB.NET**: Visual Basic .NET framework
- **Windows Forms**: Desktop UI framework
- **MySQL**: Database management
- **ADO.NET**: Database connectivity
- **Crystal Reports** (optional): For generating reports

## 📁 Project Structure

```
pengaduan_masyarakat_desktop/
├── apk_pengaduan/             # Main application folder
│   ├── Forms/                 # UI Forms
│   │   ├── LoginForm.vb
│   │   ├── MainForm.vb
│   │   ├── ComplaintForm.vb
│   │   └── AdminPanel.vb
│   ├── Modules/               # Helper modules
│   ├── Classes/               # Data models
│   └── My Project/            # Project settings
├── apk_pengaduan.sln         # Solution file
├── tugas_pengaduan.sql       # Database schema
└── README.md
```

## 🚀 Getting Started

### Prerequisites

- **Visual Studio 2015** or later
- **.NET Framework 4.5+**
- **MySQL Server 5.7+**
- **MySQL Connector/NET**

### Database Setup

1. **Create Database**
   
   Open MySQL and create database:
   ```sql
   CREATE DATABASE db_pengaduan;
   ```

2. **Import Schema**
   ```bash
   mysql -u root -p db_pengaduan < tugas_pengaduan.sql
   ```

3. **Default Accounts**
   
   The system comes with three pre-configured accounts:

   **Citizen Account:**
   - Username: `fanthom`
   - Password: `fanthom`

   **Officer Account:**
   - Username: `petugas`
   - Password: `petugas`

   **Admin Account:**
   - Username: `admin`
   - Password: `admin`

### Installation Steps

1. **Clone Repository**
   ```bash
   git clone <repository-url>
   cd pengaduan_masyarakat_desktop
   ```

2. **Open in Visual Studio**
   - Double-click `apk_pengaduan.sln`
   - Visual Studio will load the project

3. **Install MySQL Connector**
   - Tools → NuGet Package Manager → Manage NuGet Packages
   - Search for "MySql.Data"
   - Install the package

4. **Configure Database Connection**
   
   Update connection string in `Modules/Database.vb`:
   ```vb
   Public ConnectionString As String = _
       "Server=localhost;Database=db_pengaduan;Uid=root;Pwd=your_password;"
   ```

5. **Build Solution**
   - Build → Build Solution (Ctrl+Shift+B)
   - Wait for successful compilation

6. **Run Application**
   - Debug → Start Debugging (F5)
   - Or Start Without Debugging (Ctrl+F5)

## 💻 Usage Guide

### Logging In

1. Launch the application
2. Select user type (Citizen/Officer/Admin)
3. Enter credentials from default accounts above
4. Click "Login"

### As a Citizen

#### Submit New Complaint
1. Click "New Complaint" button
2. Fill in complaint details:
   - Category (Infrastructure, Environment, Service, etc.)
   - Location
   - Description
   - Upload photo (optional)
3. Submit complaint
4. Receive complaint ID for tracking

#### Track Complaint
1. Go to "My Complaints" menu
2. View list of submitted complaints
3. Check status: Pending, In Progress, Resolved, Rejected
4. View officer responses

### As an Officer

#### Process Complaints
1. View assigned complaints dashboard
2. Select a complaint to process
3. Update status and add response
4. Mark as "In Progress" or "Resolved"
5. Save changes

#### Generate Reports
1. Select date range
2. Choose report type
3. Generate and print/export report

### As an Administrator

#### Manage Users
1. Navigate to "User Management"
2. Add/Edit/Delete user accounts
3. Assign roles and permissions
4. Reset passwords if needed

#### System Overview
1. View dashboard statistics
2. Monitor active complaints
3. Track resolution rates
4. Generate system reports

## 🎨 Features Details

### Complaint Categories
- Infrastructure Issues
- Environmental Problems
- Public Services
- Security Concerns
- Health & Sanitation
- Education
- Transportation
- Other

### Status Workflow
1. **Submitted**: Initial complaint submission
2. **Pending**: Awaiting officer assignment
3. **In Progress**: Being worked on by officer
4. **Resolved**: Issue fixed/addressed  
5. **Rejected**: Invalid or duplicate

## 🗄️ Database Schema

### Main Tables

**users**
- user_id (PK)
- username
- password
- role (citizen/officer/admin)
- full_name
- email
- phone

**complaints**
- complaint_id (PK)
- user_id (FK)
- category
- location
- description
- status
- photo_path
- created_at
- updated_at

**responses**
- response_id (PK)
- complaint_id (FK)
- officer_id (FK)
- response_text
- response_date

## 🔒 Security Features

- Password hashing for user accounts
- Role-based access control
- SQL injection prevention
- Session management
- Data validation

## 🐛 Troubleshooting

**Login Failed**
- Verify database connection
- Check user credentials
- Ensure database is populated

**Database Connection Error**
- Verify MySQL is running
- Check connection string
- Test MySQL Connector installation

**Form Won't Load**
- Check .NET Framework version
- Verify Windows Forms references
- Rebuild solution

## 🚀 Future Enhancements

- Mobile application version
- Email notifications
- SMS alerts
- Photo attachment improvement
- Real-time notifications
- Advanced search and filters
- GIS integration for maps
- Public web portal

## 🎓 Learning Outcomes

This project demonstrates:
- VB.NET desktop application development
- MySQL database integration
- Role-based authentication
- CRUD operations
- Windows Forms UI design
- ADO.NET data access
- Report generation

## 🤝 Contributing

This is an educational project. Improvements and suggestions are welcome!

## 📄 License

Open source and available for educational purposes.

---

**Built with VB.NET** 📝🏛️  
Empowering citizens to report and track public issues efficiently
