int n=Convert.ToInt32(Console.ReadLine());
void  task1(int n)
{
    if (n <= 0) { System.Console.Write("");}
    else{
      task1(n/10);
        System.Console.Write(n%10+" ");
          
    }
     
    
}
task1(n);
