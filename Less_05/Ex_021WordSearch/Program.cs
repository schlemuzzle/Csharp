﻿// Перебор слов
//В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова,
//состоящие из T букв, которые можно построить из букв этого алфавита/

Console.Clear();

char[] s = { 'а', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");// для варианта слов из 5 букв
                }
            }
        }
    }
}


int z = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{z++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);