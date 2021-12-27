using System;

public class Base{

  public delegate void DelegateClass();//델리게이트 클래스 생성

  public DelegateClass Click = null; //클래스로 객체Click 만듦.

  public Base(){
    Click = new DelegateClass(xxx);//Click에 xxx함수를 연결!
  }

  public void xxx(){
    Console.WriteLine("클릭!");
  }

  public void OnClick(){  //OnClick()
    if(Click != null)
      Click();
  }
}

class Delegate{
  public static void Main(){

    Base gildong = new Base();
    gildong.OnClick();  //OnClick()을 이용해 Click이 null이 아닐 때만 호출.
  }
}
//!!!TEST!!!
델리게이트가 있는 이유는
 닷넷 응용 프레임워크에서 아직 우리가 만들지 않은 핸들러 함수
  xxx를 호출할 수 있도록하기 위하여
  //!!!TEST!!!
