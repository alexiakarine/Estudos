 const int pinoSensor=2;
 const int pinoBuzzer=5;
 
 
 void setup() {
  // put your setup code here, to run once:
  pinMode(pinoSensor,INPUT);
  pinMode(pinoBuzzer,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (digitalRead(pinoSensor)==HIGH){
    digitalWrite(pinoBuzzer,HIGH);
  }
  else{
    digitalWrite(pinoBuzzer,LOW);
  }
  delay(200);



}
