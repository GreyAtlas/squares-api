# Squares

A simple API for handling lists of 2D coordinates, storing them in a database and finding all possible squares formed from the coordinates in a given list.

## Running the application

To launch this applicaton need to have .NET build tools and Docker installed. 

The application is currently hardcoded to connect to specific localhost ports, mysql database: ```5174``` and .NET: ```5085```. Provided the ports are unused there are two options to launch the full application:

1. Run the ```launchAll.bat``` script in the root directory.


2. Launch each project manually;
 -  Backend
```
  cd backend/Squares.Api
  dotnet run
```
- Database
```
  docker compose up
```
