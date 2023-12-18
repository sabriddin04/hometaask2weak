int n=Convert.ToInt32(Console.ReadLine()); int cnt=0;
int  task1(int n)
{
   if(n>0){
    cnt++;
    return task1(n/10);
    
   }
   else return cnt;
     
    
}
System.Console.WriteLine(task1(n));
