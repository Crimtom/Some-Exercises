// See https://aka.ms/new-console-template for more information

//Arreglos

using System.Collections;

int[] numeros = new int[6];
int[] notas; //El new le agrega 0 a todos los espacios del arreglo
int[] salario = { 1500, 200, 4000 };
float[] precio = new float[] { 500.78f, 600.35f, 98.7f };

string[] nombres = new string[] { "John", "Rose", "Dave", "Jade" };

nombres = Enumerable.Repeat("-", 4).ToArray<string>(); //El ToArray convierte el resultado de ("-", 4) en un arreglo que se asigna al de nombres

Console.WriteLine($"Suma de salarios: {salario.Sum()}"); //Interpolar (El $ ayuda a que se pueda poner variables entre las comillas. Siempre y cuando estén dentro de llaves)

ArrayList arraylist = new ArrayList();

arraylist.Add(1);
arraylist.Add(2);
arraylist.Add("Gato");
arraylist.Add(255.13f);
arraylist.Add(true);

foreach (var dato in arraylist)
{
    Console.WriteLine(dato);
}

notas = new int[50];

foreach (int nota in notas)
{
    Console.WriteLine(notas[nota]);
}
int indice = 0;
while (indice < nombres.Length)
{
 //   Console.WriteLine(nombres[indice]);
}

for (int i = 0; i < nombres.Length; i++)
{
    nombres[i] = ":3";
}

foreach (var item in nombres)
{
    Console.WriteLine(item);
}

numeros[0] = 120;
numeros[1] = 64;
numeros[2] = 2002;
numeros[3] = 2015;
numeros[4] = 255;
numeros[5] = 2006;

Console.WriteLine(numeros.Length);

for (int i = 0; i < numeros.Length; i++) //i++ significa  i += 1
{
    Console.WriteLine(numeros[i]);
}

foreach (var numero in numeros)
{
    Console.WriteLine(numeros[numero]);
}

