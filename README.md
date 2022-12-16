# _Project Name_

#### By _**Richard Cha**_

#### _Choose from Pastry or Bread, give amount, and return total cost_

## Technologies Used

* _C#_
* _.Net 6_
* _MSTest_
* _ASP.NET Core 6 MVC_

## Description

_This application will prompt the user to enter if they'd like to add Bread or Pastry to Cart then how many to add to Cart. It will then give the prompt an option to add more as a yes or no._
_If the user is done adding items to the cart, the program will display their cart and a Cart Total._

## Setup/Installation Requirements

* _Install .Net 6 SDK:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* _Clone this repo to a local directory_
* _Using Terminal on OS X or PowerShell on Windows navigate to the top directory that this repo was cloned to (YourPath/PierresBakery.Solution):_ 
* _Confirm all business logic tests pass with MSTest by running commands (not including the dollar symbol):_
* _$ dotnet restore ./PierresBakery.Tests_
* _$ dotnet test ./PierresBakery.Tests_
* _Then run the program with command :_
* _$ dotnet run --project PierresBakery_

## Known Bugs

* _None_

## License

_If you have any issues or have questions, ideas or concerns please contact me at [charichard09@gmail.com](mailto:charichard09@gmail.com)_

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _12-09-22_ _Richard Cha_



Build an app to track Vendors and the Orders belonging to those vendors

i.e. Vendor.Name == "Suzie's Cafe", Vendor.Orders == List<Order> { Order croissant, Order bagel }

MVP:
Create a Vendor class: name, description of vendor, List<Order> orders

Create an Order class: title, description, price, date(Date.time similar function exist?)

Create homepage at the root path (localhost:5000/): 
header "Welcome Pierre" 
link to a Vendors page.

Create Vendors page:
link to a page presenting a form to create a new Vendor, submit the new Vendor object to a static List inside Vendor, route back to the homepage

at /vendor url, add function to click a Vendor's name to go to a /vendor/id/ page that will display all of that Vendor's orders.

at /vendor/id/, create a link to a /vendor/id/orders/new page presenting a form to create a new Order for a particular Vendor

