using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using OHDProject.Helpers;
using OHDProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OHDProject.Controllers
{
    public class AccountController : Controller
    {
        private IConfiguration configuration;
        private IWebHostEnvironment webHostEnvironment;

        public AccountController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
        }
        private OHDDbContext db = new OHDDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Account account, IFormFile Avatar)
        {
            account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            account.ConfirmPassword = BCrypt.Net.BCrypt.HashPassword(account.ConfirmPassword);         
            db.Accounts.Add(account);
            await db.SaveChangesAsync();
            if (Avatar != null)
            {
                var fileName = Path.GetFileName(Avatar.FileName);

                var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{fileName}";

                using (FileStream fs = System.IO.File.Create(filepath))
                {
                    Avatar.CopyTo(fs);
                    fs.Flush();
                }
            }
            return View("Login");
        }


        public IActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            var account = checkAccount(email, password);
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            bool isAuthenticates = false;

            var _account = db.Accounts.FirstOrDefault(x => x.Email == email);

            if (account == null)
            {
                ViewBag.error = "Invalid";
                return View("Login");
            }
            else
            {
                HttpContext.Session.SetInt32("id", _account.AccountId);
                HttpContext.Session.SetString("name", _account.FirstName);
                Console.WriteLine(HttpContext.Session.GetInt32("id"));
                var Role = db.Roles.FirstOrDefault(x => x.RoleId == account.RoleID);
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(ClaimTypes.Role,Role.RoleName)
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                if (Role.RoleName == "Admin")
                {
                    isAuthenticates = true;
                    if (isAuthenticates)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Admin");
                    }
                }
                if (Role.RoleName == "Customer")
                {
                    isAuthenticate = true;
                    if (isAuthenticate)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Customer");
                    }
                }
                if (Role.RoleName == "Assignee")
                {
                    isAuthenticate = true;
                    if (isAuthenticate)
                    {
                        var principal = new ClaimsPrincipal(identity);
                        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        return RedirectToAction("Index", "Assignee");
                    }
                }
                return View("Welcome");
            }

        }
        private Account checkAccount(string email, string password)
        {
            var account = db.Accounts.SingleOrDefault(a => a.Email.Equals(email));


            if (account != null)
            {
                //if (BCrypt.Net.BCrypt.Verify(password, account.Password))
                //{
                    return account;
                //}
            }
            return null;
        }

        public IActionResult Signout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }


        public IActionResult PasswordReset()
        {
            return View("PasswordReset");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordReset(string email)
        {
            int numberRD = 50;
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[numberRD];
                int x;
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch
            {
                randomStr = "error";
            }

            var account = db.Accounts.FirstOrDefault(x => x.Email == email);

            account.Password = BCrypt.Net.BCrypt.HashPassword(randomStr);
            account.ConfirmPassword = account.Password;

            db.Update(account);
            await db.SaveChangesAsync();

            var body = "Dear " + account.FirstName + " " + account.LastName + "!<br/> Your current password is: " + randomStr + "<br/> Wish you a good day!";
            var mailHelper = new MailHelper(configuration);
            if (mailHelper.Forgot(configuration["Gmail:Username"], account.Email, body))
            {
                ViewBag.msg = "Sent Mail Successfully! Please check password in email";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("PasswordReset");

        }


        public IActionResult PasswordChange()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PasswordChange(string Email, string Password)
        {
            var account = db.Accounts.FirstOrDefault(x => x.Email == Email);
            account.Password = BCrypt.Net.BCrypt.HashPassword(Password);
            account.ConfirmPassword = account.Password;
            db.Update(account);
            await db.SaveChangesAsync();
            return View("PasswordChange");
        }
    }
}
