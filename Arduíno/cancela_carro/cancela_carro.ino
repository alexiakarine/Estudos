#include <Ultrasonic.h>
#include <Servo.h>

float centimetro;
long leituradosensor; 
Ultrasonic ultrasonic(5,4);

Servo servo;

void setup() {
  Serial.begin(9600);
  servo.attach(6); // Referente a porta do final laranja
  servo.write(0);
  delay(1000);
}

void loop() {
  
  leituradosensor = ultrasonic.timing();
  centimetro = ultrasonic.convert(leituradosensor,Ultrasonic::CM);
  Serial.println(centimetro);
  if(centimetro<=15){
    servo.write(90);  
  }
  else{
    servo.write(0);  
  }
}
