
# Shoppe Pierre 
### A Bakery for Your Discerning Taste.

#### _C#, MVC, .NET_

## Description
Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the vendors that purchase baked goods from him and the orders belonging to those vendors.

## Use Case(s)
Pierre might supply croissants to a vendor called "Suzie's Cafe" once a week. Pierre may want to create a new Vendor to represent the cafe and add new Orders to it to help keep track of his expanding business relationships.

* Maintaining the following deals Pierre offers :
Bread: Buy 2, get 1 free. A single loaf costs $5.
Pastry: Buy 1 for \$2 or 3 for $5.
* Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor
* List of Orders belonging to the vendor
* Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
* The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.
* The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. 
* After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.
* Pierre should be able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.
* Pierre should be provided with a link to a page presenting him with a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".
* A splash page is used.

* Project has Vendor and Order classes.

* Project uses two or more controllers.

* GET and POST requests/responses are used successfully.

## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/QuietEvolver/ShoppePierre.Solution.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
vera.weikel@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 under the MIT License