#include <Ultrasonic.h>
int porta1 = 6;

float centimetro;
long leituradosensor; 
Ultrasonic ultrasonic(5,4);



void setup() {
  Serial.begin(9600);
  pinMode(porta1, OUTPUT);
}

void loop() {
  leituradosensor = ultrasonic.timing();
  centimetro = ultrasonic.convert(leituradosensor,Ultrasonic::CM);
  Serial.println(centimetro);
  if(centimetro<=30){
     tone(porta1,349,100);
     Serial.println("APITAR");
     delay(50+(15*(1+centimetro)));
  }
}
