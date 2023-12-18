int n=Convert.ToInt32(Console.ReadLine());
int  task(int n)
{ int sum=0;
    if (0 == n) return sum ;
    else{
      
      return sum=n+task(n-1);
    }
     
    
}

System.Console.WriteLine(task(n));