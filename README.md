# Orientação a Objetos com C#

Comando para instalar o .net 6.0: `dotnet-install.ps1 -Channel 6.0 -Runtime aspnetcore`.
link: https://docs.microsoft.com/pt-br/dotnet/core/install/windows?tabs=net60


## Criação de uma Classe

Uma classe serve para que possamos reutilizar nosso código em vários projetos ou em outros códigos de maneira mais simples.

Para criar uma classe em C#, é necessário definirmos o parâmetro `namespace` com o nome da lib.

Para realizar a classe, é necessário definirmos se ela é pública ou privada, da seguinte maneira -> `public class NomeClasse`

Assim, podemos passar os atributos para a classe, como no exemplo a seguir:

---
public class ContaCorrente {
     public string titular;
     public string conta;
     public int numero_agencia;
     public string nome_agencia;
     public double saldo;
     public bool vaerificador;
}.
---
