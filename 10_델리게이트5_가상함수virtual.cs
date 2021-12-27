using System;

//Base클래스를 라이브러리로 사용하려면 -> 항상 사용될 코드만 들어있어야함.
public class Form{

  public delegate void EventHandler();

  public EventHandler Click = null;

  public virtual void OnClick(){  //OnClick을 가상함수로 바꾸기.
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

  public override void OnClick(){ //override=재정의 하는 순간 가상함수는 없는 함수가 됨.
    base.Onclick(); //기존의 OnClick();함수도 호출
    Console.WriteLine("새로 정의한 OnClick 함수")  //override된 값 출력


  }
}

class Application{
  /*
  public static void Run(Derived imsi){
    Form gildong = imsi;
    gildong.OnClick();
  }
  */
  public static void Run(Form gildong){
    gildong.OnClick();
  }
}

class Delegate{
  public static void Main(){
    /*
    Derived aaa = new Derived();  //aaa라는 Derived객체가 만들어짐.
    Application.Run(aaa);  //Run은 객체를 만들지 않아도 실행할 수 있는 정적멤버함수.  //aaa를 파라미터로 줌.
   */
   Application.Run(new Derived());  //얼굴먼저호출!!->Derived에 클릭 실행!!
  }
}
