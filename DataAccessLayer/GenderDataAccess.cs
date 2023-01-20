using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GenderDataAccess
    {
        HotelManagement_Context _Context = new HotelManagement_Context();
        public List<GenderModel> GetAllGenders()
        {
            List<tblgender> genderList= _Context.tblgenders.ToList();
            List<GenderModel> genderListBo = new List<GenderModel>();
            foreach(tblgender gen in genderList)
            {
                GenderModel genmodel = new GenderModel();
                genmodel.id = gen.id;
                genmodel.Name = gen.Name;
                genmodel.isactive = gen.isactive;
                genderListBo.Add(genmodel);

            }
            return genderListBo;
        }
        public void AddGender(GenderModel tblgender)
        {
            tblgender gender = new tblgender();
            gender.Name = tblgender.Name;
            gender.createdate = tblgender.createdate;
            gender.createdby = tblgender.createdby;
            gender.isactive = tblgender.isactive;
            _Context.tblgenders.Add(gender);
            _Context.SaveChanges();
        }
        public GenderModel getGenderbyId(int genderid)
        {
            tblgender gender= _Context.tblgenders.Where(x => x.id == genderid).FirstOrDefault();
            GenderModel genderModel = new GenderModel();
            gender.Name = gender.Name;
            gender.createdate = gender.createdate;
            gender.createdby = gender.createdby;
            gender.isactive = gender.isactive;
            return genderModel;

        }
        public void updateGender(GenderModel gendermodel)
        {
            var gender = _Context.tblgenders.Where(x => x.id == gendermodel.id).FirstOrDefault();
            if(gender != null)
            {
                gender.Name = gendermodel.Name;
                gender.modifieddate = DateTime.Now;
                gender.modifiedby = 1;
                _Context.SaveChanges();
            }
        }
         public void deletegender(int genderid)
        {
            var gender = _Context.tblgenders.Where(x => x.id == genderid).FirstOrDefault();
           // _Context.tblgenders.Remove(gender);
            if (gender != null)
            {
                
                gender.modifieddate = DateTime.Now;
                gender.modifiedby = 1;
                gender.isactive = false;
                _Context.SaveChanges();
            }
            _Context.SaveChanges();
        }
    }   
}   
