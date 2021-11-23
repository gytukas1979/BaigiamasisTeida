using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisTeida.Test
{
    public class TeidaTest : BaseTest
    {
        /* [Test]
        public void TeidaPagrindinis()
         {
             _teidaPagrindinisPage1.NavigateToDefaultPage()
             // pupOp() KAZKAIP APSIRASTTI
             //AcceptCookie();
             .ClickButtonPagrindinisPrisijungti();*/
        [Order(1)]
        [TestCase("gytukas@yahoo.com", "Asmokausi1", TestName = "Test New User Prisijungimas")]
        public void TestNewUserPrisijungimas(string elPastas, string slaptazodis)
        {
            _teidaPagrindinisPage1.NavigateToDefaultPage()
            // .PopUp.Click();

            //AcceptCookie();
            .ClickButtonPagrindinisPrisijungti();
            _teidaPrisijungtiPage2.PrisijungtiElPastasAndSlaptazodis(elPastas, slaptazodis)
             .ClickButtonPrisijungti();
            _teidaPagrindinisPage1.CheckLoginResult();
        }


        [Order(3)]
        [Test]
        public void TestAtsijungti()
        {

            _teidaPagrindinisPage1.NavigateToDefaultPage()
                .ClickButtonPagrindinisPrisijungti()
                .CheckLogoutResult();
        }

        [Order(2)]                         //NAUJAS
        [TestCase("97.50")]
        public void TestIfProductWithSpecificCodeIsInTheBasket(string productCode)
        {
            _teidaPagrindinisPage1.NavigateToDefaultPage()
                .PutProductByCodeIntoBasket(productCode);
            _krepselisPage.CheckIfRightProduct(productCode);

        }
        //[Order(2)]
        //[TestCase("97.50")]

        //public void TestIfProductWith SpecificCodeIsInTheBasket()
        //{
        //    _teidaVisosPrekesPage5_1.NavigateToDefaultPage()
        //       .ClickKamuoliukas10();
        //    _teidaKamuoliukas10Page6.NavigateToDefaultPage()
        //        .ClickButtonIKrepseli1()
        //        .CheckKrepselisResult();
        //    _teidaKrepselisPage8.NavigateToDefaultPage()
        //   .ClickButtonIstrynti();

        //    .ClickSumazinti1();
        //}

        //[Test]

        //public void TestPrekesKrepselis()

        //{

        //    _teidaVisosPrekesPage5_1.NavigateToDefaultPage()

        //    .ClickKamuoliukas10();
        //    _teidaKamuoliukas10Page6.NavigateToDefaultPage()

        //     .ClickButtonIKrepseli1();
        //    _teidaKrepselisPage8.NavigateToDefaultPage();
        //    _teidaVisosPrekesPage5_1.NavigateToDefaultPage()
        //    .ClickKamuoliukas8();
        //    _teidaKamuoliukas8Page7.NavigateToDefaultPage()
        //    .ClickButtonIKrepseli2();
        //    _teidaKrepselisPage8.NavigateToDefaultPage();

        //}
        ///*
        //[Test]

        //public void TestIstryntiPrekes()
        //{
        //    _teidaKamuoliukas8Page7.NavigateToDefaultPage()
        //        .ClickButtonIKrepseli2();

        //    _teidaKrepselisPage8.NavigateToDefaultPage()
        //       .ClickSumazinti1()
        //         .ClickSumazinti2();
        //}

        //        /*.ClickKamuoliukas10()
        //        .ClickButtonIstrynti()
        //        .ClickKamuoliukas8()
        //        .ClickButtonIstrynti();*/




        //[Test]
        //public void TestKrepselis(string preke1)
        //{
        //    _teidaPagrindinisPage1.NavigateToDefaultPage()
        //        .InsertInputLaukelis("310.031")
        //        .ClickPaieska()
        //        .ClickKamuolys();
        //    _kamuolysPage100.NavigateToDefaultPage()
        //       .ClickKrepselis3()
        //       .ClickPagrindinisKrepselis();
        //    _krepselis101.NavigateToDefaultPage();



        //}








    }
}
