using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//This is a comment
//comment 2

namespace raeleneStudyGroup.Controllers 
{
    public class raeleneStudyGroupController : Controller
    {
        // GET: raeleneStudyGroup
        public ActionResult raeleneStudyGroupView()
        {
            List<Models.raeleneStudyGroupModel> myStudyGroup = new List<Models.raeleneStudyGroupModel>();
            //"myStudyGroup" is list name "MyStudentModel is the class"
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 20467207, FirstName = "Raelene", LastName = "Dookkoo", Email = "u20467207@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 23704404, FirstName = "Unathi", LastName = "Mokgothu", Email = "u23704404@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 22500333, FirstName = "Jay", LastName = "Mashele", Email = "u22500333@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 24979962, FirstName = "Sivu", LastName = "Ngalo", Email = "u24979962@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 19100133, FirstName = "Matthew", LastName = "Reed", Email = "u19100133@tuks.co.za" });

            return View(myStudyGroup);
        }
    }
}