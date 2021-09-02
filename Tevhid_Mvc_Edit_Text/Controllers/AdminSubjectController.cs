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

namespace Tevhid_Mvc_Edit_Text.Controllers
{
    public class AdminSubjectController : Controller
    {
        SubjectManager sm = new SubjectManager(new EfSubjectDal());
        // GET: AdminSubject
        public ActionResult Index()
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
            SubjectValidator subjectvalidator = new SubjectValidator();
            ValidationResult results = subjectvalidator.Validate(p);
            if(results.IsValid)
            {
                sm.SubjectAdd(p);
                return RedirectToAction("Index");

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

        public ActionResult DeleteSubject(int id)
        {
            var subjectvalue = sm.GetById(id);
            sm.SubjectDelete(subjectvalue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSubject(int id)
        {
            var subjectvalue = sm.GetById(id);
            //sm.EditUpdate(subjectvalue);
            return View(subjectvalue);
        }

        [HttpPost]
        public ActionResult EditSubject(Subject p)
        {
            //var subjectvalue = sm.GetById(id);
            sm.SubjectUpdate(p);
            return RedirectToAction("Index");
        }
    }
}