using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_edit_text.Controllers
{
    public class SubjectController : Controller
    {
        // GET: Subject
        SubjectManager sm = new SubjectManager(new EfSubjectDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetSubjectList()
        {
            var subjectvalues = sm.GetList();
            return View(subjectvalues);
        }

        [HttpGet]

        public ActionResult AddSubject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSubject(Subject p)
        {
            //sm.SubjectAddBL(p);
            SubjectValidator subjectValidator = new SubjectValidator();
            ValidationResult results = subjectValidator.Validate(p);
            if (results.IsValid)
            {
                sm.SubjectAdd(p);
                return RedirectToAction("GetSubjectList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}