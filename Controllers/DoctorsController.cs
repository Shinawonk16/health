using Ex_ample.Data.Entities;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ex_ample.Controllers
{
    public class DoctorsController:Controller
    {
        private readonly IDoctorService _doctorService;
        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        public IActionResult AddDoctor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDoctor(CreateDoctorRequestModel model)
        {
            var add = _doctorService.AddDoctor(model);
            return RedirectToAction("Login");
        }
        
        public IActionResult  UpdateDoctor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult  UpdateDoctor(UpdateDoctorRequestModel requestModel,string doctorId)
        {
            var cot = _doctorService.EditDoctor(requestModel,doctorId);
            return View(cot);
        }
        
        
          public IActionResult  ViewDoctor(string doctorId)
        {
            var edit = _doctorService.ViewDoctor(doctorId);
            return View(edit);
        }
           public IActionResult  ViewAllDoctor()
        {
            var see = _doctorService.ViewAllDoctors();
            return View(see);
        }
        
        public IActionResult DeleteDoctor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteDoctor(string doctorId)
        {
            _doctorService.DeleteDoctor(doctorId);
            return RedirectToAction("AddDoctor");
        }
         public IActionResult Login()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Login(LoginRequestModel loginRequestModel)
        {
           var log = _doctorService.Login(loginRequestModel.Email,loginRequestModel.PassWord);
           return RedirectToAction("UpdateDoctor");
        }
        [HttpPost]
        public IActionResult Approved(string doctorId)
        {
            var app = _doctorService.ApproveDoctor(doctorId);
            return  RedirectToAction("ViewAllDoctor") ;
        }


    }
}