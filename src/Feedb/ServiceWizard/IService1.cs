using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceWizard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface WizardService
    {
        [OperationContract]
        void submitFeedback(int stuID, int rating, int mID, string feedback, int lecturerID, DateTime dt);

        [OperationContract]
        List<string> getModuleList();

        [OperationContract]
        List<string> getLecturers();

        [OperationContract]
        Boolean authenticate(int stuID, string password);
    }
}
