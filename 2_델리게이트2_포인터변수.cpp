#include <stdio.h>

void xxx(){
  printf("Hello");
}

void main(){
  //void xxx()* Click;  //Click은 xxx()를 가리킬 수 있다. //'*' -> 리턴값이 없고 파라미터가 없는 모든 값(함수?) 가리킬 수 있음.

  /*
  void xxx(* Click)();
  Click=xxx;  //Click은 포인터 상수 =xxx함수가 들어있는 주소값.
  */
  void (*Click)();
  Click=xxx;

  //xxx();
  Click();  //Click=변수 ->xxx대신 사용하는 델리게이트
}
