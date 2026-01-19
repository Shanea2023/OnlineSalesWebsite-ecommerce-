ChapsAll - C# ASP.NET Core E-Commerce Web App
ChapsAll is a robust, full-stack web application built with C# and ASP.NET Core. It provides a comprehensive marketplace experience with dedicated workflows for administrators, sellers, and customers.

🛠 Tech Stack
Framework: ASP.NET Core (C#)

Frontend: HTML5, CSS3 (Light/Dark Mode), JavaScript, Bootstrap

Payment Gateway: Stripe API Integration

AI: Integrated AI Chatbot for automated customer support

Globalization: Google Translate API integration

👥 User Roles & Permissions
The application uses strict role-based access to ensure security and privacy between different user types.

🛡 Admin (Management)
Oversees the entire application and user roles.

Manages system-wide settings and approves/rejects seller discount requests.

Ensures platform integrity.

📦 Seller (Inventory & Sales)
Full CRUD: Create, Read, Update, and Delete products in their own shop.

Marketing: Create discount campaigns (pending admin approval).

Logistics: Manage shipping details and order fulfillment.

🛒 Customer (Shopping Experience)
Engagement: Add products to Favorites and a persistent Shopping Cart.

Gamification: Play built-in discount games to win price reductions.

Accessibility: Toggle between Light and Dark mode and use Google Translate for multiple languages.

Support: Interact with an AI Chatbot for instant inquiries.

🔒 Security & Payments
Stripe API: Secure, encrypted payment processing.

Access Control: Users are restricted from seeing pages belonging to other roles (e.g., a Customer cannot access the Admin dashboard).

🚀 Installation & Setup
Clone the repository:

Bash
git clone https://github.com/Shanea2023/OnlineSalesWebsite-ecommerce-.git
Open ChapsAll.sln in Visual Studio 2022.

Configure your Stripe API keys in appsettings.json.

Build and run the project using F5.
