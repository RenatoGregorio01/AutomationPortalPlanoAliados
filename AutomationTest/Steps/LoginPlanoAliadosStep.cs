using OpenQA.Selenium;
using Reqnroll;
using AutomationTest.Pages;
using Xunit;



namespace AutomationTest.Steps
{
    [Binding]
    public class LoginPlanoAliadosStep
    {
        private readonly LoginPlanoAliadosPage _loginPlanoAliadosPage;

        public LoginPlanoAliadosStep(IWebDriver driver)
        {
            _loginPlanoAliadosPage = new LoginPlanoAliadosPage(driver); 
        }

        [Given(@"que esteja na tela inicial de login")]
        public void GivenQueEstejaNaTelaInicialDeLogin()
        {
            _loginPlanoAliadosPage.OpenSite();
        }

        [When(@"preencho o campo CPF")]
        public void WhenPreenchoOCampoCpf()
        {
            _loginPlanoAliadosPage.FillUsername();
        }

        [When(@"preencho o campo senha")]
        public void WhenPreenchoOCampoPassword()
        {
            _loginPlanoAliadosPage.FillPassword();
        }

        [When(@"clico no botão login")]
        public void WhenClicoNoBotaoLogin()
        {
            _loginPlanoAliadosPage.ClickLogin();
        }

        [Then(@"valido a mensagem de login com sucesso")]
        public void ThenValidoAMensagemDeLoginComSucesso()
        {
           _loginPlanoAliadosPage.WaitElementSucessMessage();
            Assert.True(_loginPlanoAliadosPage.WaitElementSucessMessage(), "Enviado com sucesso!");
        }
    }
}
