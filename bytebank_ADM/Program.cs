using bytebank_ADM.Comercial;
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Funcionarios.Utilitarios;
using bytebank_ADM.SistemaInterno;

#region
//GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

//Funcionario lucas = new Diretor("Lucas Teixeira", "123456789");
//Funcionario roberta = new Diretor("Roberta Silva", "213454653");


//gerenciador.Registrar(roberta);
//gerenciador.Registrar(lucas);

//lucas.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Lucas: {lucas.Salario} \nRoberta: {roberta.Salario}");
#endregion

UsarSistema();
void CalcularBonificacao() 
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("Ulisses Souza", "123456");
    Diretor paula = new Diretor("Paula Tejano", "654321");
    Auxiliar igor = new Auxiliar("Igor Moura", "412312");
    GerenteDeContas camila = new GerenteDeContas("Camila Silva", "2324556");

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de Bonificação = {gerenciador.TotalBonificacao}");
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("Ingrid Guimarães", "2345678");
    ingrid.Login = "igd123";
    ingrid.Senha = "123";

    GerenteDeContas guilherme = new GerenteDeContas("Guilherme Briggs", "1223334444");
    guilherme.Login = "gui321";
    guilherme.Senha = "321";

    Auxiliar henrique = new Auxiliar("Henrique Magalhães", "2345678");
    // henrique.Senha = "505";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "111";
    caio.Senha = "222";

    sistema.ValidarLogin(ingrid,"igd123", "123");
    sistema.ValidarLogin(guilherme, "gui321", "321");
    sistema.ValidarLogin(caio, "111", "222");
    // sistema.ValidarLogin(henrique, "505");
}