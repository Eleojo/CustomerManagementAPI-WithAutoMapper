# CustomerManagementAPI-WithAutoMapper

An ASP.NET Core API for managing customer records, featuring AutoMapper for seamless DTO to model mappings.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)

## Introduction

This project is an ASP.NET Core API designed for managing customer records. It includes features for adding, updating, deleting, and retrieving customer details. The implementation leverages AutoMapper for efficient and maintainable DTO to model mappings, ensuring a clean separation of concerns and easy data transformations.

## Features

- Add new customers
- Retrieve all customers
- Get customer details by ID
- Update customer details
- Soft delete customers
- Hard delete customers
- AutoMapper integration for DTO and model mappings
- Structured logging with Serilog and Seq

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/CustomerManagementAPI-WithAutoMapper.git
   ```

2. Navigate to the project directory:
   ```bash
   cd CustomerManagementAPI-WithAutoMapper
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the project:
   ```bash
   dotnet run
   ```

## Usage

1. Open your preferred API testing tool (e.g., Postman, cURL).
2. Use the following base URL for your API requests:
   ```
   https://localhost:5001/api/v1/Customers
   ```

## API Endpoints

### Add Customer

- **URL:** `POST /api/v1/Customers/AddCustomer`
- **Request Body:**
  ```json
  {
      "name": "John Doe",
      "email": "john.doe@example.com",
      "password": "password123"
  }
  ```
- **Response:**
  - `200 OK` if successful
  - `409 Conflict` if email already exists

### Get All Customers

- **URL:** `GET /api/v1/Customers/GetAllCustomers`
- **Response:**
  - `200 OK` with a list of customers

### Get Customer Detail

- **URL:** `GET /api/v1/Customers/GetCustomerDetail/{customerId}`
- **Response:**
  - `200 OK` with customer details
  - `404 Not Found` if customer does not exist

### Update Customer Details

- **URL:** `PUT /api/v1/Customers/Update-Customer/{customerId}`
- **Request Body:**
  ```json
  {
      "name": "Jane Doe",
      "email": "jane.doe@example.com",
      "password": "newpassword123"
  }
  ```
- **Response:**
  - `200 OK` if successful
  - `404 Not Found` if customer does not exist

### Soft Delete Customer

- **URL:** `DELETE /api/v1/Customers/Soft-Delete/{customerId}`
- **Response:**
  - `204 No Content` if successful
  - `404 Not Found` if customer does not exist

### Hard Delete Customer

- **URL:** `DELETE /api/v1/Customers/HardDelete/{customerId}`
- **Response:**
  - `204 No Content` if successful
  - `404 Not Found` if customer does not exist

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or additions.


Make sure to replace `your-username` with your actual GitHub username in the repository URL. This README provides a comprehensive overview of the project, its features, installation instructions, usage examples, and API endpoints.
