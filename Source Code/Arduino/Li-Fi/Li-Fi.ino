#include <SendData.h>

 
 // Pin for transmitting light through int_LED
const int int_LED = D1;
const int int_LDR = A0;

void send_data(String msg);
void receive();

// String to be sent
String string_Serial_TEXT ;
int int_ASCII_Value;

String bit_Patten = "00000000";
String br = "";
int int_LDR_Value;
//int THRESHOLD;
int THRESHOLD =1001;

//Tempory variables for calculations
int x, y, te, j, k, temp = 0;

//1Byte = 8bits
int int_Bits = 7;

void setup()
{
  
  pinMode(int_LDR, INPUT);
  pinMode(int_LED, OUTPUT);
  Serial.begin(9600);
  delay(1000);

  delay(5000);
 // THRESHOLD =  analogRead(int_LDR) +100;
}

void loop()
{
  receive();
  //Serial.println(analogRead(int_LDR));
  if (Serial.available())
  {
    string_Serial_TEXT = Serial.readString();
    send_data(" DEVICE: ");
    send_data(string_Serial_TEXT);
    send_data("\n");
    
    Serial.print("ME: ");
    Serial.println(string_Serial_TEXT);
    
    Serial.flush();
    
  }
  else
  {
    
    digitalWrite(int_LED, HIGH);  //idel status
    
  }
}

void send_data(String msg)
{
  for (int i = 0; i < msg.length(); i++)
  {
    int_ASCII_Value = msg[i];
    digitalWrite(int_LED, HIGH);
    delay(100);
    digitalWrite(int_LED, LOW);
    delay(100);
    digitalWrite(int_LED, LOW);
    delay(100);
    digitalWrite(int_LED, HIGH);
    delay(100);
    digitalWrite(int_LED, HIGH);
    delay(100);
    digitalWrite(int_LED, LOW);
    delay(100);
    digitalWrite(int_LED, LOW);
    delay(100);
    digitalWrite(int_LED, HIGH);
    delay(100);
    for (int j1 = 7; j1 >= 0; j1--)
    {
      if (bitRead(int_ASCII_Value, j1) == 1)
      {
        digitalWrite(int_LED, HIGH);
        delay(100);
        digitalWrite(int_LED, LOW);
        delay(100);
        
      }
      else
      {
        digitalWrite(int_LED, LOW);
        delay(100);
        digitalWrite(int_LED, HIGH);
        delay(100);
        
      }
    }
   
  }
  

}

void receive()
{
  int_LDR_Value = analogRead(int_LDR);
  
  k++;
  temp += int_LDR_Value;
  if (int_LDR_Value > THRESHOLD)
    bit_Patten = bit_Patten.substring(1) + "1";
  else
    bit_Patten = bit_Patten.substring(1) + "0";
  if (bit_Patten.equals("10011001"))
  {
    y = 0;
    for (int i = 15; i >= 0; i--)
    {
      delay(100);
      int_LDR_Value = analogRead(int_LDR);
      k++;
      temp += int_LDR_Value;
      if (int_LDR_Value > THRESHOLD)
        br = br + "1";
      else
        br = br + "0";
     
      if (br.equals("01"))
      {
        x = 0;
        br = "";
        
        y += 0;
        int_Bits--;
      }
      else if (br.equals("10"))
      {
        x = 1;
        br = "";
        j = int_Bits;
        te = 1;
        while (j--)
          te = te * 2;
        y += x * te;
        int_Bits--;
      }
      else if (br.length() > 2)
        br = "";
      
    }
    int_Bits = 7;
    bit_Patten = "00000000";
    Serial.print((char)y);
    
  }
  if (k >= 24)
  {
    THRESHOLD = temp / k;   //get average threshold
    k = 0;
    
    temp = 0;
   
  }
  delay(100);
}

