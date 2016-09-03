#include <Servo.h>

unsigned int incBuff1 = 0;
unsigned int incBuff2 = 0;
int i = 0;

Servo servo1;
Servo servo2;

void setup() {
  // put your setup code here, to run once:
  //servo.attach(3, 1280, 1510);
  servo1.attach(3);
  servo2.attach(5);
  Serial.begin(9600);
  int dec = 1;
}

void loop() {
  // put your main code here, to run repeatedly:
  i = 0;
  incBuff1 = 0;
  incBuff2 = 0;
  bool flag = false;
  bool second = false;
  while (Serial.available() > 0){
    flag = true;
    int val = Serial.read();
    if(val == 255) {
      second = true;
      continue;
    }
    if(!second)
      incBuff1 = val;
     else
      //incBuff2 = incBuff2*10 + (val-48);
      incBuff2 = val;
    i += 1;
  }
  if(flag) {
    int msecs1 = 800.0f*((float)incBuff1/254.0f);
    int msecs2 = 800.0f*((float)incBuff2/254.0f);
    Serial.println(msecs1, DEC);
    Serial.println(msecs2, DEC);
    servo1.writeMicroseconds(1060 + msecs1);
    servo2.writeMicroseconds(1060 + msecs2);
  }
  // //1060 - 1860
  delay(100);
}
