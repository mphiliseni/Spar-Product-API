
<img width="1436" alt="Screenshot 2025-05-06 at 17 29 22" src="https://github.com/user-attachments/assets/fe53688d-5546-4e72-a354-02c4a2130e3d" />

---

# Spar-Product-API

Welcome to the **Spar Product API**, a robust backend service for managing and interacting with product data for Spar stores. This API is built entirely in **C#** and designed to provide seamless integration with other systems for product management.

## Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Running the API](#running-the-api)
- [API Endpoints](#api-endpoints)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)

---

## Overview

The **Spar Product API** serves as a centralized system to manage products for Spar stores. It is built with scalability and performance in mind, making it easy to integrate with other applications or platforms.

## Features

- **Product Management**: Create, update, delete, and retrieve product information.
- **Search and Filter**: Search products by name, category, or other attributes.
- **Secure API**: Built-in authentication and authorization to protect sensitive data.
- **Scalable Design**: Modular architecture for seamless scalability.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed on your machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other supported database
- [Git](https://git-scm.com/)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/mphiliseni/Spar-Product-API.git
   cd Spar-Product-API
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Set up the database:
   - Update the `appsettings.json` file with your database connection string.
   - Apply migrations to create the database schema:
     ```bash
     dotnet ef database update
     ```

### Running the API

1. Start the development server:
   ```bash
   dotnet run
   ```

2. The API will be available at `https://localhost:5001` or `http://localhost:5000`.

## API Endpoints

Below are some of the key API endpoints:

- **GET /api/products**: Retrieve a list of products.
- **GET /api/products/{id}**: Retrieve a specific product by ID.
- **POST /api/products**: Add a new product.
- **PUT /api/products/{id}**: Update an existing product.
- **DELETE /api/products/{id}**: Delete a product.

For detailed documentation, refer to the Swagger UI available at `https://localhost:5001/swagger`.

## Technologies Used

- **Language**: C#
- **Framework**: ASP.NET Core
- **Database**: SQL Server or other supported databases
- **ORM**: Entity Framework Core

## Contributing

We welcome contributions to the **Spar Product API**! To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -m 'Add some feature'`).
4. Push the branch (`git push origin feature-name`).
5. Open a Pull Request.

## License

This project is licensed under the [MIT License](LICENSE).

---
