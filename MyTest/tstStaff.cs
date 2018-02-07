﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTest
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test daata to assign to the property
            string tstStaffNumber = "P1622604";
            //Assign the data to the property
            AStaff.StaffNumber = tstStaffNumber;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffNumber, tstStaffNumber);
        }

        [TestMethod]
        public void ValidStaffNumber()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622604";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P162260";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void StaffNumberMinBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622604";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P16226044";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P1622561291";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxBoundary()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P16225612912";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void StaffNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean OK = false;
            //create some test data to assign to the property
            string tstStaffNumber = "P162256129121";
            OK = AStaff.StaffNumberValid(tstStaffNumber);
            //test to see that the result is corresct 
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstFirstName = "Zihao";
            //Assign the data to the property
            AStaff.FirstName = tstFirstName;
            //test to see that the two values are the same
            Assert.IsNotNull(tstFirstName);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstLastName = "Zihao";
            //Assign the data to the property
            AStaff.LastName = tstLastName;
            //test to see that the two values are the same
            Assert.IsNotNull(tstLastName);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstGender = "Male";
            //Assign the data to the property
            AStaff.Gender = tstGender;
            //test to see that the two values are the same
            Assert.IsNotNull(tstGender);
        }

        [TestMethod]
        public void PositionPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPosition = "Cleaner";
            //Assign the data to the property
            AStaff.Position = tstPosition;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPosition);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPassword = "asdfgasdfgh";
            //Assign the data to the property
            AStaff.Password = tstPassword;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPassword);
        }

        [TestMethod]
        public void AttendencePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            double tstAttendence = 98.6;
            //Assign the data to the property
            AStaff.Attendence = tstAttendence;
            //test to see that the two values are the same
            Assert.IsNotNull(tstAttendence);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstAddress = "Leicester";
            //Assign the data to the property
            AStaff.Address = tstAddress;
            //test to see that the two values are the same
            Assert.IsNotNull(tstAddress);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string tstPhoneNumber = "+12345678";
            //Assign the data to the property
            AStaff.PhoneNumber = tstPhoneNumber;
            //test to see that the two values are the same
            Assert.IsNotNull(tstPhoneNumber);
        }

        [TestMethod]
        public void SearchMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the balidation 
            Boolean Search = false;
            //create some test data to use with the moethod 
            string StaffNumber = "P1622604";
            //invoke the moethod 
            Search = AStaff.Search(StaffNumber);
            //test to se that the result is correct
            Assert.IsTrue(Search);
        }

    }
}
