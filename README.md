# 📦 Inventory Management System

An **ASP.NET Core MVC** based Inventory Management System that manages
**Products, Categories, Suppliers, and Stock Transactions** using a
clean **CRUD architecture** and **Repository pattern**.

---

## 🚀 Features

- Product CRUD (Create, Read, Update, Delete)
- Category → Product (1 : Many)
- Supplier → Product (1 : Many)
- Product → StockTransaction (1 : Many)
- ASP.NET Core MVC architecture
- Repository pattern for data access
- SQL relational database design
- Razor Views
- Server-side validation

---

## 🏗️ Tech Stack

- .NET 7 / .NET 8
- ASP.NET Core MVC
- Entity Framework Core / Repository Pattern
- SQL Server / MySQL
- Razor Pages
- Bootstrap (optional for UI)

---

## 📂 Project Structure

InventoryManagmentSystem
│
├── Controllers
│ └── ProductController.cs
│
├── Models
│ ├── Product
│ │ └── Product.cs
│ ├── Category.cs
│ ├── Supplier.cs
│ └── ErrorViewModel.cs
│
├── Repository
│ └── ProductRepository.cs
│
├── Views
│ └── Product
│ ├── Index.cshtml
│ ├── Details.cshtml
│ ├── Create.cshtml
│ ├── Edit.cshtml
│ └── Delete.cshtml
│
├── appsettings.json
└── Program.cs




---

## 🧩 Database Relationships

- Category **1 → \*** Product
- Supplier **1 → \*** Product
- Product **1 → \*** StockTransaction

---

## 🔄 CRUD Operations (Product)

| Action | Method | URL |
|------|--------|-----|
List Products | GET | `/Product/Index`
View Details | GET | `/Product/Details/{id}`
Create Product | GET / POST | `/Product/Create`
Edit Product | GET / POST | `/Product/Edit/{id}`
Delete Product | GET / POST | `/Product/Delete/{id}`

---

## 🧪 Sample Product Model

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public int CategoryId { get; set; }
    public int SupplierId { get; set; }

    public string? Description { get; set; }
}
