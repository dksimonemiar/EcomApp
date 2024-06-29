## E-commerce Product Reviews API

This project is a backend API for managing product reviews in an e-commerce application. It provides endpoints to retrieve and create reviews for products, following RESTful principles.

**Features**

> **GET /api/products/{productId}/reviews** \
> Retrieves all reviews for a specific product. \

> **POST /api/products/{productId}/reviews** \
> Adds a new review for a specific product. \
> Accepts review content and rating in the request body. \
> Returns the newly created review object.

**Technologies Used**

- Language: C#
- Framework: ASP.NET Core 
- Database: In-memory

## Setup Instructions

To run this project locally, follow these steps:

### 1. Clone the repository

```bash
git clone https://github.com/dksimonemiar/EcomApp.git
cd EcomApp
```
### 2. Clone the repository

```bash
dotnet restore
```

### 3. Run the project

```bash
dotnet run
```