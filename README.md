# OpenLens 📸
### IT3047C Final Group Project

**OpenLens** (formerly *IT3047CGroupProject*) is a responsive ASP.NET Core MVC web application designed for photography enthusiasts. The application serves as a comprehensive resource for camera specifications, shooting locations, and photography techniques.

---

## 🚀 Features

* **Camera Database:** A searchable collection of camera bodies with specs and pricing.
* **Location Scout:** A curated list of photography spots categorized by type (Landscape, Portrait, Wildlife).
* **Resource Hub:** Guides for camera gear, accessories, and professional tips.
* **Responsive UI:** Fully mobile-responsive design using Bootstrap 5.

## 🛠️ Technology Stack

* **Framework:** ASP.NET Core MVC (.NET 8)
* **Database:** SQL Server (LocalDB / SQL Express) via Entity Framework Core
* **Frontend:** Razor Views, Bootstrap 5, CSS3
* **Version Control:** Git & GitHub

---

## 👨‍💻 Team & Contributions

This project was developed as a group effort for IT3047C.

### **Tanner Patrick** – *Backend & Data Architecture*
* Designed the core database schema and Entity Framework relationships.
* Implemented data seeding for Cameras and Locations.
* Developed the backend logic for the Locations filtering system.

### **Shawn Theaver** – *Site Structure & Content*
* Built the initial site architecture and navigation routing.
* Developed the "Resources" module (Gear, About, Tips pages).
* Ensured project requirements regarding page count and controller structure were met.

### **Juan Lopez Rosado** – *UI/UX Design & Frontend Architecture*
* **Refactoring:** Migrated camera logic from `HomeController` to a dedicated `CamerasController` to adhere to MVC best practices.
* **Visual Design:** Overhauled the application UI, implementing a "Dark Mode" navigation and a cohesive "OpenLens" brand identity.
* **Components:** Replaced static HTML tables with responsive Bootstrap **Card Grids** (Cameras page) and **Accordions** (Tips page) for improved mobile usability.
* **Navigation:** Implemented hierarchical navigation with dropdowns to improve user flow and responsive design for more interactivity and mobile friendliness.

---

## 📝 License
This project is for educational purposes as part of the UC IT3047C curriculum.
