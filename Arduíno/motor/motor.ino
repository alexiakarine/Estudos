#include <Servo.h>

Servo servo;
int pos;
void setup() {
  Serial.begin(9600);
  servo.attach(6);
  servo.write(0);
  delay(1000);
}

void loop() {
  Serial.println("Iniciando");
  for(pos=0; pos<180;pos+=5)
  {
    Serial.println("Mover + 5");
    servo.write(pos);
    delay(15); 
  }
  for(pos=180; pos>=0;pos-=5)
  {
    Serial.println("Mover - 5");
    servo.write(pos);
    delay(15); 
  }
  
}
