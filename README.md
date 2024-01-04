<div align="center">
<h1>
   <img src="https://img.icons8.com/pulsar-color/96/markdown.png" width="100" height="100" />
   <br>
   CRIMINAL-LAWYER-RECOMMENDATION-SYSTEM
</h1>
<h3>◦ Criminal Justice, Simplified.</h3>
<h3>◦ Developed with the software and tools below.</h3>

<p align="center">
<img src="https://img.shields.io/badge/ScrollReveal-FFCB36.svg?style=flat&logo=ScrollReveal&logoColor=black" alt="ScrollReveal">
<img src="https://img.shields.io/badge/JavaScript-F7DF1E.svg?style=flat&logo=JavaScript&logoColor=black" alt="JavaScript">
<img src="https://img.shields.io/badge/HTML5-E34F26.svg?style=flat&logo=HTML5&logoColor=white" alt="HTML5">
<img src="https://img.shields.io/badge/Sass-CC6699.svg?style=flat&logo=Sass&logoColor=white" alt="Sass">
<img src="https://img.shields.io/badge/Axios-5A29E4.svg?style=flat&logo=Axios&logoColor=white" alt="Axios">

<img src="https://img.shields.io/badge/Vue.js-4FC08D.svg?style=flat&logo=vuedotjs&logoColor=white" alt="Vue.js">
<img src="https://img.shields.io/badge/ESLint-4B32C3.svg?style=flat&logo=ESLint&logoColor=white" alt="ESLint">
<img src="https://img.shields.io/badge/GitHub-181717.svg?style=flat&logo=GitHub&logoColor=white" alt="GitHub">
<img src="https://img.shields.io/badge/JSON-000000.svg?style=flat&logo=JSON&logoColor=white" alt="JSON">
<img src="https://img.shields.io/badge/Markdown-000000.svg?style=flat&logo=Markdown&logoColor=white" alt="Markdown">
</p>

![license](https://img.shields.io/github/license/kennysuper007/Criminal-Lawyer-Recommendation-System?style=flat&labelColor=E5E4E2&color=869BB3)
![repo-language-count](https://img.shields.io/github/languages/count/kennysuper007/Criminal-Lawyer-Recommendation-System?style=flat&labelColor=E5E4E2&color=869BB3)
![repo-top-language](https://img.shields.io/github/languages/top/kennysuper007/Criminal-Lawyer-Recommendation-System?style=flat&labelColor=E5E4E2&color=869BB3)
![last-commit](https://img.shields.io/github/last-commit/kennysuper007/Criminal-Lawyer-Recommendation-System?style=flat&labelColor=E5E4E2&color=869BB3)
</div>

---

## 🔗 Quick Links
- [🔗 Quick Links](#-quick-links)
- [📍 Overview](#-overview)
- [📂 Repository Structure](#-repository-structure)
- [🧩 Modules](#-modules)
- [🚀 Getting Started](#-getting-started)
  - [⚙️ Installation](#️-installation)
  - [🤖 Running Criminal-Lawyer-Recommendation-System](#-running-criminal-lawyer-recommendation-system)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [👏 Acknowledgments](#-acknowledgments)

---

## 📍 Overview

The Criminal Lawyer Recommendation System is a web-based application that aims to help individuals find appropriate legal representation for criminal cases. By leveraging user-input information such as the type of crime, location, and budget, the system generates a list of recommended criminal lawyers. The application also provides detailed profiles of each recommended lawyer, including their experience, expertise, and client reviews. The project's value proposition lies in its ability to simplify and streamline the process of finding a suitable criminal lawyer, ultimately saving users time and effort in their search for legal support.

---

## 📂 Repository Structure

```sh
└── Criminal-Lawyer-Recommendation-System/
    ├── LawyerUpBackend/
    │   ├── LawyerUpBackend.API/
    │   │   ├── .config/
    │   │   ├── Controllers/
    │   │   ├── LawyerUpBackend.API.csproj
    │   │   ├── Program.cs
    │   │   ├── Properties/
    │   │   ├── appsettings.Development.json
    │   │   └── appsettings.json
    │   ├── LawyerUpBackend.Application/
    │   │   ├── ApplicationDependencyInjection.cs
    │   │   ├── Dtos/
    │   │   ├── Exceptions/
    │   │   ├── LawyerUpBackend.Application.csproj
    │   │   ├── Models/
    │   │   ├── Profiles/
    │   │   └── Services/
    │   ├── LawyerUpBackend.Core/
    │   │   ├── Common/
    │   │   ├── Entities/
    │   │   └── LawyerUpBackend.Core.csproj
    │   ├── LawyerUpBackend.DataAccess/
    │   │   ├── AppDbContext.cs
    │   │   ├── LawyerUpBackend.DataAccess.csproj
    │   │   ├── Repositiories/
    │   │   └── Startup.cs
    │   ├── LawyerUpBackend.sln
    ├── LawyerUpFrontend/
    │   ├── .browserslistrc
    │   ├── .eslintrc.js
    │   ├── babel.config.js
    │   ├── package-lock.json
    │   ├── package.json
    │   ├── public/
    │   │   └── index.html
    │   └── src/
    │       ├── App.vue
    │       ├── components/
    │       ├── main.js
    │       ├── pages/
    │       ├── plugins/
    │       └── store/

```

---

## 🧩 Modules

<details closed><summary>LawyerUpFrontend</summary>

| File                                                                                                                                     | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                      | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [babel.config.js](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/babel.config.js)     | The code snippet is part of the Criminal Lawyer Recommendation System repository. It is a Vue.js frontend application that uses babel for transpiling JavaScript code. The main file, babel.config.js, sets the preset for the babel plugin used in the application.                                                                                                                                                                                                                                                                                                                                 |
| [package-lock.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/package-lock.json) | The code snippet in the LawyerUpBackend.API directory is responsible for handling the API routes and controllers for the Criminal Lawyer Recommendation System. It provides the functionality to receive requests and send responses to clients.                                                                                                                                                                                                                                                                                                                                                     |
| [package.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/package.json)           | This code snippet is part of the Criminal Lawyer Recommendation System repository. It focuses on the LawyerUpFrontend directory, which contains the frontend code for the system. The code utilizes various dependencies and software, including Vue.js, Bootstrap Vue, Axios, Vuex, and more. The key files within this directory include App.vue, components, main.js, pages, plugins, and store.                                                                                                                                                                                                  |
| [.eslintrc.js](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/.eslintrc.js)           | This code snippet, located in `LawyerUpFrontend/.eslintrc.js`, defines the ESLint configuration for the LawyerUp Frontend application. It ensures code quality and enforces best practices by specifying rules for code formatting and debugging.                                                                                                                                                                                                                                                                                                                                                    |
| [.browserslistrc](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/.browserslistrc)     | The code snippet is part of the Criminal Lawyer Recommendation System repository. It is located in the LawyerUpBackend directory and is responsible for the backend application logic. The code achieves the functionality of connecting to a database, handling HTTP requests, and providing services for the frontend. The frontend, located in the LawyerUpFrontend directory, handles the user interface and relies on the backend for data retrieval and manipulation. The codebase uses various technologies and dependencies, including Vue.js for the frontend and.NET Core for the backend. |

</details>

<details closed><summary>LawyerUpFrontend.public</summary>

| File                                                                                                                              | Summary                                                                                                                                                                                                |
| ---                                                                                                                               | ---                                                                                                                                                                                                    |
| [index.html](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/public/index.html) | This code snippet is responsible for rendering the main HTML page of the LawyerUpFrontend application. It includes dependencies for animations and font styles. The page title is set to LawyerUP 找律師. |

</details>

<details closed><summary>LawyerUpFrontend.src</summary>

| File                                                                                                                     | Summary                                                                                                                                                                                                                                                                          |
| ---                                                                                                                      | ---                                                                                                                                                                                                                                                                              |
| [App.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/App.vue) | The code snippet in `App.vue` is responsible for rendering the main layout of the LawyerUpFrontend application, including the navigation bar and footer components. It sets up the structure of the app and imports the necessary components for display.                        |
| [main.js](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/main.js) | The code snippet in the `main.js` file of the LawyerUpFrontend directory sets up the routing and initializes the Vue application. It configures the routes for different pages and components, and also includes the necessary dependencies for the application to run properly. |

</details>

<details closed><summary>LawyerUpFrontend.src.plugins</summary>

| File                                                                                                                                               | Summary                                                                                                                                                                                                           |
| ---                                                                                                                                                | ---                                                                                                                                                                                                               |
| [bootstrap-vue.js](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/plugins/bootstrap-vue.js) | This code snippet sets up the front-end of the Criminal Lawyer Recommendation System using Vue.js and Bootstrap Vue plugin, providing a user-friendly interface with pre-styled components and responsive design. |

</details>

<details closed><summary>LawyerUpFrontend.src.components</summary>

| File                                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| ---                                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [NavBar.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/NavBar.vue)                     | The code snippet is a Vue.js component called `NavBar.vue` that represents the navigation bar of the LawyerUpFrontend application. It allows users to search for lawyers, navigate between pages, and access premium features. It also includes animations and styling for the navigation bar.                                                                                                                                                                        |
| [Title.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Title.vue)                       | The code snippet represents the Title component in the LawyerUpFrontend directory of the Criminal-Lawyer-Recommendation-System repository. It handles the visual display of the title and animations on the landing page of the frontend application.                                                                                                                                                                                                                 |
| [Pagination.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Pagination.vue)             | The code in `Pagination.vue` is a Vue.js component that provides pagination functionality and filtering options for a lawyer recommendation system. It allows users to select the page number, sort by gender, and filter lawyers by their respective city guild. The component makes API calls to retrieve the necessary data and emits events to communicate changes to the parent component.                                                                       |
| [PaginationSearch.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/PaginationSearch.vue) | The code snippet in the file PaginationSearch.vue is responsible for rendering a pagination component that allows users to select a page number and sort the results based on gender. It retrieves data from an external API and emits events to update the URL parameters accordingly.                                                                                                                                                                               |
| [Login.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Login.vue)                       | The code snippet in LawyerUpFrontend/src/components/Login.vue is responsible for rendering a login form with email and password inputs. It also includes a link to a registration page. The component imports and uses the Enroll component.                                                                                                                                                                                                                          |
| [Search.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Search.vue)                     | The code snippet is a Vue component called Pagination that handles pagination and filtering functionalities for a lawyer recommendation system. It retrieves data from an API, sets up options for pagination, and emits events to update the URL.                                                                                                                                                                                                                    |
| [Unit.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Unit.vue)                         | The code snippet, located in LawyerUpFrontend/src/components/Unit.vue, is responsible for rendering a paginated list of lawyers retrieved from an API, allowing users to view detailed information about each lawyer in a modal component. It also provides functionality to filter and sort the list based on user preferences.                                                                                                                                      |
| [Body.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Body.vue)                         | The `Body.vue` component in the `LawyerUpFrontend` directory is responsible for displaying information about the free legal consultation service, as well as providing details on how to find a lawyer. It includes relevant links and images, and utilizes animations for a more engaging user experience.                                                                                                                                                           |
| [LawyerModal.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/LawyerModal.vue)           | The code snippet is a Vue.js component called LawyerModal.vue, which is responsible for displaying detailed information about a lawyer, including their name, license number, gender, affiliation, office, email, telephone, address, and a list of their case histories. It uses Axios to make an HTTP GET request to retrieve the lawyer's data from an API endpoint. The component also includes methods for formatting the case histories into a readable string. |
| [Animation.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Animation.vue)               | This code snippet is a Vue.js component called Animation that is part of the LawyerUpFrontend directory in the Criminal-Lawyer-Recommendation-System repository. The component is responsible for animating the jumbotron section of the application's front end, creating a visually appealing and engaging user experience.                                                                                                                                         |
| [Footer.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Footer.vue)                     | The Footer.vue component in LawyerUpFrontend/src/components is responsible for displaying a professional and trustworthy branding message (We are Professional. Trustworthy. LawyerUp.) with a dynamic typing effect on the website's footer.                                                                                                                                                                                                                         |
| [Enroll.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/components/Enroll.vue)                     | This code snippet is a Vue.js component called Enroll.vue located in the LawyerUpFrontend/src/components/ directory. It provides a modal dialog for user registration, allowing input for name, phone, email, and password. The form layout is defined in the template section.                                                                                                                                                                                       |

</details>

<details closed><summary>LawyerUpFrontend.src.pages</summary>

| File                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [FreeLawyerConsult.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/FreeLawyerConsult.vue) | The code snippet in the LawyerUpBackend.API directory is a crucial part of the Criminal Lawyer Recommendation System repository. It serves as the backend API for the system, including controllers, configurations, and application logic. Its purpose is to handle user requests and provide necessary data, facilitating the recommendation of criminal lawyers.                                                                                                           |
| [Home.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/Home.vue)                           | The `Home.vue` file in `LawyerUpFrontend/src/pages` is responsible for rendering the homepage of the Lawyer Up web application. It includes components for the title and body sections of the page and contains CSS styles for the introductory animation.                                                                                                                                                                                                                    |
| [UserCharge.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/UserCharge.vue)               | The code snippet is a Vue.js component for a credit card checkout form. It provides a user interface for entering card details and submitting the form. It includes validation and form reset functionality.                                                                                                                                                                                                                                                                  |
| [SearchResult.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/SearchResult.vue)           | The code snippet is a Vue.js component called SearchResult that handles displaying search results for a criminal lawyer recommendation system. It uses Vuex for state management and communicates with a backend API to fetch data. The component renders the search results and allows users to view more details about a specific result. It also provides options for predicting case categories.                                                                          |
| [PageNotFound.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/PageNotFound.vue)           | This code snippet is part of the Criminal Lawyer Recommendation System's backend. It contains the API controllers responsible for handling requests and responses. It is a critical component that enables communication between the frontend and backend for user recommendations.                                                                                                                                                                                           |
| [LawyerConsult.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/LawyerConsult.vue)         | This code snippet is a Vue.js component called LawyerConsult.vue within the LawyerUpFrontend directory. It defines the structure, layout, and styling of the lawyer consultation page in the Lawyer Up web application. The component includes sections for displaying information about when to hire a lawyer, a video, and buttons for free and premium consultations. The mounted() function includes animations for scrolling and revealing certain elements on the page. |
| [Lawyer.vue](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/pages/Lawyer.vue)                       | The code snippet in LawyerUpFrontend/src/pages/Lawyer.vue is a Vue.js component that renders a lawyer's information within a lawyer recommendation system. It imports and uses the Unit component to display the lawyer's details.                                                                                                                                                                                                                                            |

</details>

<details closed><summary>LawyerUpFrontend.src.store</summary>

| File                                                                                                                             | Summary                                                                                                                                                                                         |
| ---                                                                                                                              | ---                                                                                                                                                                                             |
| [index.js](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpFrontend/src/store/index.js) | The code snippet represents the Vuex store implementation in the LawyerUpFrontend repository. It manages the application state, including the resultp object and mutations to clear its values. |

</details>

<details closed><summary>LawyerUpBackend</summary>

| File                                                                                                                                        | Summary                                                                                                                                                                                                                                                                                                                        |
| ---                                                                                                                                         | ---                                                                                                                                                                                                                                                                                                                            |
| [LawyerUpBackend.sln](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.sln) | The code snippet is part of the LawyerUpBackend repository and is located in the LawyerUpBackend.API directory. It contributes to the backend architecture of the Lawyer Up Recommendation System. The code achieves the implementation of the API controllers and their associated logic for handling lawyer recommendations. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application</summary>

| File                                                                                                                                                                                                  | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                                                   | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [LawyerUpBackend.Application.csproj](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/LawyerUpBackend.Application.csproj) | Code snippet located in `LawyerUpBackend.Application.csproj` is a crucial part of the LawyerUpBackend application. It relies on the listed dependencies and operates within the.NET 6.0 framework. The code is responsible for defining the target framework, enabling implicit usings and nullability, and managing package references. It also includes a project reference to `LawyerUpBackend.DataAccess.csproj` and a folder for utility files. |
| [ApplicationDependencyInjection.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/ApplicationDependencyInjection.cs)   | The `ApplicationDependencyInjection.cs` file in `LawyerUpBackend.Application` is responsible for configuring and injecting dependencies used in the application. It adds services such as `ILawyerService` and `ICaseService`, and also includes Python services for prediction model functionality. The file utilizes the `Microsoft.Extensions.DependencyInjection` library for dependency injection.                                              |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Models.Case</summary>

| File                                                                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                                                           | ---                                                                                                                                                                                                                                                                                              |
| [CaseListResponseModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Case/CaseListResponseModel.cs) | The code snippet is part of the LawyerUpBackend application and defines the CaseListResponseModel class. This class is used to represent the response model for listing cases in the criminal lawyer recommendation system.                                                                      |
| [CaseSearchQueryModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Case/CaseSearchQueryModel.cs)   | This code snippet defines a model for case search queries in the LawyerUpBackend application. It includes a property for the search query text.                                                                                                                                                  |
| [CaseResponseModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Case/CaseResponseModel.cs)         | This code snippet contains the `CaseResponseModel` class, which represents the response model for a legal case. It includes various properties such as case details, court information, and associated lawyers. This class is a key component in the LawyerUpBackend application's architecture. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Models.PredictionModel</summary>

| File                                                                                                                                                                                                     | Summary                                                                                                                                                                                                   |
| ---                                                                                                                                                                                                      | ---                                                                                                                                                                                                       |
| [PredictionModelQuery.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/PredictionModel/PredictionModelQuery.cs)   | This code snippet represents a PredictionModelQuery class within the LawyerUpBackend.Application.Models.PredictionModel namespace. It defines a string property called Query to store a prediction query. |
| [PredictionModelResult.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/PredictionModel/PredictionModelResult.cs) | The code snippet represents the `PredictionModelResult` class, which is part of the LawyerUpBackend application. It has properties to store boolean success information and three string values.          |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Models.Lawyer</summary>

| File                                                                                                                                                                                                | Summary                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                                                 | ---                                                                                                                                                                                                                                                                                                                                             |
| [LawyerListResponseModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Lawyer/LawyerListResponseModel.cs) | The code snippet defines the LawyerListResponseModel class, which represents the response model for a lawyer's information in the LawyerUpBackend application. It includes properties for a lawyer's name, sex, guild name, email, telephone, address, and ID. This class is used to structure and transfer lawyer data within the application. |
| [LawyerResponseModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Lawyer/LawyerResponseModel.cs)         | This code snippet contains the LawyerResponseModel class, which defines the structure and properties of a lawyer response. It is part of the LawyerUpBackend application and is used to represent lawyer data in the system.                                                                                                                    |
| [LawyerListQueryModel.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Models/Lawyer/LawyerListQueryModel.cs)       | This code snippet, located in the LawyerUpBackend repository's LawyerUpBackend.Application.Models.Lawyer namespace, defines a LawyerListQueryModel class. It includes properties for name and sex, and sets default values for sorting and filtering. The class is used for querying and filtering lawyers in the system.                       |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Exceptions</summary>

| File                                                                                                                                                                                             | Summary                                                                                                                                                                                 |
| ---                                                                                                                                                                                              | ---                                                                                                                                                                                     |
| [SearchNotFoundException.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Exceptions/SearchNotFoundException.cs) | This code snippet defines the custom exception SearchNotFoundException in the LawyerUpBackend repository. It includes a property to store the request URL that triggered the exception. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Dtos</summary>

| File                                                                                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                  |
| ---                                                                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                      |
| [PagedSortedAndFilterInput.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Dtos/PagedSortedAndFilterInput.cs) | This code snippet defines a data transfer object (DTO) class called PagedSortedAndFilterInput in the LawyerUpBackend.Application.Dtos namespace. It provides properties for current page, max result count, sorting, and filter text.                                                                    |
| [PagedResultDto.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Dtos/PagedResultDto.cs)                       | The code snippet defines a generic class `PagedResultDto<TEntity>` that represents a paged result with pagination information. It includes the total count of items, the number of pages, the data for the current page, and boolean flags indicating if there is a previous, next, first, or last page. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Profiles</summary>

| File                                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                          |
| ---                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                              |
| [LawyerProfile.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Profiles/LawyerProfile.cs) | This code snippet is part of the Criminal Lawyer Recommendation System's backend codebase. It contains a profile configuration for mapping Lawyer entities to response models using AutoMapper.                                                                                  |
| [CaseProfile.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Profiles/CaseProfile.cs)     | The `CaseProfile.cs` file in the `LawyerUpBackend.Application` directory maps `Case` objects to `CaseResponseModel` objects using AutoMapper. It plays a critical role in the application's recommendation system by facilitating the conversion and retrieval of relevant data. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Services</summary>

| File                                                                                                                                                                                           | Summary                                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                                            | ---                                                                                                                                                                                                                                                                                                                                                             |
| [ICaseService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/ICaseService.cs)                       | This code snippet defines the interface for the Case Service in the LawyerUpBackend application. It includes methods to search for a list of cases based on a query and to retrieve a specific case by its ID.                                                                                                                                                  |
| [IPredictionModelService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/IPredictionModelService.cs) | The code snippet defines the interface `IPredictionModelService` in the `LawyerUpBackend.Application.Services` namespace. It includes a method `GetPredictionAsync` that returns a `Task<PredictionModelResult>` and takes a `PredictionModelQuery` as a parameter. This interface is used in the LawyerUpBackend application for obtaining prediction results. |
| [ILawyerService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/ILawyerService.cs)                   | The code snippet defines the interface `ILawyerService` in the LawyerUpBackend.Application.Services namespace. It provides methods to retrieve all lawyers, get a lawyer by ID, and get a list of lawyers based on a query.                                                                                                                                     |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Application.Services.Impl</summary>

| File                                                                                                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| ---                                                                                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [PredictionModelService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/Impl/PredictionModelService.cs) | The code snippet is an implementation of the PredictionModelService class in the LawyerUpBackend.Application.Services.Impl namespace. It uses a Python script to run a prediction model and returns the top three results as a PredictionModelResult object. It handles exceptions if the search is not found.                                                                                                                                                              |
| [CaseService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/Impl/CaseService.cs)                       | The code snippet is a file named CaseService.cs, located in the LawyerUpBackend/LawyerUpBackend.Application/Services/Impl directory of the parent repository. It is responsible for implementing the logic related to searching and retrieving case information. The key features include searching for a list of cases based on a query string and retrieving a case by its ID.                                                                                            |
| [LawyerService.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Application/Services/Impl/LawyerService.cs)                   | The code snippet is a service implementation for the Lawyer entity in the LawyerUpBackend application. It provides methods for retrieving a list of lawyers, getting a lawyer by ID, and filtering lawyers based on specific criteria. The implementation uses AutoMapper for mapping between entity and response models, and relies on dependencies such as the Lawyer repository and a mapper. The code includes logic for sorting the results based on query parameters. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.API</summary>

| File                                                                                                                                                                              | Summary                                                                                                                                                                                                                                                                                                                                                                                                         |
| ---                                                                                                                                                                               | ---                                                                                                                                                                                                                                                                                                                                                                                                             |
| [LawyerUpBackend.API.csproj](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/LawyerUpBackend.API.csproj)     | This code snippet is part of a Criminal Lawyer Recommendation System. It belongs to the LawyerUpBackend.API project and is written using.NET Framework 6.0. It includes dependencies for AutoMapper.Extensions.Microsoft.DependencyInjection, Microsoft.EntityFrameworkCore.Tools, and Swashbuckle.AspNetCore. The code facilitates API functionality, such as mapping objects and integrating with a database. |
| [appsettings.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/appsettings.json)                         | This code snippet represents the backend API of a Criminal Lawyer Recommendation System. It handles the application's logic, services, and data access. It uses the Microsoft ASP.NET Core framework and interacts with a local SQL Server database. The API settings are defined in the appsettings.json file.                                                                                                 |
| [appsettings.Development.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/appsettings.Development.json) | This code snippet is part of the Criminal Lawyer Recommendation System repository. It includes the LawyerUpBackend module, responsible for handling the backend logic and APIs. Key files include appsettings.Development.json, which contains configuration details like logging, allowed hosts, and connection strings, as well as Python environment settings for the trained model used in the system.      |
| [Program.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Program.cs)                                     | The mentioned code snippet is responsible for configuring the HTTP request pipeline and setting up services and middleware for the LawyerUpBackend API. It includes adding controllers, configuring Swagger for API documentation, setting up AutoMapper for object mapping, configuring CORS policy, and running the application.                                                                              |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.API..config</summary>

| File                                                                                                                                                                | Summary                                                                                                                                                                                                                                                     |
| ---                                                                                                                                                                 | ---                                                                                                                                                                                                                                                         |
| [dotnet-tools.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/.config/dotnet-tools.json) | This code snippet is part of the Criminal-Lawyer-Recommendation-System repository. It is responsible for the backend API implementation, including controllers, services, and data access. The codebase utilizes the dotnet-ef tool for database migration. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.API.Properties</summary>

| File                                                                                                                                                                       | Summary                                                                                                                                                                                                                                                                                                                                                                |
| ---                                                                                                                                                                        | ---                                                                                                                                                                                                                                                                                                                                                                    |
| [launchSettings.json](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Properties/launchSettings.json) | The code snippet is part of the Criminal Lawyer Recommendation System repository. It consists of the back-end implementation of the system, providing APIs and services. The code enables the back-end server to run and exposes endpoints for communication with the front-end. It uses ASP.NET Core and includes configuration settings for development environment. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.API.Controllers</summary>

| File                                                                                                                                                                                          | Summary                                                                                                                                                                                                                                                                                                                                                                            |
| ---                                                                                                                                                                                           | ---                                                                                                                                                                                                                                                                                                                                                                                |
| [ApiController.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Controllers/ApiController.cs)                         | This code snippet defines the base class for all API controllers in the LawyerUpBackend project. It sets up the routing and controller behavior for handling incoming HTTP requests.                                                                                                                                                                                               |
| [LawyerController.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Controllers/LawyerController.cs)                   | This code snippet is a controller class in the LawyerUpBackend.API directory of the Criminal-Lawyer-Recommendation-System repository. It handles HTTP requests related to lawyers, such as getting a lawyer by ID or searching for lawyers by name using a query parameter. The controller relies on the ILawyerService interface to interact with lawyer data.                    |
| [SearchController.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Controllers/SearchController.cs)                   | The `SearchController.cs` file in the `LawyerUpBackend.API.Controllers` directory is responsible for handling search requests and retrieving case information from the backend. It uses the `IPredictionModelService` and `ICaseService` interfaces to perform search operations and retrieve case details.                                                                        |
| [PredictionModelController.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.API/Controllers/PredictionModelController.cs) | The `PredictionModelController.cs` file in the `LawyerUpBackend.API.Controllers` directory is responsible for handling HTTP requests related to the prediction model. It receives a POST request with a `PredictionModelQuery` object and calls the `GetPredictionAsync` method from the `IPredictionModelService`. If the search is not found, it returns a Bad Request response. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Core</summary>

| File                                                                                                                                                                             | Summary                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                              | ---                                                                                                                                                                                                                                                                                                                                                                                                  |
| [LawyerUpBackend.Core.csproj](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Core/LawyerUpBackend.Core.csproj) | This code snippet is part of a larger repository called Criminal-Lawyer-Recommendation-System. It specifically focuses on the application's backend and is responsible for handling core functionalities such as common elements, entities, and dependencies. It leverages Microsoft's.NET framework and utilizes the Microsoft.EntityFrameworkCore.Tools package for efficient database management. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Core.Common</summary>

| File                                                                                                                                                        | Summary                                                                                                                                                                                                                              |
| ---                                                                                                                                                         | ---                                                                                                                                                                                                                                  |
| [BaseEntity.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Core/Common/BaseEntity.cs) | This code snippet defines a base entity class in the LawyerUpBackend.Core.Common namespace. It includes an Id property with a Column attribute for database mapping. This class serves as a base for other entities in the codebase. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.Core.Entities</summary>

| File                                                                                                                                                                    | Summary                                                                                                                                                                                                                                                                                                                                      |
| ---                                                                                                                                                                     | ---                                                                                                                                                                                                                                                                                                                                          |
| [LawyerCaseMatch.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Core/Entities/LawyerCaseMatch.cs) | This code snippet defines the `LawyerCaseMatch` class in the LawyerUpBackend.Core.Entities namespace. It represents a match between a case and a lawyer, with properties for the match's ID, case ID, and lawyer ID. It also includes navigation properties to access the corresponding case and lawyer objects.                             |
| [Case.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Core/Entities/Case.cs)                       | This code snippet defines the `Case` entity class within the `LawyerUpBackend.Core.Entities` namespace. It represents a case in the criminal lawyer recommendation system and contains various properties and relationships.                                                                                                                 |
| [Lawyer.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.Core/Entities/Lawyer.cs)                   | The code snippet represents the Lawyer entity in the LawyerUpBackend.Core module of the Criminal-Lawyer-Recommendation-System repository. It defines the properties and relationships of a Lawyer object, including their name, license number, sex, birth year, guild name, office, email, telephone, address, and associated case matches. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.DataAccess</summary>

| File                                                                                                                                                                                               | Summary                                                                                                                                                                                                                                                                                                                                                                                              |
| ---                                                                                                                                                                                                | ---                                                                                                                                                                                                                                                                                                                                                                                                  |
| [LawyerUpBackend.DataAccess.csproj](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/LawyerUpBackend.DataAccess.csproj) | This code snippet is part of the LawyerUpBackend.DataAccess project within the Criminal-Lawyer-Recommendation-System repository. It defines the dependencies and target framework for data access using Microsoft Entity Framework Core. It also references the LawyerUpBackend.Core project for additional functionality.                                                                           |
| [AppDbContext.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/AppDbContext.cs)                                     | The code snippet provided is the `AppDbContext.cs` file, which is part of the `LawyerUpBackend.DataAccess` module in the Criminal-Lawyer-Recommendation-System repository. It defines the database context and entities for the application, including Cases, Lawyers, and LawyerCaseMatches.                                                                                                        |
| [Startup.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Startup.cs)                                               | The code snippet in Startup.cs file is responsible for configuring and setting up the database services for the LawyerUpBackend.DataAccess module in the Criminal-Lawyer-Recommendation-System repository. It uses Microsoft.EntityFrameworkCore and Microsoft.Extensions.DependencyInjection to connect and interact with the database. It also adds repositories for the Lawyer and Case entities. |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.DataAccess.Repositiories</summary>

| File                                                                                                                                                                                   | Summary                                                                                                                                                                                                                                                                                       |
| ---                                                                                                                                                                                    | ---                                                                                                                                                                                                                                                                                           |
| [ICaseRepository.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/ICaseRepository.cs)     | This code snippet contains the interface `ICaseRepository` within the `LawyerUpBackend.DataAccess.Repositiories` directory. It defines the contract for data access operations related to the `Case` entity in the LawyerUp backend system.                                                   |
| [IBaseRepositiory.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/IBaseRepositiory.cs)   | The code snippet defines the interface IBaseRepository which includes methods for retrieving, adding, updating, and deleting entities in the LawyerUpBackend.DataAccess.Repositories. It provides a common set of operations for working with different types of entities in the application. |
| [ILawyerRepostiory.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/ILawyerRepostiory.cs) | This code snippet defines the interface ILawyerRepostiory for the LawyerUpBackend.DataAccess.Repositiories module in the Criminal-Lawyer-Recommendation-System repository. It extends the IBaseRepository interface and is responsible for handling Lawyer entity operations.                 |

</details>

<details closed><summary>LawyerUpBackend.LawyerUpBackend.DataAccess.Repositiories.Impl</summary>

| File                                                                                                                                                                                      | Summary                                                                                                                                                                                                                                                                                                                                 |
| ---                                                                                                                                                                                       | ---                                                                                                                                                                                                                                                                                                                                     |
| [CaseRepository.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/Impl/CaseRepository.cs)     | The code snippet is a case repository implementation file within the LawyerUpBackend.DataAccess directory. It extends a base repository, allowing CRUD operations on Case entities.                                                                                                                                                     |
| [BaseRepositiory.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/Impl/BaseRepositiory.cs)   | This code snippet is a base repository implementation for the LawyerUpBackend project in the Criminal Lawyer Recommendation System repository. It provides methods for CRUD operations on entities using Entity Framework Core and async/await pattern.                                                                                 |
| [LawyerRepository.cs](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/LawyerUpBackend/LawyerUpBackend.DataAccess/Repositiories/Impl/LawyerRepository.cs) | This code snippet, located in the LawyerUpBackend.DataAccess.Repositiories.Impl directory, defines the LawyerRepository class. It inherits from the BaseRepository class and implements the ILawyerRepository interface. This class is responsible for handling data access operations related to the Lawyer entity in the application. |

</details>

---

## 🚀 Getting Started
### ⚙️ Installation

1. Clone the Criminal-Lawyer-Recommendation-System repository:
```sh
git clone https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System
```

2. Change to the project directory:
```sh
cd Criminal-Lawyer-Recommendation-System
```

3. Install the dependencies:
```sh
npm install
```

### 🤖 Running Criminal-Lawyer-Recommendation-System
Use the following command to run Criminal-Lawyer-Recommendation-System:
```sh
npm run dev
```

---

## 🤝 Contributing

Contributions are welcome! Here are several ways you can contribute:

- **[Submit Pull Requests](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/blob/main/CONTRIBUTING.md)**: Review open PRs, and submit your own PRs.
- **[Join the Discussions](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/discussions)**: Share your insights, provide feedback, or ask questions.
- **[Report Issues](https://github.com/kennysuper007/Criminal-Lawyer-Recommendation-System/issues)**: Submit bugs found or log feature requests for Criminal-Lawyer-Recommendation-System.

<details closed>
<summary>Contributing Guidelines</summary>

1. **Fork the Repository**: Start by forking the project repository to your GitHub account.
2. **Clone Locally**: Clone the forked repository to your local machine using a Git client.
   ```sh
   git clone <your-forked-repo-url>
   ```
3. **Create a New Branch**: Always work on a new branch, giving it a descriptive name.
   ```sh
   git checkout -b new-feature-x
   ```
4. **Make Your Changes**: Develop and test your changes locally.
5. **Commit Your Changes**: Commit with a clear and concise message describing your updates.
   ```sh
   git commit -m 'Implemented new feature x.'
   ```
6. **Push to GitHub**: Push the changes to your forked repository.
   ```sh
   git push origin new-feature-x
   ```
7. **Submit a Pull Request**: Create a PR against the original project repository. Clearly describe the changes and their motivations.

Once your PR is reviewed and approved, it will be merged into the main branch.

</details>

---

## 📄 License


This project is protected under the MIT License. For more details, refer to the [LICENSE](https://choosealicense.com/licenses/) file.

---

## 👏 Acknowledgments

- Thanks to my teammates Pan Qiaoshu, Zhao Pinqing, and Wen Junyang.
---
