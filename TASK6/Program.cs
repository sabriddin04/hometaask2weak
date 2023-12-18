void chet(int a,int b){
    if(a%2==0){
       if(a>=b){System.Console.WriteLine("");}
       else{
        System.Console.Write(a+" ");
        chet(a+2,b);
       }
    }
     else if(a%2!=0){
       if(a>=b){System.Console.WriteLine("");}
       else{
        System.Console.Write(a+1+" ");
        chet(a+2,b);
       }
    }
}
void nechet(int a,int b){
    if(a%2==0){
       if(a>=b){System.Console.WriteLine("");}
       else{
        System.Console.Write(a+1+" ");
        nechet(a+2,b);
       }
    }
     else if(a%2!=0){
       if(a>b){System.Console.WriteLine("");}
       else{
        System.Console.Write(a+" ");
        nechet(a+2,b);
       }
    }
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Четные числа:");
chet(a,b);
System.Console.WriteLine("НЕчетные числа:");
nechet(a,b);