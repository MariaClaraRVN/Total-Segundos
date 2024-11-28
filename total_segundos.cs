using System;

class Program {
  public static void Main (string[] args) {
    int hora;
    int minutos;
    int segundos;
    int total;

    Console.WriteLine ("Informe a hora: ");
    hora = int.Parse(Console.ReadLine ());

    Console.WriteLine ("Informe os minutos: ");
    minutos = int.Parse(Console.ReadLine ());

    Console.WriteLine ("Informe os segundos: ");
    segundos = int.Parse(Console.ReadLine ());

    hora = hora * 60 * 60;
    minutos = minutos * 60;
    total = hora + minutos + segundos;

    Console.WriteLine ("Novo Valor em segundos é: " + total);
  }
}