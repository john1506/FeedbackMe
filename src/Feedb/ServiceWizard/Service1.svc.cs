using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWizard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : WizardService
    {
        public void submitFeedback(int stuID, int rating, int mID, string feedback, int lecturerID, DateTime dt)
        {
            using (FeedbackDataDataContext fbd = new FeedbackDataDataContext())
            {
                var feedb = new feedback();
                feedb.studentID = stuID;
                feedb.lectureRating = rating;
                feedb.moduleID = mID;
                feedb.Feedback1 = feedback;
                feedb.teacherID = lecturerID;
                feedb.date = dt;
                fbd.feedbacks.InsertOnSubmit(feedb);
                fbd.SubmitChanges();
            }
        }

        public List<string> getModuleList()
        {
            FeedbackDataDataContext te = new FeedbackDataDataContext();
            var mlist = from modul in te.modules orderby modul.moduleName descending select modul.moduleName;
            return mlist.Take(mlist.Count()).ToList();
        }


        public List<string> getLecturers()
        {
            FeedbackDataDataContext te = new FeedbackDataDataContext();
            var tlist = from teacher in te.Lecturers orderby teacher.teacherID select teacher.teacherName;
            return tlist.Take(tlist.Count()).ToList();
        }

        public Boolean authenticate(int stuID, string password)
        {
           
            return checkAuth(stuID, password);
        }

        private Boolean checkAuth(int s, string p)
        {
            studentDataContext studData = new studentDataContext();
            var stud = (from studx in studData.authStus where studx.studentID == s select studx).FirstOrDefault();
            if (stud.password != p)
            {
                return false;
            }
            else if (stud.password == p)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
