# Online Store

Online Store is a console application built with C# that allows users to browse products, add them to a shopping cart, and place orders securely. It demonstrates fundamental Object-Oriented Programming (OOP) principles such as inheritance, encapsulation, and polymorphism.

### Features
- **Product Management:** Browse a variety of products categorized into electronics and clothing with detailed information.
- **Shopping Cart:** Add products to the cart for later purchase.
- **Order Placement:** Proceed to checkout to review and place orders securely.
- **Payment Processing:** Support for multiple payment methods, including credit card and PayPal.
- **Inventory Management:** Ensure accurate inventory management to prevent overselling.

### Object-Oriented Design
- **Classes:** Utilizes various classes including `Product`, `Customer`, `Order`, `ShoppingCart`, and payment method classes (`CreditCardPayment` and `PayPalPayment`) to model real-world entities.
- **Inheritance:** Different product categories inherit common attributes and behaviors from the base `Product` class.
- **Encapsulation:** Securely manages product inventory, customer information, and order details within their respective classes.
- **Polymorphism:** Payment methods implement a common interface (`IPaymentMethod`) for interchangeable use.

### Usage

### Prerequisites
Ensure you have the following installed on your machine:
- [.NET Core SDK](https://dotnet.microsoft.com/download) 
- [Git](https://git-scm.com/downloads)

#### Installation
1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/Mahmoud-Elaaser/OnlineStore.git
2. Navigate to the project directory:
    ```bash
    cd OnlineStore
3. Build the solution then Run application
4. Follow the on-screen prompts to interact with the Online Store Application:

    - Enter your name, email, and total money available.
    - Browse available products and add them to your shopping cart by entering the product ID.
    - Once you've finished shopping, proceed to checkout and select a payment method.
    - Confirm your order and complete the payment process.

