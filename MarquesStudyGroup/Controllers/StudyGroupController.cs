using MarquesStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarquesStudyGroup.Models;

namespace MarquesStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            // Create a list of study group members
            List<StudyGroupMember> members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u23649284", Name = "Marques", Surname = "Jaboon", EmailAddress = "u23649284@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22345678", Name = "John", Surname = "Doe", EmailAddress = "u22345678@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u23456789", Name = "Alice", Surname = "Smith", EmailAddress = "u23456789@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24567890", Name = "Bob", Surname = "Johnson", EmailAddress = "u24567890@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u21278901", Name = "Charlie", Surname = "Brown", EmailAddress = "u21278901@tuks.co.za" }
            };

            // Pass the list to the view
            return View(members);
        }
    }
}
