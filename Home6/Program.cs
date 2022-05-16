Console.WriteLine("введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine()); 
int[] digits = new int[3];
digits[0] = a%10;
digits[1] = a/10%10;
digits[2] = a/100%10;
int result = digits[0]*10000+digits[1]*1000+digits[2]*100+digits[1]*10+digits[0]*1;
if (a == result) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}
