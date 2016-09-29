using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SA41Team02B
{
    class CancelController
    {
        BookingSystemEntities ctx= new BookingSystemEntities();
        int d = 0;       
       
        public void GetTran(string memberID, DateTime SlotDate1,string SlotTime)
        {
            DateTime d1 = SlotDate1;
            DateTime d2 = DateTime.Today;
            bool test = ValidateUsecaseRules(d1,d2);
            
            if (test)
           {
               Tran tr1 = (from x in ctx.Trans where x.MemberID == memberID && x.SlotDate == SlotDate1 && x.SlotTime == SlotTime select x).First();
               tr1.Action = "Cancel";
               ctx.SaveChanges();
           }
           else 
           {
               MessageBox.Show("You cannot cancel bookings less than 2 days");
              // toolStripStatusLabel1.Text = "You cannot cancel bookings less that 2 days";
           }

        
        }
       private bool ValidateUsecaseRules(DateTime d1, DateTime d2)
        {
            

            int d = d2.Day - d1.Day;
            
           if (d <= 2)
           {
               
               return false;
           }

           return true ;
        }
        public void SetAvail(string FacilityID, string SlotTime, DateTime SlotDate1)
        {
          Availability av=(from x in ctx.Availabilities where x.FacilityID == FacilityID && x.SlotDate ==  SlotDate1 && x.SlotTime == SlotTime select x).First();
          av.SlotAvailability="A";
          ctx.SaveChanges();
    
        }
    } 
}
