using System.Windows.Forms;
using System;

class Derived:Form{
  public Derived(){ //생성자 함수
    Click += new EventHandler(xxx);
  }

  public void xxx(object o, EventArgs e){
    System.Console.WriteLine("Click!");
  }
}

class My{
  public static void Main(){
    Application.Run(new Derived()); //new Derived()의 가상함수를 자동으로 호출해준다!!! //new Form->new Derived : 올바르게 Click실행됨.
  }
}
