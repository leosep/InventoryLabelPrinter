# Inventory Label Printer

Inventory Label Printer is a Windows Forms application designed to streamline the process of printing labels for inventory management. The application allows users to search for inventory items, select the items they need, and print labels using a Zebra ZD500R printer. It features user authentication, filtering, and progress tracking to ensure efficient and accurate label printing.

## Features

- **User Authentication**: Secure login system to ensure that only authorized personnel can access the application.
- **Inventory Search and Filter**: Search inventory items based on various criteria such as code, description, type, group, and series.
- **Batch Label Printing**: Select multiple inventory items and print labels in batch mode.
- **Progress Tracking**: Real-time progress tracking of label printing process.
- **Customizable DataGridView**: Dynamically add checkboxes and adjust the grid based on the form size.
- **Error Handling**: User-friendly error messages and exception handling.

## Technologies Used

- **.NET Framework**: Windows Forms for the user interface.
- **Entity Framework**: For database interactions.
- **Zebra Printer SDK**: For printing labels.
- **MD5 Encryption**: For secure password encryption.

## Getting Started

### Prerequisites

- .NET Framework 4.7.2 or later
- Visual Studio 2019 or later
- SQL Server with the GOFFICE_DATA database

### Usage

1. **Login**: Enter your username and password to login.
2. **Search Inventory**: Use the search filters to find inventory items.
3. **Select Items**: Select the items you want to print labels for using the checkboxes.
4. **Print Labels**: Click the "Print" button to start printing labels.
5. **Track Progress**: Monitor the progress of the printing process in real-time.

## Project Structure

- **DAL**: Data Access Layer for database interactions.
- **BLL**: Business Logic Layer for core business logic.
- **Models**: Contains entity models used throughout the application.
- **Forms**: Contains Windows Forms for the user interface.

## Acknowledgements

- Zebra Technologies for the printer SDK and Zebra ZD500R printer.
- Microsoft for the .NET Framework and Entity Framework.
