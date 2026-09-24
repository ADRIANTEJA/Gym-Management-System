using System.ComponentModel.DataAnnotations;

namespace DataAccess.Configuration;

public class ConnectionStringOptions
{
    [Required]
    public string SQLServerConnectionString { get; set; }
}