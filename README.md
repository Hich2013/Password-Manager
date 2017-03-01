# Password Manager SPA with AngularJS and Web API 2.0 

How many times have you had to hit the FORGOT PASSWORD link, only to forget that same password a few weeks later? 
Wouldn't it be awesome if you just had to remember a single password, which will give you access to all of your passwords 
and generate new secure ones for you? 

Password managers aren't just for convenience's sake, it is a good online hygene. 

This is a light-weight single-page web application to manage all my passwords in a highly secure manner. 
This development is still progress and many features are to be added. This application is scalable, testable, and 
can support a variety of front-end devices. It uses the lastest .NET Web API 2.0 for back-end support and AngularJS/ Bootstrap for front-end. 
	
## Features: 

- Stack: Web API 2.0 - AngularJS - BootStrap 
- Password Manager 
- Token Based Authentication   
- Generating Secure Passwords (In Progress)
- Unit Tests for Web API (In Progress)
- Unit Tests for AngularJS (In Progress)
- Entity Framework as ORM
    
### Web API Controllers 
- Password Controller 
Provides Create, Delete, Update, and delete operations for passwords and their corresponding applications 


### Security
This app includes token-based authentication with prompt expiration to allow for optimal security  


## Installing 
This application currently runs on my local environment (localhost) and SQL Server. If you would like to run it on your machine and any environment all you need is: 
- Install Visual Studio if it is not already (Express is free!)
- Clone the repository 
- Change the `connection string` in the `web.config` file to point to your server/database 
- Give it a build and Run! 

## Migrations 
There is currently a migration file under the migration folder that seeds a collection of sample data into the database at run-time.

## TODO: 
- Include unit tests for Angular Controllers and Web API controllers 
- Include dependency injection and a repository layer 
- Add generate password feature 

## Contributing 


## Authors  
- Hichem Rehouma (myself)
