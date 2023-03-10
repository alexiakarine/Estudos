int porta_rele = 3; 
#include <Ultrasonic.h>
float centimetro;
long  leiturasensor;


Ultrasonic ultrasonic(4,5);
 
void setup()
{ 
  Serial.begin(9600); 
  pinMode(porta_rele, OUTPUT); 
}
 
void loop()
{    
  // put your main code here, to run repeatedly:
  leiturasensor=ultrasonic.timing();
  centimetro=ultrasonic.convert(leiturasensor,Ultrasonic::CM);
  Serial.print("distancia em cm");
  Serial.println(centimetro);
  delay(1000);
  if(centimetro<10){
    // Liga a lâmpada  
  digitalWrite(porta_rele, HIGH);   
  
    }

   // Desliga a lâmpada   
  digitalWrite(porta_rele,LOW);   
  
}
 
