# Car Renting System

A console-based application for managing car rentals, built with C#. The system allows users to view available cars, rent and return vehicles, and includes an admin interface for managing the car inventory. This project demonstrates object-oriented programming concepts like encapsulation, inheritance, and abstraction.

## Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Future Improvements](#future-improvements)
- [Contributing](#contributing)
- [License](#license)

## Features
- **User Interface**: View available cars, rent cars, and return cars.
- **Admin Interface**: Add and remove cars from the system.
- **Random Customer ID Generation**: Each customer receives a unique ID upon registration.
- **Object-Oriented Design**: Code structured using OOP principles for easy scalability and maintenance.

## Getting Started

### Prerequisites
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with .NET installed.
- Basic knowledge of C# and Git.

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/CarRentingSystem.git
2. Open the project in Visual Studio 2022.
3. Build the solution to install dependencies and set up the environment.

## Project Structure
  ```bash
 CarRentingSystem/
│
├── Models/                     # Core data classes
│   ├── Car.cs                  # Car model with properties like Brand, Model, Year, and Price
│   └── Customer.cs             # Customer model with ID and basic details
│
├── Management/                 # Admin functionalities
│   └── Admin.cs                # Admin actions for adding/removing cars
│
└── Services/                   # Application services
    └── CarRentalSystem.cs      # Manages car rental operations
```

## Usage
1. **Run the Application**:
   - Start the application from Visual Studio by pressing **F5** or **Run**.
2. **Using the System**:
   - **User Menu**: Choose options to view available cars, rent, or return a car.
   - **Admin Menu**: Add or remove cars (accessed by authorized users only).

### Sample Code
Here’s an example of how to find a car in the system:
```csharp
public Car FindCar(string brand, string model)
{
    return cars.FirstOrDefault(car => car.Brand == brand && car.Model == model);
}
