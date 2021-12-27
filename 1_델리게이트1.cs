using System;

public class Base{
  public void xxx(){
    Console.WriteLine("클릭!");
  }
}

class Delegate{
  public static void Main(){
    //System.Console.WriteLine("Hello World!");
    Base gildong = new Base();
    gildong.Click();  //Click은 xxx함수의 델리게이트(xxx대신 사용하는 것)
  }
}
