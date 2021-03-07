using System.Collections.Generic;
using Xunit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using EF_todo.Data;
using EF_todo.Models;
using EF_todo.Services;
using EF_todo.Controllers;
using Microsoft.Data.Sqlite;

namespace EF_todo.Tests
{
    public class TodoItemsControllerTest
    {
        private SqliteConnection connection;
        private DbContextOptions<TodoContext> dbContextOptions;
        private TodoService todoService;
  
        public TodoItemsControllerTest()
        {
            connection = new SqliteConnection("Filename=:memory:");
            connection.Open();

            dbContextOptions = new DbContextOptionsBuilder<TodoContext>()
                .UseSqlite(connection)
                .Options;

            var context = new TodoContext(dbContextOptions);
            MockDataDBInitializer db = new MockDataDBInitializer();
            db.Seed(context);
        
            todoService = new TodoService(context);
        }
        [Fact]
        public async void Task_GetTodoItems_Return_OkResult()
        {
            //Arrange
            var controller = new TodoItemsController(todoService);
  
            //Act
            var data = await controller.GetTodoItem();
  
            //Assert
            Assert.IsType<OkObjectResult>(data.Result);
        }
        [Fact]
        public async void Task_GetTodoItems_Return_AllItems()
        {
            //Arrange
            var controller = new TodoItemsController(todoService);

            // Act
            var data = await controller.GetTodoItem();
            var result = data.Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<TodoItem>>(result.Value);
            Assert.Equal(3, items.Count);
        }
        [Fact]
        public async void Task_GetTodoItems_MatchResult()
        {
            //Arrange
            var controller = new TodoItemsController(todoService);

            // Act
            var data = await controller.GetTodoItem();
            var result = data.Result as OkObjectResult;
            
            // Assert
            var items = Assert.IsType<List<TodoItem>>(result.Value);
            Assert.Equal(1, items[0].Id);
            Assert.Equal("Cleaning", items[0].Title);
            Assert.Equal("to clean the house", items[0].Description);
            Assert.True(items[0].IsComplete);
        }
    }
}