using System;

namespace MyClassLibrary
{
    public class clsStaff
    {
        public string Address { get; set; }
        public double Attendence { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }
        public string StaffNumber { get; set; }

        public bool StaffNumberValid(string tstStaffNumber)
        {
            // boolean flag to indicate that all is ok
            Boolean OK = true;
            //if the length of the StaffNumber is less than 8
            if (tstStaffNumber.Length < 8)
            {
                OK = false;
            }
            //if the length of the StaffNumber is great than 12
            if (tstStaffNumber.Length > 12)
            {
                OK = false;
            }
            return OK;
        }

        public bool Search(string staffNumber)
        {
            //always return true
            return true;
        }
    }
}