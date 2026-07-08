<p align="center">
  <a href="https://github.com/gomezabajo/Good-Eating">
    <img src="https://www.gomezabajo.es/pablo/images/good-eating.png" width="120" height="120" alt="Good-Eating logo" />
  </a>
</p>

<h1 align="center">Good-Eating</h1>

<p align="center"><i>An adaptive food recommendation system for people on special diets</i></p>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stars][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

## Overview

**Good-Eating** is a web-based system that generates personalized daily menu recommendations adapted to each user's dietary needs. Users complete a guided questionnaire describing their personal profile and constraints, and the system builds a dietary model that is used to filter ingredients and dishes, producing menus that are safe and suitable for them.

The dietary model takes into account:

- **Personal profile**: gender, age range, height, weight, number of daily meals, country of origin.
- **Health conditions**: diabetes, high cholesterol, hepatic, renal, pancreatic, biliary, gastric ulcer, colitis, and other intestinal conditions.
- **Intolerances and restrictions**: lactose intolerance, among others.
- **Cultural and religious constraints** that affect permitted foods.
- **Food preferences**: fine-grained likes/dislikes for individual fruits and vegetables (banana, cherry, fig, spinach, asparagus, chard, etc.).

Based on this model, the recommendation engine dynamically builds queries over an ingredient and dish database, excluding anything incompatible with the user's profile, and composes daily menus accordingly.

## Features

- **User portal** (`web/user/`): registration, login, a five-step dietary questionnaire (`CuestionarioA`–`CuestionarioE`), dietary profile modelling (`Modelado`), gastronomic preferences, and personalized menu visualization.
- **Admin panel** (`web/admin/`): management of the catalog of ingredients, dishes, dish types, food families, menus, and users.
- **Recommendation engine** (`App_Code/cscode/Recomendacion.cs`): translates the user's dietary model into SQL filters over the ingredient database to produce adapted menus.
- **Activity logging** and email notification support.

## Architecture and technologies

| Layer | Technology |
|---|---|
| Web application | ASP.NET Web Forms (C#), .NET Framework 3.5 |
| Database | MySQL, accessed via MySQL ODBC driver |
| Front end | HTML, CSS, JavaScript (includes TinyMCE editor and Epoch calendar components) |

The database schema (`database/goodeating.sql`) defines the following main tables: `VN_USER`, `VN_MODELLING` (the user's dietary model), `VN_INGREDIENT`, `VN_DISH`, `VN_TYPE_DISH`, `VN_FAMILY`, `VN_MENU`, `VN_AGES`, `VN_COUNTRIES`, and `VN_LOG`.

## Repository structure

```
Good-Eating/
├── database/
│   └── goodeating.sql        # MySQL database dump (schema + seed data)
└── web/
    ├── default.htm           # Landing page
    ├── web.config
    ├── user/                 # User-facing portal (registration, questionnaires, menus)
    │   └── App_Code/cscode/  # Domain classes and recommendation logic
    ├── admin/                # Administration panel
    ├── css/                  # Stylesheets and images
    ├── menu/                 # Horizontal menu component
    ├── epoch_v202_es/        # Epoch calendar component (Spanish localization)
    └── tiny_mce/             # TinyMCE rich text editor
```

## Installation

### Prerequisites

- Windows with IIS and .NET Framework 3.5 (or Visual Studio with ASP.NET Web Site support)
- MySQL Server (tested with MySQL 5.6)
- [MySQL ODBC Driver](https://dev.mysql.com/downloads/connector/odbc/) (the application uses the `MySQL ODBC 5.1 Driver` by default)

### Steps

1. **Clone the repository**

   ```bash
   git clone https://github.com/gomezabajo/Good-Eating.git
   ```

2. **Create the database**

   Import the provided dump into your MySQL server:

   ```bash
   mysql -u <user> -p < database/goodeating.sql
   ```

3. **Configure the connection string**

   Edit the `<connectionStrings>` section in `web/user/web.config` and `web/admin/web.config`, replacing the placeholders with your MySQL server, port, database name, and credentials:

   ```xml
   <connectionStrings>
     <add name="ConnectionString"
          connectionString="DRIVER={MySQL ODBC 5.1 Driver}; SERVER=your-server; PORT=3306; DATABASE=goodeating_db; UID=your-user; PASSWORD=your-password;"/>
   </connectionStrings>
   ```

4. **Deploy the web application**

   Deploy the `web/` folder as an IIS web site (or open it as a Web Site in Visual Studio) and browse to `default.htm`.

5. **Use the system**

   - Register as a new user and complete the dietary questionnaire to receive adapted menus.
   - Access the administration panel under `/admin` to manage ingredients, dishes, and menus.


## Contributors

Developed by **Pablo Gómez-Abajo** of the [miso research group](http://www.miso.es/), Universidad
Autónoma de Madrid.

- Email: <Pablo.GomezA@uam.es>
- GitHub: [@gomezabajo](https://github.com/gomezabajo)
- LinkedIn: <https://www.linkedin.com/in/gomezabajo>

## License

Distributed under the **Eclipse Public License 2.0 (EPL-2.0)**. See [`LICENSE`](LICENSE) for
details.

Copyright (c) 2026 [Universidad Autónoma de Madrid](https://www.uam.es/).

Note: TinyMCE and Epoch are third-party components with their own licenses.

[contributors-shield]: https://img.shields.io/github/contributors/gomezabajo/Good-Eating
[contributors-url]: https://github.com/gomezabajo/Good-Eating/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/gomezabajo/Good-Eating
[forks-url]: https://github.com/gomezabajo/Good-Eating/network/members
[stars-shield]: https://img.shields.io/github/stars/gomezabajo/Good-Eating
[stars-url]: https://github.com/gomezabajo/Good-Eating/network/stargazers
[issues-shield]: https://img.shields.io/github/issues/gomezabajo/Good-Eating
[issues-url]: https://github.com/gomezabajo/Good-Eating/issues
