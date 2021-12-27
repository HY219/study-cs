using System;

public class Base{
  /*
  public delegate int DelegateClass(int);//델리게이트 클래스 생성
  public DelegateClass Click; //클래스로 객체Click 만듦.

  public int xxx(int a){
    Console.WriteLine("클릭!");
  }
  */
  public delegate void DelegateClass();//델리게이트 클래스 생성

  //public void (*Click)(); //cs에서 변수를 만들려면 자료형이 있어야함.
  public DelegateClass Click; //클래스로 객체Click 만듦.
  //public DelegateClass Click = new DelegateClass(xxx);
  public Base(){  //생성자 함수(Class의 이름과 같게)
    Click = new DelegateClass(xxx);//Click에 xxx함수를 연결!
  }

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
