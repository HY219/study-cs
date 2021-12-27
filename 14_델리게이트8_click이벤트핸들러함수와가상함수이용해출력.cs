using System.Windows.Forms;
using System;

class Derived:Form{
  public Derived(){
    Click += new EventHandler(xxx);
  }
  public void xxx(object o, EventArgs e){
    System.Console.WriteLine("클릭!");
  }
  protected override void OnClick(EventArgs e) {
    base.OnClick(e);
  }
}

class My{
  public static void Main(){
    Application.Run(new Derived());
  }
}
