using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//This is a comment

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
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 22345678, FirstName = "Valeska", LastName = "Fly", Email = "u22345678@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 34567892, FirstName = "Jake", LastName = "Niel", Email = "u34567892@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 45678912, FirstName = "Danny", LastName = "Phantom", Email = "u45678912@tuks.co.za" });
            myStudyGroup.Add(new Models.raeleneStudyGroupModel { StudentNumber = 56789123, FirstName = "Katsuki", LastName = "Bakugou", Email = "u56789123@tuks.co.za" });

            return View(myStudyGroup);
        }
    }
}