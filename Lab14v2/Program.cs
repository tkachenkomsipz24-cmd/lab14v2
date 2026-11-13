using System;
using System.Collections.Generic;

namespace lab14v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Лабораторна робота №8: Делегати й лямбда-вирази у практиці колекцій ===\n");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            IEnumerable<string> stringNumbers = CollectionHelper<int>.Map(
                numbers,
                n => $"Число: {n} | Квадрат: {n * n}"
            );

            Console.WriteLine("--- Перетворення List<int> на IEnumerable<string> ---");
            foreach (string item in stringNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            List<Product> products = new List<Product>
            {
                new Product("Ноутбук", 32500.00m),
                new Product("Мишка", 850.50m),
                new Product("Клавіатура", 2100.00m)
            };

            IEnumerable<decimal> prices = CollectionHelper<Product>.Map(
                products,
                p => p.Price
            );

            Console.WriteLine("--- Перетворення List<Product> на IEnumerable<decimal> (ціни) ---");
            foreach (decimal price in prices)
            {
                Console.WriteLine($"Ціна товару: {price} грн");
            }
        }
    }
}