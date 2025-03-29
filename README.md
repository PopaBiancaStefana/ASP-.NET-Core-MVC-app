<!-- Tags: #project #asp.netcore #mvc #web -->
<div align="center">

  <h1>PieShop - ASP.NET Core MVC app</h1>

<!-- Badges -->
<p>
  <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/graphs/contributors">
    <img src="https://img.shields.io/github/contributors/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" alt="contributors" />
  </a>
  <a href="">
    <img src="https://img.shields.io/github/last-commit/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" alt="last update" />
  </a>
  <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/network/members">
    <img src="https://img.shields.io/github/forks/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" alt="forks" />
  </a>
  <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/stargazers">
    <img src="https://img.shields.io/github/stars/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" alt="stars" />
  </a>
  <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/issues/">
    <img src="https://img.shields.io/github/issues/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" alt="open issues" />
  </a>
</p>

<h4>
  <span> · </span>
    <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/issues/">Report Bug</a>
  <span> · </span>
    <a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/issues/">Request Feature</a>
  </h4>
</div>

<br />

## :star2: App requirements:
> **⚠️ Note:** Not intended to implement all, because I am not focusing on the frontend part.

<ul style="list-style: none; padding-left: 0;">
  <li>
    <input type="checkbox" id="pie-shop" name="pie-shop" checked>
    <label for="pie-shop">Pie Shop Landing Page</label>
  </li>
  <li>
    <input type="checkbox" id="shopping-cart" name="shopping-cart">
    <label for="shopping-cart">Shopping cart</label>
  </li>
  <li>
    <input type="checkbox" id="checkout-form" name="checkout-form">
    <label for="checkout-form">Checkout form</label>
  </li>
  <li>
    <input type="checkbox" id="interactive-search-page" name="interactive-search-page">
    <label for="interactive-search-page">Interactive search page</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Authentication</label>
  </li>
</ul>

## :toolbox: Tasks:

<ul style="list-style: none; padding-left: 0;">
  <li>
    <input type="checkbox" id="checkout-form" name="checkout-form" checked>
    <label for="checkout-form">Configure MVC project</label>
  </li>
  <li>
    <input type="checkbox" id="checkout-form" name="checkout-form" checked>
    <label for="checkout-form">Models, Mock Repositories, and Controllers</label>
  </li>
  <li>
    <input type="checkbox" id="pie-shop" name="pie-shop" checked>
    <label for="pie-shop">Adding EF Core, Migrations and Seed data</label>
    <ul>
      <li>Install Microsoft.EntityFrameworkCore.Tools and ...SqlServer packeges</li>
      <li>Create Database Context</li>
      <li>Add Connection String</li>
      <li>Register the Context</li>
      <li>Add Repositories</li>
      <li>Create Migration and Database</li>
      <li>Add Seed Data</li>
    </ul>
  </li>
  <li>
    <input type="checkbox" id="interactive-search-page" name="interactive-search-page" checked>
    <label for="interactive-search-page">Views, Routes and Navigation</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Unit Tests - Controllers</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">ASP.NET Core RESTful API, API Responses</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Try Blazor</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Add Authentication and Authorization</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Deploy to an Azure App Service</label>
  </li>
  <li>
    <input type="checkbox" id="authentication" name="authentication">
    <label for="authentication">Try .NET Aspire</label>
  </li>
</ul>

<!-- Screenshots -->
<!-- ### :camera: Screenshots

<div align="center">
  <img src="https://placehold.co/600x400?text=Your+Screenshot+here" alt="screenshot" />
</div> -->

## :open_book: Patterns

<ul>
  <li>MVC</li>
  <li>Dependency Injection</li>
  <li>Repository</li>
  <li>Middleware</li>
</ul>


<!-- TechStack -->
## :space_invader: Tech Stack

<details open>
  <summary>Server</summary>
  <ul>
    <li>.NET 8</li>
    <li>ASP.NET Core MVC</li>
    <li>APIs & Minimal APIs</li>
    <li>Entity Framework</li>
    <li>Identity Framework</li>
  </ul>
</details>

<details open>
  <summary>Client</summary>
  <ul>
    <li>Javascript</li>
    <li>HTML&CSS</li>
    <li>Ajax, JQuery</li>
    <li>Razor Pages</li>
    <li>Blazor</li>
  </ul>
</details>

<details open>
<summary>Database</summary>
  <ul>
    <li>SQL Server</li>
  </ul>
</details>

<details open>
<summary>DevOps</summary>
  <ul>
    <li>Azure</li>
  </ul>


</br>

- IDE - Visual Studio 202

<!-- ## :gear: Installation -->


<!-- ## :test_tube: Running Tests

To run tests, run the following command

```bash
  ...
``` -->

## :running: Run Locally

###Go to the project directory

```bash
cd .\PieShop\
```

### Start the application

```bash
dotnet run
```

### Create the Database using Migrations
`Through Package Manager Console from Visual Studio`

```bash
add-migration <MigrationName>
update-database
```

<!-- Start using application with Azure -->

<!-- ```bash
  ...
``` -->


<!-- Contributing -->

## :wave: Contributing

<a href="https://github.com/PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=PopaBiancaStefana/ASP.NET-Core-MVC-Pie-Shop" />
</a>