### **LC WAIKIKI .Net Bootcamp 2nd Week Homework**

Project is sample product endpoint Web API.

>Available Endpoints are:

**FOR FOOD**

|HTTP|RETURNS(Successful)|DESCRIPTION|
|---|---|---|
|GET| `List<FoodViewModel>`|Get All Foods|
|GET |`FoodViewModel`|Get Food By ID|
|GET |`List<FoodViewModel>`|Get Foods By Search|
|POST |`201 status`|Insert Food|
|PUT |`204 status`|Update Food|
|DELETE |`204 status`|Delete Food|
---
** FOR INGREDIENT**

|HTTP|RETURNS(Successful)|DESCRIPTION|
|---|---|---|
|GET| `List<IngredientViewModel>`|Get All Ingredients|
|GET |`IngredientViewModel`|Get Ingredient By ID|
|GET |`List<IngredientViewModel>`|Get Ingredients By Search|
|POST |`201 status`|Insert Ingredient|
|PUT |`204 status`|Update Ingredient|
|DELETE |`204 status`|Delete Ingredient|

------------------

> How To Run

Fork this repo to your local repository.

You should install MS SQL Server for running this application.
In the `appsettings.json`, you can change the **Catalog** variable for creating Database in different name.

```
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=.;Initial Catalog=RestaurantDB; Integrated Security=true"
  }
```

This project use Code-First approach, for starting run these command in order.

 1. `Add-Migration Initial` --> You can change the **Initial** it is just migration name
 2. `Update-Database`

Now database created.

Run `dotnet run` command at the root of project.
Now you can use every endpoint available from either Postman API or Swagger Interface

------------------

>Used Packages:

	  <PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="10.4.0" />
	  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.4">
	    <PrivateAssets>all</PrivateAssets>
	    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
	  </PackageReference>
	  <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.4" />
	  <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.4">
	    <PrivateAssets>all</PrivateAssets>
	    <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
	  </PackageReference>
	  <PackageReference Include="Swashbuckle.AspNetCore" Version="6.2.3" />
	  <PackageReference Include="FluentValidation.AspNetCore" Version="10.4.0" />
	  <PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="11.0.0" />
	  <PackageReference Include="MediatR.Extensions.Microsoft.DependencyInjection" Version="10.0.1" />

------------------

Project uses **MediatR** library with **CQRS** Design Pattern and **Generic Repository Pattern**.

Results for all endpoints are the same regardless. Every response contains `data` and `errors`. Only one of them can contain data per request. This provides consistency for accessing to the API.

------------------

 `[GET] api/products` --> Result of **GET** request for **Foods** endpoint 
```
{
  "data": [
    {
      "id": 3,
      "name": "Kebap",
      "description": "Adana Kebap",
      "price": 0,
      "categoryId": 0,
      "ingredients": [
        {
          "id": 1,
          "name": "Kıyma",
          "description": "Kuzu etinden",
          "categoryId": 0
        },
        {
          "id": 2,
          "name": "Domates",
          "description": "Çanakkale Domatesi",
          "categoryId": 4
        }
      ]
    },
    {
      "id": 4,
      "name": "Mantı",
      "description": "Kayseri",
      "price": 12,
      "categoryId": 3,
      "ingredients": [
        {
          "id": 1,
          "name": "Kıyma",
          "description": "Kuzu etinden",
          "categoryId": 0
        },
        {
          "id": 2,
          "name": "Domates",
          "description": "Çanakkale Domatesi",
          "categoryId": 4
        }
      ]
    }
  ],
  "errors": null
}
```

------------------

 `[GET] api/products/1` --> Result of **GET BY ID** request for **INGREDIENTS** endpoint
 ```
{
  "data": {
    "id": 1,
    "name": "Kıyma",
    "description": "Kuzu etinden",
    "categoryId": 0
  },
  "errors": null
}
```
------------------
`[POST] api/products` --> Result of **POST** request
>Input

```
{
  "entity": {
    "name": "string",
    "description": "string",
    "categoryId": 1,
    "price": 0,
    "ingredientIds": [
      1
    ]
  }
}
```
> Output

```
{
  "data": {},
  "errors": null
}
201 returned
```
------------------
> Other endpoints work as expected. Tested locally without any additional setup. 
(.Net will download required packages when building the project for the first time)

------------------