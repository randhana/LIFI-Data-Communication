#include "SendData.h"
using namespace std;

Send::Send(byte int_LED) {
  this->int_LED = int_LED;
  init();
}
void Send::init() {
  pinMode(int_LED, OUTPUT);
  off();
}
void Send::send_data(string msg) {
  
for (int i = 0; i < msg.length(); i++)
  {
    ascii = msg[i];
    digitalWrite(data, HIGH);
    delay(100);
    digitalWrite(data, LOW);
    delay(100);
    digitalWrite(data, LOW);
    delay(100);
    digitalWrite(data, HIGH);
    delay(100);
    digitalWrite(data, HIGH);
    delay(100);
    digitalWrite(data, LOW);
    delay(100);
    digitalWrite(data, LOW);
    delay(100);
    digitalWrite(data, HIGH);
    delay(100);
    for (int j1 = 7; j1 >= 0; j1--)
    {
      if (bitRead(ascii, j1) == 1)
      {
        digitalWrite(data, HIGH);
        delay(100);
        digitalWrite(data, LOW);
        delay(100);
        
      }
      else
      {
        digitalWrite(data, LOW);
        delay(100);
        digitalWrite(data, HIGH);
        delay(100);
        
      }
    }
   
  }


}
