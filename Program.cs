string greeting="Salom, yangi foydalanuvchi, ahvollaringiz qalay!";
Console.WriteLine(greeting);
Console.Write("Iltimos, ismingizni kiriting: ");
string userName = Console.ReadLine();

Console.WriteLine($"Qoyil! {userName} biz endi sizning ismingizni bilamiz!");
int keschaAge = 4;
System.Console.WriteLine($"Kesha to'tiqushining yoshi {keschaAge}da");
System.Console.Write("Sizning yoshingiz nechchida?: ");
string ageAastring = Console.ReadLine();
int age = Convert.ToInt32(ageAastring);
System.Console.WriteLine($"Barakalla {userName} siz {2023-age}-yilda tug'ilgansiz!");
System.Console.WriteLine($"Kesha to'tiqushi va  sizning yoshingiz o'rtasidagi farq {age-keschaAge} yoshni tashkil qiladi");

