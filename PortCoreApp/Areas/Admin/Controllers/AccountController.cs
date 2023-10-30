﻿using BusinessLayer.ManagerServices.Abstracts;
using Castle.Core.Smtp;
using CommonLayer.Services;
using DTOLayer.DTOS.AdminDTOs;
using EntityLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace PortCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        IAppUserManager _iappUserManager;
        private readonly IEmailSenderService _emailSenderService;

        public AccountController(IAppUserManager iappUserManager, IEmailSenderService emailSenderService)
        {
            _iappUserManager = iappUserManager;
            _emailSenderService = emailSenderService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(SignUpVM signInVM)
        {
            var newUser = new AppUser
            {
                FirstName = signInVM.Name,
                LastName = signInVM.Surname,
                Email = signInVM.Mail,
                UserName = signInVM.Username
            };
            bool result = await _iappUserManager.CreateUser(newUser, signInVM.Password);
            string activationLink = "https://localhost:44313/Admin/Account/Activation/" + newUser.EmailConfirmationToken;
            string gonderilecekEmail = "Congratulations...Your account has been created...You can click on the link " + activationLink + " to activate your account";
            await _emailSenderService.SendConfirmationEmail("onurabdulaji@gmail.com", newUser.Email, "Activation Code", gonderilecekEmail);
            if (result)
            {
                return RedirectToAction("RegisterOk", "Account");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Error");
            }
            return View(signInVM);
        }

        public ActionResult RegisterOk()
        {
            return View();
        }


        public IActionResult Activation(Guid id)
        {
            AppUser newUserneedtoActived = _iappUserManager.TFirstOrDefault(x => x.EmailConfirmationToken == id);
            if (newUserneedtoActived != null)
            {
                newUserneedtoActived.EmailConfirmed = true;
                _iappUserManager.TUpdate(newUserneedtoActived);
                TempData["AccountActiveIs"] = "Your account has been activated";
                return RedirectToAction("SignIn", "Account");
            }
            else
            {
                TempData["AccountActiveIs"] = "Your account was not found";
                return RedirectToAction("SignUp");
            }
        }
    }
}

