Console.WriteLine("napiš čitatel");
double citatel = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("napiš jmenovatel");
double jmenovatel = Convert.ToDouble(Console.ReadLine());
double výsledek = citatel / jmenovatel;
string výsledekstring = výsledek.ToString();
int lenght = výsledekstring.Length;
if(lenght == 18)
{
    Console.WriteLine("(" + výsledekstring.Substring(0, 3) + ")");


}else
{
    Console.WriteLine(výsledek);
}
