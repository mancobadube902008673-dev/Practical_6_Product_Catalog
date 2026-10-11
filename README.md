# Practical 6: Product Catalog Application using ASP.NET Core MVC

## AIM
Create Product Catalog Application using ASP.NET MVC Architecture (Controllers, Models, Views, Routing).

## Requirements
- Visual Studio 2026
- ASP.NET Core Web App (Model-View-Controller) template
- .NET 8 SDK or another installed supported .NET version (adjust TargetFramework if needed)

## Run
1. Open `Practical_6_Product_Catalog.csproj` in Visual Studio.
2. Restore/build the project.
3. Press F5 or Ctrl+F5.
4. The default route opens the Products/Index action.
5. Select **View details** on a product to open its details page.

## MVC components
- Model: `Models/Product.cs` defines product data.
- Controller: `Controllers/ProductsController.cs` supplies sample products and handles Index/Details actions.
- Views: `Views/Products/Index.cshtml` and `Details.cshtml` display the catalog and product details.
- Routing: `Program.cs` maps the default route to `Products/Index`.

## Note
This practical uses sample in-memory data; it does not require a database. `Output_sample.png` is a designed sample of the expected catalog appearance, not a screenshot captured from a running browser.

## Product images
The catalog uses local image assets in `wwwroot/images/` for Laptop, Headphones, Smartphone, and Backpack. These images are included in the ZIP and work without an internet connection.
