using FlaUI.Core.AutomationElements;
using FlaUI.Core.Tools;
using FlaUI.UIA3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_lab3;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestProject
{
    internal class UiTest
    {
        /// <summary>Путь до исполняемого файла приложения для тестирования</summary>
        string PathTestingApp = @"D:\Учеба\vs projects\tp_lab4\tp_lab4\tp_lab3\tp_lab3\bin\Debug\net8.0-windows\tp_lab3.exe";

        /// <summary>время мс допустимой задержки</summary>
        int M = 5000;

        //текст внутри элементов управления
        const string GreetingsFormNameString = "GreetingsForm";
        const string ErrorLabelString = "Выберите одну из опций ниже";
        const string SendCardButtonString = "Поздравить другого";
        const string EventsButtonString = "События";
        const string CardsButtonString = "Открытки";

        //automatisation-id для элементов управления
        const string idErrorLabel = "ErrorLabel";
        const string idSendCardButton = "SendCardButton";
        const string idEventsButton = "EventsButton";
        const string idCardsButton = "CardsButton";


        public T WaitForElement<T>(Func<T> getter)
        {
            var retry = Retry.WhileNull<T>
                (
                getter,
                TimeSpan.FromMilliseconds(M)
                );

            if (!retry.Success)
            {
                Assert.Fail($"Невозможно найти элемент {M} ms");
            }

            return retry.Result;
        }

        /// <summary>проверяем нажатие кнопок "События" и кнопки "ОК" в диалоговом окне</summary>
        [Test]
        public void T_001_GreetingsForm_EventsButton()
        {
            //Step #1
            FlaUI.Core.Application app = FlaUI.Core.Application.Launch(PathTestingApp, "3");

            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                //Окно приветствия
                string title = window.Title;
                Assert.AreEqual(GreetingsFormNameString, title);

                //получаем ссылки на все элементы управления
                var ErrorLabel = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idErrorLabel)).AsTextBox());

                //var SendCardButton = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idSendCardButton)).AsButton());
                var EventsButton = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idEventsButton)).AsButton());

                //Проверяем строки
                Assert.AreEqual(ErrorLabelString, ErrorLabel.Text);

                //Assert.AreEqual(SendCardButtonString, SendCardButton.AsLabel().Text);
                Assert.AreEqual(EventsButtonString, EventsButton.AsLabel().Text);

                //Step #2
                EventsButton.Click();
                System.Threading.Thread.Sleep(1000);
                window.CaptureToFile("EventsClicked.png");

                var retry = Retry.WhileException(() =>
                {
                    Assert.AreEqual("Нажато События", ErrorLabel.Text);

                }, TimeSpan.FromMilliseconds(M));

                if (!retry.Success)
                {
                    Assert.AreEqual("Нажато События", ErrorLabel.Text);
                }

                //Step #3
                retry = Retry.WhileException(() =>
                {
                    var msg = window.ModalWindows.FirstOrDefault().AsWindow();

                    Assert.NotNull(msg);

                    var message = msg.FindFirstChild(cf => cf.ByText("Нажато События")).AsLabel();

                    Assert.NotNull(message);

                    //Step #04
                    var yesButton = msg.FindFirstChild(cf => cf.ByName("ОК")).AsButton();

                    Assert.NotNull(yesButton);

                    msg.CaptureToFile("okdialog.png");

                    yesButton.Click();

                }, TimeSpan.FromMilliseconds(M));


                if (!retry.Success)
                {
                    Assert.Fail("Нет диалогового окна");
                }

                System.Threading.Thread.Sleep(1000);

        }
        app.Close();
        }

        /// <summary>проверяем нажатие кнопок "Открытки" и кнопки "ОК" в диалоговом окне</summary>
        [Test]
        public void T_002_GreetingsForm_CardsButton()
        {
            //Step #1
            FlaUI.Core.Application app = FlaUI.Core.Application.Launch(PathTestingApp, "3");

            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                //Окно приветствия
                string title = window.Title;
                Assert.AreEqual(GreetingsFormNameString, title);

                //получаем ссылки на все элементы управления
                var ErrorLabel = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idErrorLabel)).AsTextBox());

                var CardsButton = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idCardsButton)).AsButton());

                //Проверяем строки
                Assert.AreEqual(ErrorLabelString, ErrorLabel.Text);

                Assert.AreEqual(CardsButtonString, CardsButton.AsLabel().Text);

                //Step #2
                CardsButton.Click();
                System.Threading.Thread.Sleep(1000);
                window.CaptureToFile("CardsClicked.png");

                var retry = Retry.WhileException(() =>
                {
                    Assert.AreEqual("Нажато Открытки", ErrorLabel.Text);

                }, TimeSpan.FromMilliseconds(M));

                if (!retry.Success)
                {
                    Assert.AreEqual("Нажато Открытки", ErrorLabel.Text);
                }

                //Step #3
                retry = Retry.WhileException(() =>
                {
                    var msg = window.ModalWindows.FirstOrDefault().AsWindow();

                    Assert.NotNull(msg);

                    var message = msg.FindFirstChild(cf => cf.ByText("Нажато Открытки")).AsLabel();

                    Assert.NotNull(message);

                    //Step #04
                    var yesButton = msg.FindFirstChild(cf => cf.ByName("ОК")).AsButton();

                    Assert.NotNull(yesButton);

                    msg.CaptureToFile("okdialog_2.png");

                    yesButton.Click();

                }, TimeSpan.FromMilliseconds(M));


                if (!retry.Success)
                {
                    Assert.Fail("Нет диалогового окна");
                }

                System.Threading.Thread.Sleep(1000);

            }
            app.Close();
        }

        /// <summary>проверяем нажатие кнопок "Поздравить другого" и кнопки "ОК" в диалоговом окне</summary>
        [Test]
        public void T_003_GreetingsForm_SendCardButton()
        {
            //Step #1
            FlaUI.Core.Application app = FlaUI.Core.Application.Launch(PathTestingApp, "3");

            using (var automation = new UIA3Automation())
            {
                var window = app.GetMainWindow(automation);

                //Окно приветствия
                string title = window.Title;
                Assert.AreEqual(GreetingsFormNameString, title);

                //получаем ссылки на все элементы управления
                var ErrorLabel = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idErrorLabel)).AsTextBox());

                var SendCardButton = WaitForElement(() => window.FindFirstDescendant(cf => cf.ByAutomationId(idSendCardButton)).AsButton());

                //Проверяем строки
                Assert.AreEqual(ErrorLabelString, ErrorLabel.Text);

                Assert.AreEqual(SendCardButtonString, SendCardButton.AsLabel().Text);

                //Step #2
                SendCardButton.Click();
                System.Threading.Thread.Sleep(1000);
                window.CaptureToFile("SendCardButtonClicked.png");

                var retry = Retry.WhileException(() =>
                {
                    Assert.AreEqual("Нажато Поздравить другого", ErrorLabel.Text);

                }, TimeSpan.FromMilliseconds(M));

                if (!retry.Success)
                {
                    Assert.AreEqual("Нажато Поздравить другого", ErrorLabel.Text);
                }

                //Step #3
                retry = Retry.WhileException(() =>
                {
                    var msg = window.ModalWindows.FirstOrDefault().AsWindow();

                    Assert.NotNull(msg);

                    var message = msg.FindFirstChild(cf => cf.ByText("Нажато Поздравить другого")).AsLabel();

                    Assert.NotNull(message);

                    //Step #04
                    var yesButton = msg.FindFirstChild(cf => cf.ByName("ОК")).AsButton();

                    Assert.NotNull(yesButton);

                    msg.CaptureToFile("okdialog_3.png");

                    yesButton.Click();

                }, TimeSpan.FromMilliseconds(M));


                if (!retry.Success)
                {
                    Assert.Fail("Нет диалогового окна");
                }

                System.Threading.Thread.Sleep(1000);

            }
            app.Close();
        }
    }
}
