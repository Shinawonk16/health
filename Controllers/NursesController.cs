using Ex_ample.Data.Entities;
using Ex_ample.Dto.RequestModel;
using Ex_ample.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ex_ample.Controllers
{
    public class NursesController : Controller
    {
        private readonly INurseService _nurseService;
        public NursesController(INurseService nurseService)
        {
            _nurseService = nurseService;
        }
        public IActionResult CreateNurse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNurse(CreateNurseRequestModel nurseRequestModel)
        {
            var ask = _nurseService.AddNurse(nurseRequestModel);
            return RedirectToAction("Login");
        }
        public IActionResult UpdateNurse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateNurse(UpdateNurseRequestModel model,string nurseId)
        {
            var err = _nurseService.EditNurse(model,nurseId);
            return View(err);
        }
        
        public IActionResult DeleteNurse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteNurse(string nurseId)
        {
            _nurseService.DeleteNurse(nurseId);
            return RedirectToAction("AddNurse");
        }
        public IActionResult GetNurse(string nurseId)
        {
           var ques = _nurseService.ViewNurse(nurseId);
            return View(ques);
        }
         public IActionResult GetAllNurse()
        {
          var res =  _nurseService.ViewAllNurse();
            return View(res);
        }
        public IActionResult Login()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Login(LoginRequestModel loginRequestModel)
        {
           var log = _nurseService.Login(loginRequestModel.Email,loginRequestModel.PassWord);
           return RedirectToAction("UpdateNurse");
        }
        [HttpPost]
        public IActionResult Approved(string nurseId)
        {
            var app = _nurseService.ApproveNurse(nurseId);
            return  RedirectToAction("GetAllNurse") ;
        }

    }
}