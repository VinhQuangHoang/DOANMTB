using _21_11_2021.Areas.admin.Data;
using _21_11_2021.Areas.admin.Models;
using _21_11_2021.Controllers;
using _21_11_2021.Models;
using AutoMapper;
using EmailService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _21_11_2021.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly DPContext _context;
        private readonly IEmailSender _emailSender;

        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, DPContext context, IEmailSender emailSender)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var user = _mapper.Map<User>(userModel);

            var result = await _userManager.CreateAsync(user, userModel.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmationLink = Url.Action(nameof(ConfirmEmail), "Account", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "pqmotobikeshop@gmail.com" }/*{ user.Email }*/, "Confirmation email link", confirmationLink, null);
            await _emailSender.SendEmailAsync(message);

            await _userManager.AddToRoleAsync(user, "Administrator");


            return RedirectToAction(nameof(SuccessRegistration));
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");
            var result = await _userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }

        [HttpGet]
        public IActionResult SuccessRegistration()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLogin userModel, string returnUrl = null)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (!ModelState.IsValid)
            {
                return View(userModel);
            }

            var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, true);
            if (result.Succeeded)
            {
                var user = await _context.Users.FirstOrDefaultAsync(m => m.Email == userModel.Email);
                return await RedirectToLocal(returnUrl, user);
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login Attempt");
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string returnUrl = null)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account", new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInResult.Succeeded)
            {
                return await RedirectToLocal(returnUrl, new User());
            }
            if (signInResult.IsLockedOut)
            {
                return RedirectToAction(nameof(ForgotPassword));
            }
            else
            {
                ViewData["ReturnUrl"] = returnUrl;
                ViewData["Provider"] = info.LoginProvider;
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                return View("ExternalLogin", new ExternalLogin { Email = email });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLogin model, string returnUrl = null)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (!ModelState.IsValid)
                return View(model);

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return View(nameof(Error));

            var user = await _userManager.FindByEmailAsync(model.Email);
            IdentityResult result;

            if (user != null)
            {
                result = await _userManager.AddLoginAsync(user, info);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return await RedirectToLocal(returnUrl, user);
                }
            }
            else
            {
                //user = new User();               
                //user.Email = model.Email;
                //user.UserName = model.Email;
                //user.FirstName = model.Principal.FindFirst(ClaimTypes.GivenName).Value;
                //user.LastName = model.Principal.FindFirst(ClaimTypes.Surname).Value;
                model.Principal = info.Principal;
                user = _mapper.Map<User>(model);
                user.EmailConfirmed = true;
                result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        //TODO: Send an emal for the email confirmation and add a default role as in the Register action
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return await RedirectToLocal(returnUrl, user);
                    }
                }
            }

            foreach (var error in result.Errors)
            {
                ModelState.TryAddModelError(error.Code, error.Description);
            }

            return View(nameof(ExternalLogin), model);
        }

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private async Task<IActionResult> RedirectToLocal(string returnUrl, User user)
        {
            bool isAdmin = await _userManager.IsInRoleAsync(user, "Administrator");

            if (isAdmin)
            {
                return RedirectToAction(nameof(HomeController.Index), "adminHome", new { area = "Admin" });
            }
            else
            {
                //return RedirectToAction(nameof(AccountController.AccessDenied), "Account");
                if (Url.IsLocalUrl(returnUrl))
                    //return Redirect(returnUrl);
                    return RedirectToAction(nameof(AccountController.AccessDenied), "Account");
                else
                    return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPassword forgotPasswordModel)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (!ModelState.IsValid)
                return View(forgotPasswordModel);

            var user = await _userManager.FindByEmailAsync(forgotPasswordModel.Email);
            if (user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Account", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "pqmotobikeshop@gmail.com" }, "Reset password token", callback, null);
            await _emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));
        }

        public IActionResult ForgotPasswordConfirmation()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            var model = new ResetPassword { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPassword resetPasswordModel)
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            if (!ModelState.IsValid)
                return View(resetPasswordModel);
            var user = await _userManager.FindByEmailAsync(resetPasswordModel.Email);
            if (user == null)
                RedirectToAction(nameof(ResetPasswordConfirmation));
            var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPasswordModel.Token, resetPasswordModel.Password);
            if (!resetPassResult.Succeeded)
            {
                foreach (var error in resetPassResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Error()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }

        public async Task<IActionResult> AccessDenied()
        {
            ViewBag.DanhMucSp = _context.danhMucs.ToList();
            ViewBag.LoaiSP = _context.loaiSanPhams.ToList();
            ViewBag.Slide = _context.slideshows.ToList();
            ViewBag.Foot = _context.footshows.ToList();
            ViewBag.SanPham = _context.sanPhams.ToList();
            ViewBag.TinTuc = _context.tinTucs.ToList();
            return View();
        }
    }
}
