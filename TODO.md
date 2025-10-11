# TODO: Implement Bcrypt Password Hashing

- [x] Add BCrypt.Net-Next package to Managemate.csproj
- [ ] Create Helpers/PasswordHasher.cs with Hash and Verify methods
- [ ] Update Components/Pages/auth/SignUp.razor to use PasswordHasher.Hash
- [ ] Update Components/Pages/auth/Login.razor to use PasswordHasher.Verify
- [ ] Run dotnet restore to install packages
 

 from gerald :
 since I can't make comments everywhere esp on the .json files this is  a breakdown on what I have done

Configuration Validation: Created Models/AppSettings.cs with classes for binding configuration and a validator that ensures AllowedHosts is not set to "*" and DefaultConnection is configured.

Program.cs Updates: Added configuration binding and validation setup, plus security headers middleware that sets:

X-Frame-Options: DENY
X-Content-Type-Options: nosniff
Referrer-Policy: strict-origin-when-cross-origin
X-XSS-Protection: 1; mode=block
appsettings.json: Changed AllowedHosts from "*" to "localhost" for security, and cleared the hardcoded connection string (to be set via environment variables).

appsettings.Development.json: Added the connection string for local development.

appsettings.Production.json: Created with secure defaults for production environment.