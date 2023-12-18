 int n=Convert.ToInt32(Console.ReadLine());
void  task1(int n)
{
    if (n == 1) { System.Console.Write(1+" ");}
    else{
        task1(n-1);
        System.Console.Write(n+" ");
        
    }
     
    
}
task1(n);
