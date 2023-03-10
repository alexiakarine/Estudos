#include <Ultrasonic.h>
float centimetro;
long leituradosensor; 

Ultrasonic ultrasonic(4,5);

void setup()
{
  Serial.begin(9600);
}

void loop()
{ 
  leituradosensor = ultrasonic.timing();
  centimetro = ultrasonic.convert(leituradosensor,Ultrasonic::CM);
  Serial.print("Distancia em cm: ");
  Serial.println(centimetro);
  delay(1000);
}
