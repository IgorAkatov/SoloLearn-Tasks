string myName = Console.ReadLine()!;
int agents = Convert.ToInt32(Console.ReadLine());
string[] costumers = Console.ReadLine()!.Split(' ');

//count считает количество человек перед тобой в очереди
int count = 0;
for (int i = 0; i < costumers.Length; i++)
{
    count = string.Compare(myName, costumers[i]) > 0 ? ++count : count;
}
// получим группу, в которой ты зайдешь в кабинет
int result = count / agents;
// теперь время выхода твоей группы из кабинета
result = result * 20 + 20;
Console.WriteLine(result);
