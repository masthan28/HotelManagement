using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class genderBusinessLogic
    {
        GenderDataAccess gda = new GenderDataAccess();
        public List<GenderModel> GetAllGenders()
        {
            return gda.GetAllGenders();
        }
        public void AddGender(GenderModel tblgender)
        {
            gda.AddGender(tblgender);
        }
        public GenderModel getGenderbyId(int genderid)
        {
            return gda.getGenderbyId(genderid);
        }
        public void updateGender(GenderModel tblgender)
        {
            gda.updateGender(tblgender);
        }
        public void deletegender(int genderid)
        {
            gda.deletegender(genderid);
        }
    }
}
