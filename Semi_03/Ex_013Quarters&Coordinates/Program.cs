Console.Clear();
Console.WriteLine("Введите номер четверти: ");
int quart = int.Parse(Console.ReadLine());

switch (quart)
{
    case 1:{
        Console.WriteLine("Возможный диапазон координат: X>0 и Y>0");
        break;}
    case 2:{
        Console.WriteLine("Возможный диапазон координат: X<0 и Y>0");
        break;}
    case 3:{
        Console.WriteLine("Возможный диапазон координат: X<0 и Y<0");
        break;}
    case 4:{
        Console.WriteLine("Возможный диапазон координат: X>0 и Y<0");
        break;}
    default:{ // default - если не одно из case не выполнилось - работает он.
        Console.WriteLine("Введен неверный номер четверти");
        break;}
}