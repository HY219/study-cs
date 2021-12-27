using System;

//Base클래스를 라이브러리로 사용하려면 -> 항상 사용될 코드만 들어있어야함.
public class Form{

  public delegate void EventHandler();

  public EventHandler Click = null;

  public void OnClick(){
    if(Click != null)
      Click();
  }
}

class Derived : Form{ //Form에 있는 코드를 재사용해서 Derived에서 사용.  //파생클래스

  public Derived(){
    Click = new EventHandler(xxx);
  }

  public void xxx(){
    Console.WriteLine("클릭!");
  }
}

class Delegate{
  public static void Run(){ //Run=정적멤버함수.
    Derived gildong = new Derived();
    gildong.Onclick();
  }

  public static void Main(){
    //Run(); //Run ->실행하는코드

    /*
    Delegate cheolsu = new Delegate();
    cheolsu.Run();
    */

    Run();  //Run은 객체를 만들지 않아도 실행할 수 있는 정적멤버함수.
  }
}
