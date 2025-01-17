using AutomationTest.Steps;
using AutomationTest.Utilities;
using Xunit;



namespace AutomationTest.Tests
{
    public class LoginPlanoAliadosTest : BaseTest
    {
        private readonly LoginPlanoAliadosStep _loginPlanoAliadosStep;
        public LoginPlanoAliadosTest()
        {
            _loginPlanoAliadosStep = new LoginPlanoAliadosStep(Driver); 
        }

        [Fact]
        public void LoginTest_ValidCredentials_ShouldSucceed()
        {
            _loginPlanoAliadosStep.GivenQueEstejaNaTelaInicialDeLogin();
            _loginPlanoAliadosStep.WhenPreenchoOCampoCpf();
            _loginPlanoAliadosStep.WhenPreenchoOCampoPassword();
            _loginPlanoAliadosStep.WhenClicoNoBotaoLogin();
            _loginPlanoAliadosStep.ThenValidoAMensagemDeLoginComSucesso();
            ScreenshotHelper.TakeScreenshot(Driver, "LoginSuccess.png");
        }
    }
}
