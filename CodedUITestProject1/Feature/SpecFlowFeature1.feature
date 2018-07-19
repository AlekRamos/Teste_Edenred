#language: pt-br

@TestFeature 
Funcionalidade: Cadastrar email Blog ESPP
	Como um usuário desejo cadastrar meu email para receber atualizações

@Browser_Chrome
@TestScenario
    Cenário: Cadastro do email para recebimento de atualizações
	Dado que eu acesse a pagina "Edenred"
	Quando eu clicar no link "Blog"
	E no campo "O que você procura" eu digitar "Pre pago"
	E eu clicar no botão "Buscar"
	E eu aguardar por "5" segundos
	E eu clicar no botão "Assinar"
