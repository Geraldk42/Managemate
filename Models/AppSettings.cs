using Microsoft.Extensions.Options;

namespace Managemate.Models;

public class AppSettings
{
    public string AllowedHosts { get; set; } = string.Empty;
    public ConnectionStrings ConnectionStrings { get; set; } = new();
}

public class ConnectionStrings
{
    public string DefaultConnection { get; set; } = string.Empty;
}

public class AppSettingsValidator : IValidateOptions<AppSettings>
{
    public ValidateOptionsResult Validate(string? name, AppSettings options)
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(options.AllowedHosts) || options.AllowedHosts == "*")
        {
            errors.Add("AllowedHosts must be configured and not set to '*' for security reasons.");
        }

        if (string.IsNullOrWhiteSpace(options.ConnectionStrings?.DefaultConnection))
        {
            errors.Add("DefaultConnection must be configured.");
        }

        if (errors.Any())
        {
            return ValidateOptionsResult.Fail(errors);
        }

        return ValidateOptionsResult.Success;
    }
}
