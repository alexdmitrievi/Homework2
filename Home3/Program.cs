Console.WriteLine("введите номер четверти");
int a = Convert.ToInt32(Console.ReadLine()); 
if (a==1) {
    Console.WriteLine("x - положительное число");
    Console.WriteLine("y - положительное число");
}
else if (a==2){
    Console.WriteLine("x - отрицательное число");
    Console.WriteLine("y - положительное число");
}
else if (a==3){
    Console.WriteLine("x - отрицательное число");
    Console.WriteLine("y - отрицательное число");
}
else {
    Console.WriteLine("x - положительное число");
    Console.WriteLine("y - отрицательное число");
}