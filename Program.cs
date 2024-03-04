
//1.Int[]={2,5,6,7,8,10} Arraydaki ededlerin ededi ortasini hesablayan alqoritm qurun.

//int[] arr = { 2, 5, 6, 7, 8, 10 };

//int sum = 0;
//foreach(int i in arr)
//{
//    Console.WriteLine("Arraydaki eded"+i);
//    sum += i;
//    Console.WriteLine("Cemleri"+sum);

//}
//Console.WriteLine("Ededi orta"+sum/arr.Length);

//2.Asagidaki cedvelden istifade ederek musterinin alisveris meblegine uygun faizini teyin edin.
//Meblegi Consoldan daxil edin ve musterinin aldigi mehsul ucun odeyeceyi meblegi ekranda cap edin (if-else/switch-case)uazilacaq
//1.100 manatdan az-5% endirim
//2.100-1000 manat arasi -8%
//3.1000 manatdan cox-10%

//Console.WriteLine("Alis verisin meblegini daxil edin:");
//double mebleg= Convert.ToDouble(Console.ReadLine());
//double endirim;

//if(mebleg<100)
//{
//    endirim = 0.05;
//}
//else if(mebleg>=100 && mebleg<=1000)
//{
//    endirim= 0.08;
//}
//else
//{
//    endirim= 0.10;
//}

//double endirimMebleg = mebleg * endirim;
//double odenilecekMebleg = mebleg - endirimMebleg;

//Console.WriteLine("Odeyeceyiniz mebleg:"+odenilecekMebleg);
//Console.WriteLine("Sizin ucun endiriminiz:"+endirimMebleg);


//3.Istifadeci imtahan bali qeyd etsin, bu hala gore telebe imtahani kecidi ve ya kecmedi.(switch/case isledin)
//Kecibse A 90-100 bal, B 80-90 bal, C 70-80 bal, D 60-70 bal ,E 50-60 bal , kecmedise (50 den kicikdirse) F alsin


Console.WriteLine("Imtahan balini daxil edin:");
int bal= Convert.ToInt32(Console.ReadLine());
char not = ' ';

if(bal>=90 && bal<=100)
{
    not= 'A';
}
else if(bal >= 80 && bal <= 90)
{
    not = 'B';
}
else if (bal >= 70 && bal <= 80)
{
    not = 'C';
}
else if (bal >= 60 && bal <= 70)
{
    not = 'D';
}
else if (bal > 50 && bal <= 60)
{
    not = 'E';
}
else if (bal > 0 && bal < 50)
{
    not = 'F';
}
else
{
    Console.WriteLine("Duzgun bal daxil edin");
}

Console.WriteLine("netice:" + not);



