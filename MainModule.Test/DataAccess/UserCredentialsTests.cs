using DataAccess;
using DataAccess.Configuration;
using DataAccess.DataAccess;
using DataAccess.Models;
using Microsoft.Extensions.Options;
using Moq;

namespace MainModule.Test.DataAccess;

public class UserCredentialsTests
{
    [Fact]
    private async Task CreateUserCredentials_ShouldReturnInsertedId()
    {
        // Arrange
        var mockDbAccess = new Mock<SQLServerAccess>();
        
        var mockConnectionStringOptions = new Mock<IOptions<ConnectionStringOptions>>();

        mockConnectionStringOptions.SetupGet(x => x.Value).Returns(new ConnectionStringOptions
        {
            SQLServerConnectionString = "Data Source=(localdb)\\SQL2025DB;Initial Catalog=GymManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"
        });

        var userCredentialsData = new UserCredentialsData(mockDbAccess.Object, mockConnectionStringOptions.Object);
        
        var newUserCredentials = new UserCredentialsModel
        {
            EmailAddress = "adriantejablanco.ds@gmail.com",
            HashedPassword = "hashedpassword"
        };

        // Act
        int result = await userCredentialsData.CreateUserCredentials(newUserCredentials);

        var test = result;

        // Assert
        Assert.True(result > 0);
    }
}
