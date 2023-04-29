

int x = 456,y=782,z=918;




 int secondNum(int r){
  int a = int.Parse(Convert.ToString(r)[1].ToString());
  return a; 
}

Console.Write(secondNum(x)+" ");
Console.Write(secondNum(y)+" ");
Console.WriteLine(secondNum(z)+" ");


int d=645,s=78,a=32679;

 void thirdNum(int r){

    String s  = Convert.ToString(r);
  if(s.Length<3){
    String f  = "Третьей цифыры нет";
    Console.Write(f+" ");
  }else{
    int o = int.Parse(Convert.ToString(r)[2].ToString());
    Console.Write(o+" ");
  }

}

thirdNum(d);
 thirdNum(s);
 thirdNum(a);
Console.WriteLine();


int h=6,j=7,k=1;
Boolean weekend(int r){
    if(r>7||r<6){ return false;
    }else return true;

}
Console.Write(weekend(h)+" ");
Console.Write(weekend(j)+" ");
Console.Write(weekend(k)+" ");