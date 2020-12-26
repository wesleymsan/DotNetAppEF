# DotNetApp

## Build and run local
### Application .Net using Entity Framework Core
1. Clone this repo
2. Build the docker image  
`docker-compose build`
3. Start the application  
`docker-compose up -d`
4. Prepare database  
`sqlcmd -S localhost -U sa -P Your_password123 -i db/createdb.sql`
5. Open your browser at http://localhost:8000
