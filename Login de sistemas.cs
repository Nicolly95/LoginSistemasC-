/* Esse projeto de login de acesso a um sistema interno, permite que apenas quem tem direitos 
de Administrador da empresa, possa logar ou conceder acesso.
Níveis abaixo do administrativo, como Gerentes e demais, não terão acesso livre permitido.
*/

/* Esse projeto exercita o uso do Pipe (|) para escolha entre opções estabelecidas, exercita o uso do 
método .Contains() (verifica se na sua variável contêm um nome específico), exercita a leitura de dados
de entrada do usuário e saídas, exercita condicionais IF e ELSE IF com lógica de programação.
*/

/* Dificuldades encontradas por mim neste desafio: 
Conseguir fazer com que o compilador retorne a frase correta de acordo com o nível de acesso do usuário.
*/

string permissao = "Admin|Gerente";
int nivel = 0;

Console.WriteLine($"Qual o seu cargo? {permissao}");
Console.ReadLine();
Console.WriteLine($"Qual o seu nível de acesso? {nivel}");
Console.ReadLine();


if (permissao.Contains("Admin"))
{
    if (nivel > 55)
    {
        Console.WriteLine("Bem vindo, Super usuário Administrador.");
    }
    else
    {
        Console.WriteLine("Bem vindo, usuário Administrador.");
    }
}
else if (permissao.Contains("Gerente"))
{
    if (nivel >= 20)
    {
        Console.WriteLine("Contate um Administrador para o acesso.");
    }
    else
    {
        Console.WriteLine("Você não tem privilégios suficientes para o acesso.");
    }
}
else
{
    Console.WriteLine("Você não tem privilégios suficientes para o acesso.");
}

/* CONSIDERAÇÕES FINAIS:
Este projeto será aprimorado futuramente para funcionar corretamente, 
de acordo com os meus conhecimentos vigentes.
*/