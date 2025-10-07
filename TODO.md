# TODO: Implement Bcrypt Password Hashing

- [x] Add BCrypt.Net-Next package to Managemate.csproj
- [ ] Create Helpers/PasswordHasher.cs with Hash and Verify methods
- [ ] Update Components/Pages/auth/SignUp.razor to use PasswordHasher.Hash
- [ ] Update Components/Pages/auth/Login.razor to use PasswordHasher.Verify
- [ ] Run dotnet restore to install packages
