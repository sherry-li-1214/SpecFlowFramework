using ApiLibrary.RequestDTO;
using System;
using WebLibrary.Pages;

namespace SeleniumSpecFlow.Utilities
{
    public class ObjectFactory
    {
        public Lazy<DriverFactory> DriverFactory = new Lazy<DriverFactory>();

        public Lazy<NewUserCreationPayLoad> PayLoad = new Lazy<NewUserCreationPayLoad>();

        public Lazy<LoginPage> LoginPage = new Lazy<LoginPage>(() => new LoginPage(Hooks.Driver));

        public Lazy<HomePage> HomePage = new Lazy<HomePage>(() => new HomePage(Hooks.Driver));
        public Lazy<HomeLoansPage> HomeLoanPage = new Lazy<HomeLoansPage>(() => new HomeLoansPage(Hooks.Driver));
        public Lazy<QuestionsListPage> QuestionsListPage = new Lazy<QuestionsListPage>(() => new QuestionsListPage(Hooks.Driver));


        public Lazy<CallBackFormPage> CallBackFormPage = new Lazy<CallBackFormPage>(() => new CallBackFormPage(Hooks.Driver));

    }

}