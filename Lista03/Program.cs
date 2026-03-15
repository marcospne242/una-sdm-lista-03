using System;
using Lista03.Models;

Livro livro = new Livro
{
    Titulo = "Clean Code",
    Autor = "Robert C. Martin",
    Ano = 2008,
    Genero = "Programação",
    Disponivel = true
};

Console.WriteLine($"Livro: {livro.Titulo} - Autor: {livro.Autor}");
