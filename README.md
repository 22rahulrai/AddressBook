# Address Book System

This project implements an Address Book system where users can manage contact information. The system supports multiple use cases such as adding, editing, deleting, searching, and viewing contact details. It allows storing and managing contact data using various storage systems such as File I/O, CSV, JSON, Database, and Cloud servers. It also incorporates multi-threading for efficient handling of I/O and network operations.

## Table of Contents
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Use Cases](#use-cases)
- [Setup Instructions](#setup-instructions)
- [Usage](#usage)
- [Git Branching Strategy](#git-branching-strategy)
- [Code Quality](#code-quality)
- [Contributing](#contributing)

## Technologies Used
- **Programming Language**: C#
- **IDEs**: Visual Studio
- **File Storage**: CSV, JSON, Database
- **Cloud Storage**: Cloud Server (specific service to be defined)
- **Multi-threading**: Used for efficient I/O and network calls
- **Libraries**: OpenCSV, GSON, RESTAssured.NET

## Features
- **Add Contacts**: Users can add a new contact with details like first name, last name, address, city, state, zip, phone number, and email.
- **Edit Contacts**: Modify an existing contact by name.
- **Delete Contacts**: Delete a contact using their name.
- **Multiple Address Books**: Create and manage multiple address books, each with a unique name.
- **Duplicate Entry Check**: Prevent duplicate entries in an address book.
- **Search Contacts**: Search contacts by city, state, or across multiple address books.
- **Sorting**: Sort contacts alphabetically by name or by city, state, or zip.
- **Data Persistence**: Save and load contact information to/from files, CSV, JSON, and databases.
- **Cloud Integration**: Ability to upload and retrieve data from a cloud server.
- **Multi-threaded I/O**: Perform file and network I/O operations without blocking the main thread.
- **Database Integration**: Store contact data in a relational database.
- **File I/O**: Implemented using C# File I/O for local storage.

## Use Cases

### UC1: Ability to Add a New Contact
- Adds a new contact with details such as first name, last name, address, etc.

### UC2: Ability to Edit Existing Contact
- Edits a contact using the person's name.

### UC3: Ability to Delete a Contact
- Deletes a contact by name.

### UC4: Add Multiple Contacts
- Adds multiple contacts one by one to the address book.

### UC5: Manage Multiple Address Books
- Each address book can be given a unique name and can hold multiple contacts.

### UC6: Prevent Duplicate Entries
- Ensures no duplicate entries are added to any address book.

### UC7: Search Contacts in a City or State
- Allows searching for contacts in a particular city or state.

### UC8: View Contacts by City or State
- Displays contacts grouped by city or state.

### UC9: Get the Number of Contacts by City or State
- Displays a count of contacts in a particular city or state.

### UC10: Sort Contacts Alphabetically by Name
- Sorts contacts alphabetically by name.

### UC11: Sort Contacts by City, State, or Zip
- Sorts contacts by city, state, or zip code.

### UC12: Read/Write Address Book from/to File
- Allows reading and writing the address book using File I/O.

### UC13: Read/Write Address Book as CSV
- Supports importing/exporting address book data in CSV format using OpenCSV.

### UC14: Read/Write Address Book as JSON
- Supports importing/exporting address book data in JSON format using GSON.

### UC15: Interact with JSON Server
- Allows reading and writing address book data to a JSON server using RESTAssured.NET.

### UC16: Multi-threaded I/O Operations
- Ensures non-blocking I/O operations during CRUD operations on files, CSV, JSON, or cloud servers.

### UC17: Save Address Book to Database
- Supports saving address book data to a database and ensures the Open/Close principle for extensibility.

### UC18: Thank You Message
- Displays a thank you message after the user completes the task.

## Setup Instructions
### Prerequisites:
- **Visual Studio** or another C# IDE.
- **.NET Core/Framework** installed.
- **SQL Server** or a relational database for database functionality (optional, if you plan to use the database functionality).
- **Cloud Account** (optional for Cloud Server integration).

### Clone the Repository
```bash
git clone https://github.com/your-username/address-book.git
