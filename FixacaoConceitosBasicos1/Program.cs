
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */

/*Exercicios Fixação*/
using FixacaoConceitosBasicos1.Model;

Console.WriteLine($"O valor do metro em milimetros é: { MetrosMilimetros.Converter(1)}");
Console.WriteLine($"O salário com aumento é: { CalculoAumento.Calcular(1200, 20)}");
Console.WriteLine($"O valor com desconto é: {CalculaDesconto.Calcular(1350, 30)}");
Console.WriteLine($"O preço do aluguel é: {CalculaAluguelCarro.Calcular(10, 0, 10)}");




