using AdactionNewProject.AdactionVerficationPages;
using AdactionNewProject.BaseTest;
using AdactionNewProject.ParallelExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdactionNewProject.AdactionValidationPage
{
    [TestClass]
    public class AdactionTestPage : AdactionBasePage
    {
        public AdactionLoginPage loginPage;

        public AdactionTitleVerificationPage title;

        public AdactionHomePage homePage;

        public AdactionHotelPaymentDetailsPage paymentpage;

        public AdactionCheckMyBookedHotelListcs bookhotel;




        [TestInitialize]
        public void Initialize()
        {
            loginPage=new AdactionLoginPage(driver);

            homePage=new AdactionHomePage(driver);  

            title=new AdactionTitleVerificationPage(driver);

            paymentpage=new AdactionHotelPaymentDetailsPage(driver);

            bookhotel=new AdactionCheckMyBookedHotelListcs(driver);

        }
        [TestMethod]
        
        
        public void AdactionTest()
        {
           

            loginPage.AdactionLoginPageEntry("saijyothi123456", "Saijyothi@123");

            Thread.Sleep(3000);

            homePage.AdactionBookHotelLocation();

            homePage.AdactionSelectHotel();

            homePage.AdactionSelectRoomType();

            homePage.AdactionSelectNumberofRooms();

            homePage.AdactionSelectCheckInandOutDate("24/05/2023", "25/05/2023");

            homePage.AdactionSelectAdultRoom();

            homePage.ChildernPerRoom();

            homePage.AdactionFormSubmission();

            homePage.VerifyHotelDetails();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            title.TitleVerification();

            Thread.Sleep(3000);

            bookhotel.Adactioncheckhtlbookinglist();

            Thread.Sleep(3000);



        }

 
        
    }
}