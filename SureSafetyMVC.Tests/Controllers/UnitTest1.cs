using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http.Results;
using SureSafetyMVC.Controllers;
using SureSafetyDB;

namespace SureSafetyMVC.Tests.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        private static int _eID { get; set; }

        [TestMethod]
        public void Add_Test()
        {
            IncidentDetailsController idc = new IncidentDetailsController();
            IncidentDetails id = new IncidentDetails()
            {
                SuddenEvent = true,
                SEDate = "ffsdf",
                SETime = "dfsdf",
                GradualOT = true,
                GDate = "fsfsdf",
                GTime = "gdfgsdfg",
                ReportedDate = "fsdfs",
                ReportedTime = "fsdf",
                ReprotedTo = "sdf",
                LocationOfIncident = "df0",
                Exposures = "dds",
                IncidentDescription = "dsdsd",
                WhatHappened = "dsadasd",
                InjuryDescription = "dsds",
                ToolsUsed = "dsfdf",
                PersonalProtectiveEquipment = "dsadsad",
                Witness = "dfsdf",
                FirstAidRequired = false,
                FirstAidDate = "sfdf",
                FirstAiderName = "fsfdsdf",
                FirstAiderPosition = "sdfsdf",
                AbsenceDueToIncident = false,
                FirstDayOff = "ddfsdf",
                MedicalTreatmentRequired = false,
                MTDate = new DateTime(1995, 01, 20),
                FacilityType = "fdfsdf",
                FacilityName_Address = "fdfs",
                Practitioner = "dsfsdf"


            };

            var result = idc.PostIncidentDetails(id) as CreatedAtRouteNegotiatedContentResult<IncidentDetails>;

            Assert.AreEqual("dfsdf", result.Content.Witness);
            _eID = result.Content.Id;
        }

        [TestMethod]
        public void Get_Test()
        {
            IncidentDetailsController idc = new IncidentDetailsController();
            var result = idc.GetIncidentDetails(_eID) as OkNegotiatedContentResult<IncidentDetails>;
            Assert.AreEqual("dfsdf", result.Content.Witness);

        }

        [TestMethod]
        public void Delete_Test()
        {
            IncidentDetailsController idc = new IncidentDetailsController();
            var result = idc.DeleteIncidentDetails(_eID) as OkNegotiatedContentResult<IncidentDetails>;
            Assert.AreEqual("dfsdf", result.Content.Witness);
        }
    }
}
