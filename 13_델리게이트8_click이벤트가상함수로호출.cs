using System.Windows.Forms;
using System;

class Derived:Form{
  public Derived(){

  }

  protected override void OnClick(EventArgs e){
    System.Console.WriteLine("클릭!");
  }
}

class My{
  public static void Main(){
    Application.Run(new Derived());
  }
}
