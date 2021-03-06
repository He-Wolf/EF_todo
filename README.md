# EF_todo
ToDo list ASP .Net WebApi

command
scaffolding:
    dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers
db migration:
    dotnet ef migrations add InitialCreate
    dotnet ef database update