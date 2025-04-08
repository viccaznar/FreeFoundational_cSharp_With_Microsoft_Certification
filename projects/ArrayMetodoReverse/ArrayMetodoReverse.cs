using System;
using System.Collections.Generic;
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1 -Instancia de Array "message" e Metodo Split() com espaço em branco como separador
string[] message = pangram.Split(' ');

// Step 2 - Instancia de Array "newMessage" com o tamanho do array "message"
string[]newMessage = new string[message.Length];

// Step 3 - Iterar com "for" pelo Array "message", Instancia de char "letters" para reverter cada letra
// e Instancia "newMessage" para armazenar as letras em reverso
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

// Step 4 -
string result = String.Join(" ", newMessage);

Console.WriteLine(result);