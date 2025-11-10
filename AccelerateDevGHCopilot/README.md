# Emergency Library Management System

A temporary .NET-based console application developed for a local community library after their backend systems were lost in a fire. This solution helps library staff manage their operations until a permanent system can be implemented.

## Current Features

- **Patron Management**
  - Search for patrons by name
  - View patron details and membership status
  - Renew patron memberships
  - Track patron loan history

- **Loan Management**
  - View loan details including due dates
  - Extend loan periods
  - Process book returns
  - Track book status (loaned/returned)

## Planned Features

1. **Book Availability (In Development)**
   - Check if a book is available for loan
   - Display return due date for books currently on loan
   - Quick status lookup for librarians

2. **Book Loans (Upcoming)**
   - Process new book loans for patrons
   - Update loan records in real-time
   - Display updated patron loan details

3. **Book Reservations (Future)**
   - Reserve books for patrons
   - Manage reservation queue
   - Notify when reserved books become available

- **Book Management**
  - Track book inventory
  - Link books to authors
  - Manage individual book items

## Project Background

This application was developed as an emergency response to help our local community library continue operations after losing their backend systems in a fire. The development team chose to use GitHub Copilot to accelerate the development process and deliver a working solution quickly.

## Development Workflow

1. Feature branches are created for each new functionality
2. GitHub Copilot is used to assist with code implementation
3. Code is reviewed and tested before merging
4. Features are merged into main branch when complete

## Project Structure

- **Library.ApplicationCore**
  - Core business logic and entities
  - Service interfaces and implementations
  - Domain models (Book, Patron, Loan)

- **Library.Infrastructure**
  - Data access implementation
  - JSON file-based persistence
  - Repository implementations

- **Library.Console**
  - Console-based user interface
  - State management
  - User input handling

## Technical Details

- Built with .NET 9.0
- Uses dependency injection for loose coupling
- Repository pattern for data access
- JSON-based data storage
- Clean architecture principles

## Getting Started

1. Clone the repository
2. Ensure .NET 9.0 SDK is installed
3. Navigate to the solution directory
4. Run the application:
   ```powershell
   dotnet run --project src/Library.Console/Library.Console.csproj
   ```

## Usage

1. **Search for Patrons**
   - Enter patron name or partial name
   - Select from matching results

2. **Manage Patron Details**
   - View membership status
   - Renew membership
   - View loan history

3. **Handle Loans**
   - View loan details
   - Extend loan periods
   - Process returns

## Data Storage

The application uses JSON files for data persistence:
- `Authors.json`: Author information
- `Books.json`: Book metadata
- `BookItems.json`: Individual book copies
- `Patrons.json`: Patron information
- `Loans.json`: Loan records

## Architecture

The solution follows clean architecture principles with clear separation of concerns:
- Domain entities in ApplicationCore
- Business logic in services
- Data access in Infrastructure layer
- UI concerns isolated in Console project