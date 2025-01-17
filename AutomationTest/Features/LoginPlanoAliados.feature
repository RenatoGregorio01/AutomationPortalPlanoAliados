Feature: Login Plano Aliados

  Scenario: Realizar login com sucesso
    Given que esteja na tela inicial de login
    When preencho o campo CPF
    When preencho o campo senha
    When clico no botão login
    Then valido a mensagem de login com sucesso
