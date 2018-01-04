using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SureSafetyDB;

namespace SureSafetyMVC.Controllers
{
    public class IncidentDetails1Controller : Controller
    {
        private SureSafetyDBModelContainer db = new SureSafetyDBModelContainer();

        // GET: IncidentDetails1
        public ActionResult Index()
        {
            return View(db.IncidentDetails.ToList());
        }

        // GET: IncidentDetails1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            if (incidentDetails == null)
            {
                return HttpNotFound();
            }
            return View(incidentDetails);
        }

        // GET: IncidentDetails1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncidentDetails1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SuddenEvent,SEDate,SETime,GradualOT,GDate,GTime,ReportedDate,ReportedTime,ReprotedTo,LocationOfIncident,Exposures,IncidentDescription,WhatHappened,InjuryDescription,ToolsUsed,PersonalProtectiveEquipment,Witness,FirstAidRequired,FirstAidDate,FirstAiderName,FirstAiderPosition,AbsenceDueToIncident,FirstDayOff,MedicalTreatmentRequired,MTDate,FacilityType,FacilityName_Address,Practitioner")] IncidentDetails incidentDetails)
        {
            if (ModelState.IsValid)
            {
                db.IncidentDetails.Add(incidentDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(incidentDetails);
        }

        // GET: IncidentDetails1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            if (incidentDetails == null)
            {
                return HttpNotFound();
            }
            return View(incidentDetails);
        }

        // POST: IncidentDetails1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SuddenEvent,SEDate,SETime,GradualOT,GDate,GTime,ReportedDate,ReportedTime,ReprotedTo,LocationOfIncident,Exposures,IncidentDescription,WhatHappened,InjuryDescription,ToolsUsed,PersonalProtectiveEquipment,Witness,FirstAidRequired,FirstAidDate,FirstAiderName,FirstAiderPosition,AbsenceDueToIncident,FirstDayOff,MedicalTreatmentRequired,MTDate,FacilityType,FacilityName_Address,Practitioner")] IncidentDetails incidentDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(incidentDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(incidentDetails);
        }

        // GET: IncidentDetails1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            if (incidentDetails == null)
            {
                return HttpNotFound();
            }
            return View(incidentDetails);
        }

        // POST: IncidentDetails1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IncidentDetails incidentDetails = db.IncidentDetails.Find(id);
            db.IncidentDetails.Remove(incidentDetails);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
