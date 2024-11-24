using BloodBank.API.Helpers;
using BloodBank.Shared.Entidades;
using BloodBank.Shared.Enums;

namespace BloodBank.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckInventarioAsync();
            await CheckRolesAsync();
            await CheckUserAsync("123", "David", "Zuluaga", "david12-zuluaga@hotmail.com", "31000000", UserType.Admin);
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {

                    Document = document,
                    FirstName = firstName,
                    LastName = lastName,

                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,

                    UserType = userType,
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());

                var token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);


            }

            return user;
        }


        public async Task CheckInventarioAsync()
        {
            if (!_context.Inventarios.Any())
            {
                _context.Inventarios.Add(new Inventario { Tipo = "A+" });
                _context.Inventarios.Add(new Inventario { Tipo = "O+" });
                _context.Inventarios.Add(new Inventario { Tipo = "B+" });
                _context.Inventarios.Add(new Inventario { Tipo = "AB+" });
                _context.Inventarios.Add(new Inventario { Tipo = "A-" });
                _context.Inventarios.Add(new Inventario { Tipo = "O-" });
                _context.Inventarios.Add(new Inventario { Tipo = "B-" });
                _context.Inventarios.Add(new Inventario { Tipo = "AB-" });
            }
            await _context.SaveChangesAsync();
        }
    }
}
