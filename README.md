# Animal House API
### By John Lenz

### An Api for listing animals for a fictional shelter.

# Technologies Used

   * C#
   * ASP.Net 6
   * EFCore
   * MySQL
   * SwaggerUI
   * Postman

# #Setup/Installation Guide
 
## Set up the API
* Clone the repository 
* Navigate to the `AnimalShelterApi` folder
* Open a command line and enter the following:
  ```
  dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
  dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
  dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
  dotnet ef database update
  ```