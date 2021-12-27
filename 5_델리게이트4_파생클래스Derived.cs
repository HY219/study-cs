using System;

//Base클래스를 라이브러리로 사용하려면 -> 항상 사용될 코드만 들어있어야함.
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

class Derived : Base{ //Base에 있는 코드를 재사용해서 Derived에서 사용.  //파생클래스

}
//Base =비하인드 클래스 ->사람(normal)
//Derived =프론트 클래스 ->남자(specific)

class Delegate{
  public static void Main(){

    //Base gildong = new Base();  //동일
    Derived gildong = new Drived();
    gildong.OnClick();  //OnClick()을 이용해 Click이 null이 아닐 때만 호출.
  }
}
