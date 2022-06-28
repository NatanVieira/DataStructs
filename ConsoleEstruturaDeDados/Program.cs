using EstruturaDeDados;

namespace ConsoleEstruturaDeDados;

public class Programa {

    static void Main(string[] args) {

        //Testando a estrutura pilha
        //Pilha pilha = new Pilha();

        //pilha.push("1");
        //pilha.push("2");

        //Console.WriteLine($"Pilha: {pilha.ToString()}");

        //Console.WriteLine($"Retirando o último item da pilha: {pilha.pop()}");

        //Console.WriteLine($"Pilha: {pilha.ToString()}");

        //Console.WriteLine($"Retirando o último item da pilha: {pilha.pop()}");

        //Console.WriteLine($"Pilha: {pilha.ToString()}");

        //Testando a estrutura Fila

        Fila fila = new Fila();
        fila.Push(3); //inclui 3
        fila.Push(4); //inclui 4
        fila.Push(5); //inclui 5

        Console.WriteLine(fila.ToString()); //mostra 3,4,5

        Console.WriteLine(fila.Pop()); //retira o 3
        Console.WriteLine(fila.ToString()); // mostra 4,5

        fila.Push(20); //inclui 20
        fila.Push(30); //inclui 30
        Console.WriteLine(fila.ToString()); //mostra 4,5,20,30

        fila.Push(33); //inclui 33
        fila.Pop(); //retira o 4
        Console.WriteLine(fila.ToString()); //mostra 5,20,30,33
    }
}