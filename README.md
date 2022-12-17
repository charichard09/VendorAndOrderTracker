# _Pierre's Vendor and Order Tracker_

#### By _**Richard Cha**_

#### _Track vendors and the orders belonging to those vendors_

## Technologies Used

* _C#_
* _.Net 6_
* _MSTest_
* _ASP.NET Core 6 MVC_
* _BootStrap_

## Description

_This application will present a user a list of Vendors that can be added to by clicking the "Add a new vendor" button
and filling out the following form. After a vendor is input, it will displayed on the "https://localhost:5001/vendors" page 
which a user can then click on a vendor name to be taken to that specific vendor's orders list. In the same fashion a user can add to that vendor's orders by clicking the "Add to order" button and filling out the following form which will then be displayed on the "https://localhost:5001/vendors/id" page._

## Setup/Installation Requirements

* _Install .Net 6 SDK:_
* [OS X and Windows Instructions](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net)
* _Clone this repo to a local directory_
* _Using Terminal on OS X or PowerShell on Windows navigate to the top directory that this repo was cloned to (YourPath/VendorAndOrderTracker.Solution):_ 
* _Confirm all business logic tests pass with MSTest by running commands (not including the dollar symbol):_
* _$ dotnet restore ./VendorAndOrderTracker.Tests_
* _$ dotnet test ./VendorAndOrderTracker.Tests_
* _Then run the program with command :_
* _$ dotnet watch run --project VendorAndOrderTracker_

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

Copyright (c) _12-16-22_ _Richard Cha_