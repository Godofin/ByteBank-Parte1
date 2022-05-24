/*Contrataram você para desenvolver um sistema de gerenciamento de produtos destinado ao 
estoque do Supermercado Menor Preço. O cliente informou a necessidade de cadastrar informações sobre 
o nome, fabricante, código de barras, valor unitário, valor de compra e quantidade em estoque de 
determinado produto.*/

using estoque;

Estoque produto1 = new Estoque();

produto1.nome = "Batata";
produto1.fabricante = "Ruffles";
produto1.codigoBarras = 7891234564789;
produto1.valorUnitario = 1.50;
produto1.valorCompra = 0.25;
produto1.quantidadeEstoque = 50;

Console.WriteLine($"Nome: {produto1.nome}\n" +
    $"Nome do Fabricante: {produto1.fabricante}\n" +
    $"Barcode: {produto1.codigoBarras}\n" +
    $"Valor Unitário: {produto1.valorUnitario}\n" +
    $"Valor compra: {produto1.valorCompra}\n" +
    $"Quantidade Estoque: {produto1.quantidadeEstoque}");
