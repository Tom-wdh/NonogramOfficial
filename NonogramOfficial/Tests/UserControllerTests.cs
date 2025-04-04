using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using NonogramOfficial.Controllers;
using NonogramOfficial.Helpers;
using NonogramOfficial.Models;
using Moq;

public class UserControllerTests
{
    private readonly UserController _userController;

    public UserControllerTests()
    {
        _userController = new UserController();
    }

    [Fact]
    public void CheckExistingJsonFiles_ShouldReturnJsonFiles()
    {
        // Arrange
        var expectedFiles = new[] { "user1.json", "user2.json" };
        Directory.CreateDirectory("Users/user1");
        Directory.CreateDirectory("Users/user2");
        File.WriteAllText("Users/user1/user1.json", "{}");
        File.WriteAllText("Users/user2/user2.json", "{}");

        // Act
        var result = _userController.CheckExistingJsonFiles();

        // Assert
        Assert.Equal(expectedFiles, result);

        // Cleanup
        Directory.Delete("Users", true);
    }

    [Fact]
    public async Task RegisterUserAsync_ShouldReturnTrue_WhenUserIsRegistered()
    {
        // Arrange
        var username = "testuser";
        var password = "password";

        // Act
        var result = await _userController.RegisterUserAsync(username, password);

        // Assert
        Assert.True(result);

        // Cleanup
        Directory.Delete("Users", true);
    }

    [Fact]
    public async Task LoginUserAsync_ShouldReturnTrue_WhenCredentialsAreCorrect()
    {
        // Arrange
        var username = "testuser";
        var password = "password";
        await _userController.RegisterUserAsync(username, password);

        // Act
        var result = await _userController.LoginUserAsync(username, password);

        // Assert
        Assert.True(result);

        // Cleanup
        Directory.Delete("Users", true);
    }

    [Fact]
    public async Task UpdateUserAsync_ShouldReturnTrue_WhenUserIsUpdated()
    {
        // Arrange
        var oldUsername = "testuser";
        var newUsername = "updateduser";
        var newPassword = "newpassword";
        await _userController.RegisterUserAsync(oldUsername, "password");

        // Act
        var result = await _userController.UpdateUserAsync(oldUsername, newUsername, newPassword);

        // Assert
        Assert.True(result);

        // Cleanup
        Directory.Delete("Users", true);
    }

    [Fact]
    public async Task DeleteUser_ShouldReturnTrue_WhenUserIsDeleted()
    {
        // Arrange
        var username = "testuser";
        await _userController.RegisterUserAsync(username, "password");

        // Act
        var result = await _userController.DeleteUserAsync(username);

        // Assert
        Assert.True(result);

        // Cleanup
        Directory.Delete("Users", true);
    }
}
