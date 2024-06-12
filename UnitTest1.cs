using tp_lab3;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void T_001_СheckPermissions_Storage()
        {
            bool expectedReturnValue = true;
            bool actualReturnValue = false;

            Assert.DoesNotThrow(() =>
            {
                var form = new CreateEventPopup();
                actualReturnValue = form.CheckStoragePermission();
            });

            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        [Test]
        public void T_002_СheckPermissions_Contacts()
        {
            bool expectedReturnValue = true;
            bool actualReturnValue = false;

            Assert.DoesNotThrow(() =>
            {
                var form = new CreateEventPopup();
                actualReturnValue = form.CheckContactsPermission();
            });

            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        [Test]
        [TestCase("День тормозного диска")]
        [TestCase("День кафельной плитки")]
        [TestCase("")]
        [TestCase("День рождения")]
        public void T_003_TrySaveEventData_BaseFlow(String value)
        {
            String Date = "17.11";
            String EventName = value;
            String PersonName = "Олег";

            bool expectedReturnValue = true;
            bool actualReturnValue = false;

            Assert.DoesNotThrow(() =>
            {
                var temp = new MockTrySaveEventData();
                actualReturnValue = temp.TrySaveEventData(Date, EventName, PersonName);
            });

            Assert.AreEqual(expectedReturnValue, actualReturnValue);
        }

        [Test]
        public void T_004_TrySaveEventData_EmptyDate()
        {
            String Date = "";
            String EventName = "День тормозного диска";
            String PersonName = "Олег";

            String expectedExceptionMessage = ExceptionStrings.EmptyDate;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                var temp = new MockTrySaveEventData();
                temp.TrySaveEventData(Date, EventName, PersonName);
            });
            Assert.IsNotNull(exception);

            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        [Test]
        public void T_005_TrySaveEventData_EmptyEventName()
        {
            String Date = "17.11";
            String EventName = "";
            String PersonName = "Олег";

            String expectedExceptionMessage = ExceptionStrings.EmptyEventName;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                var temp = new MockTrySaveEventData();
                temp.TrySaveEventData(Date, EventName, PersonName);
            });
            Assert.IsNotNull(exception);

            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }

        [Test]
        public void T_006_TrySaveEventData_EmptyPersonName()
        {
            String Date = "17.11";
            String EventName = "День тормозного диска";
            String PersonName = "";

            String expectedExceptionMessage = ExceptionStrings.EmptyPersonName;

            Exception? exception = Assert.Throws<Exception>(() =>
            {
                var temp = new MockTrySaveEventData();
                temp.TrySaveEventData(Date, EventName, PersonName);
            });
            Assert.IsNotNull(exception);

            Assert.AreEqual(expectedExceptionMessage, exception.Message);
        }
    }
}