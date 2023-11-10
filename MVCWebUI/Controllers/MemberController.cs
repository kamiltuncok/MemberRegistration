using Business.Abstract;
using Entities.Concrete;
using MVCWebUI.Filters;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebUI.Controllers
{
    public class MemberController : Controller
    {
        IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        // GET: Member
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
           _memberService.Add(member);
            return View(new MemberAddViewModel());
        }
    }
}