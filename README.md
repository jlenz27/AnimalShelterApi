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

# Further Exploration
The Further Exploration that I chose is to add Versioning to the API. There is currently only one version but more versions can be added in the future if needed. To acess a specific version use
```
GET http://localhost:5000/api/v1animals/
```
Where "v1" is the specific version that you want to use
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

  add a file in the AnimalShelter directory called `appsettings.json` and add the following code, replacing the password/user field with your credentials:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=7206;database=AnimalShelterApi;uid=[YOUR_UID];pwd=[YOUR_PASSWORD];"
  }
}
```
# Running the program
* Start the API by opening a command line in the `AnimalShelter` directory and enter `dotnet run`

## Endpoints
```
GET http://localhost:5000/api/v1animals/
GET http://localhost:5000/api/v1animals/{id}
POST http://localhost:5000/api/v1animals/
PUT http://localhost:5000/api/v1animals/{id}
DELETE http://localhost:5000/api/v1animals/{id}
```

## Query Examples
  
  * You may query specific entry IDs by appending it to the end:
      ```
      GET https://localhost:5001/api/v1Animals/4
      ```

  * A body is required for POST requests. Example of a good request would be:
      ```
      { 
        "name": "Maggie",
        "species": "Dog",
        "Days in Shelter": 3,
      }
      ```
  * An ID is required for PUT requests (modifying an existing entry) including the ID of the entry:
      ```
      {
        "animalId": 1,
        "name": "Henry",
        "species": "Dog",
        "Days In Shelter": 10,
      }
      ```
  * To delete an entry, simply enter the id of the entry you'd like to delete:
      ```
      DELETE  https://localhost:5001/api/v1Animals/8

 # Known Bugs

- _No know bugs


## License

MIT License

Copyright (c) 2023 John Lenz

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.  