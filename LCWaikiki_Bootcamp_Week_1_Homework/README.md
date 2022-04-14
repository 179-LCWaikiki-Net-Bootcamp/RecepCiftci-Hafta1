### **LC WAIKIKI .Net Bootcamp 1st Week Homework**

Project is sample product endpoint Web API.

>Available Endpoints are:


|HTTP|METHOD|RETURNS|DESCRIPTION|
|---|---|---|---|
|GET| GetProducts | `List<Product>` | Get All Products 
|GET| GetProductById | `Product` | Get Product By ID 
|GET| GetProductsByPage | `List<Product>` | Get Products By Page 
|POST| AddProduct | `Insertion info message` | Insert Product 
|PUT| UpdateProduct | `Update info message` | Update Product 
|DELETE| DeleteProduct | `Delete info message` | Delete Product 

------------------

> How To Run

After forking the repo to your local machine, just run `dotnet run` command at the root of project.

------------------

>Used Packages:

- **FluentValidation.DependencyInjectionExtensions** Version="10.4.0"
- **Microsoft.EntityFrameworkCore** Version="6.0.4"
- **Swashbuckle.AspNetCore Version**="6.2.3"
- ** FluentValidation.AspNetCore**" Version="10.4.0"
- **AutoMapper.Extensions.Microsoft.DependencyInjection** "Version="11.0.0"
- **MediatR.Extensions.Microsoft.DependencyInjection** "Version="10.0.1"

------------------



Project uses MediatR library with CQRS Design Pattern.

Results for all endpoints are the same regardless. Every response contains `data` and `errors`. Only one of them can contain data per request. This provides consistency for accessing to the API.

------------------

 `[GET] api/products` --> Result of **GET** request
```
{
  "data": [
    {
      "id": 1,
      "name": "Blue Jean",
      "stock": 30,
      "category": "Jean",
      "color": "Blue",
      "price": 199.99
    },
    {
      "id": 2,
      "name": "Green Men Shirt",
      "stock": 70,
      "category": "Shirt",
      "color": "Green",
      "price": 89.99
    }
  ],
  "errors": null
}
```

------------------

 `[GET] api/products/1` --> Result of **GET BY ID** request
 ```
{
  "data": {
    "id": 1,
    "name": "Blue Jean",
    "stock": 30,
    "category": "Jean",
    "color": "Blue",
    "price": 199.99
  },
  "errors": null
}
```
------------------
`[POST] api/products` --> Result of **POST** request
>Input

```
{
  "name": "Sneaker",
  "stock": 30,
  "categoryId": 4,
  "color": "Gray",
  "price": 399.99
}
```
> Output

```
{
  "data": "Sneaker product saved to database",
  "errors": null
}
```
------------------
> Other endpoints work as expected. Tested locally without any additional setup. 
(.Net will download required packages when building the project for the first time)

------------------

>Folder Structure

- **`Controllers`**
> Contains Controllers that define endpoints and send MediatR Requests.
- **`Core`**
> Contains InMemoryDatabase context and dummy data generator
- **`DBOperations`**
> Contains **Commands** and **Queries** for **CQRS** Design Pattern
- **`DTOs`**
> Contains Data Transfer Objects
- **`Mappers`**
> Contains AutoMapper definitons
- **`Middlewares`**
> Contains Global Logger and Exception Handler Middleware
- **`Models`**
> Contains Models that used in defining objects
- **`Repositories`**
> Contains main functions that do the database queries and commands 
- **`Services`**
> Contains FluentValidation Service Register Class
- **`Validators`**
> Contains Validator classes for user input objects
