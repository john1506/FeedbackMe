
namespace FeedbackMe.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the FeedbackAppEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class FeedbackService : LinqToEntitiesDomainService<FeedbackAppEntities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'feedbacks' query.
        public IQueryable<feedback> GetFeedbacks()
        {
            return this.ObjectContext.feedbacks;
        }

        public void InsertFeedback(feedback feedback)
        {
            if ((feedback.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(feedback, EntityState.Added);
            }
            else
            {
                this.ObjectContext.feedbacks.AddObject(feedback);
            }
        }

        public void UpdateFeedback(feedback currentfeedback)
        {
            this.ObjectContext.feedbacks.AttachAsModified(currentfeedback, this.ChangeSet.GetOriginal(currentfeedback));
        }

        public void DeleteFeedback(feedback feedback)
        {
            if ((feedback.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(feedback, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.feedbacks.Attach(feedback);
                this.ObjectContext.feedbacks.DeleteObject(feedback);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Lecturers' query.
        public IQueryable<Lecturer> GetLecturers()
        {
            return this.ObjectContext.Lecturers;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'modules' query.
        public IQueryable<module> GetModules()
        {
            return this.ObjectContext.modules;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'students' query.
        public IQueryable<student> GetStudents()
        {
            return this.ObjectContext.students;
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'users' query.
        public IQueryable<user> GetUsers()
        {
            return this.ObjectContext.users;
        }
    }
}


