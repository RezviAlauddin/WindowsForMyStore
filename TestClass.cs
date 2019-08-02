using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFor
{
    [TestFixture]
    class TestClass
    {
        CheckDatabase ob = new CheckDatabase();
        ProductDatabase pd = new ProductDatabase();
        //login page
        [Test]
        public void Entry()
        {
            bool r = ob.Checkdb("Rezvi", "store_@dmin");
            Assert.IsTrue(r);

        }
        [Test]
        public void FalseEntry()
        {
            bool r = ob.Checkdb("Rezvi", "1234");
            Assert.IsFalse(r);

        }
        [Test]
        public void NullEntry()
        {
            Assert.Throws<NullReferenceException>(() => ob.Checkdb(" ", "1234"));
        }
        [Test]
        public void nullpass()
        {
            Assert.Throws<NullReferenceException>(() => ob.Checkdb("Rezvi", " "));

        }
        //SignUP
        [Test]
        public void CheckSignUp()
        {
            bool r = ob.ChSignUp("babu","12345", "babu@gmail","01721307969");
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckSignUpNullName()
        {
            Assert.Throws<NullReferenceException>(()=>ob.ChSignUp(" ", "147", "me@gmail.com", "01891302534"));
        }
        [Test]
        public void CheckSignUpNullPass()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChSignUp("abc", " ", "me@gmail.com", "01891302534"));
        }
        [Test]
        public void CheckSignUpNullPhone()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChSignUp("abd", "147", "me@gmail.com", " "));
        }


        //Update User
        [Test]
        public void CheckUpdateUser()
        {
            bool r = ob.ChUpdate("babu","babu", "babu007@gmail","0176123123");
            Assert.IsTrue(r);
        }


        [Test]
        public void CheckUpdateUserUpNullName()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChUpdate(" ", "147", "me@gmail.com", "01891302534"));
        }
        [Test]
        public void CheckUpdateuSERNullPass()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChUpdate("abc", " ", "me@gmail.com", "01891302534"));
        }
        [Test]
        public void CheckUpdateUserNullPhone()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChUpdate("abd", "147", "me@gmail.com", " "));
        }

        //Delete User
        [Test]
        public void CheckDeleteUser()
        {
            bool r = ob.ChDelete("babu", "babu", "babu007@gmail", "0176123123");
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckDeleteUserNullName()
        {
            Assert.Throws<NullReferenceException>(() => ob.ChDelete(" ", "babu", "babu@gmail.com", "0176123123 "));
        }
        //product page
        [Test]
        public void Checkinsert()
        {
            bool r = pd.CheckProDbins("mp102","male pant",200,89) ;
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckinsNullCode()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbins(" ", "male pant", 200, 90));
        }
        [Test]
        public void CheckinsNullName()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbins("ms001", " ", 200, 90));
        }
        [Test]
        public void CheckinsZeroPrce()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbins("ms001", "male pant", 0, 90));
        }
        [Test]
        public void CheckinsZeroAmunt()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbins("ms001", "male pant", 200, 0));
        }
        [Test]
        public void CheckUpdate()
        {
            bool r = pd.CheckProDbUp("ms001", "male shrt", 100, 80);
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckUpdateNullCode()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbUp(" ", "male pant", 200, 90));
        }
        [Test]
        public void CheckUpdateNullName()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbUp("ms001", " ", 200, 90));
        }
        [Test]
        public void CheckUpdateZeroPrce()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbUp("ms001", "male pant", 0, 90));
        }
        [Test]
        public void CheckUpdateZeroAmunt()
        {
            Assert.Throws<NullReferenceException>(() => pd.CheckProDbUp("ms001", "male pant", 200,0));
        }
        [Test]
        public void CheckDelete()
        {
            bool r = pd.CheckProDbDe("ms001", "male shrt", 210,90);
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckDeleteNullCode()
        {
            Assert.Throws<NullReferenceException>(()=>pd.CheckProDbDe(" ","male pant",200,90));
        }
        [Test]
        public void CheckSearchProduct()
        {
            bool r = pd.ChSearch("male pant");
            Assert.IsTrue(r);
        }
        [Test]
        public void CheckSearchProductNullName()
        {
            Assert.Throws<NullReferenceException>(()=>pd.ChSearch(" "));
        }
    }
}
