
int pinobotao=7;
int pinoled=2;
void setup() { 
 pinMode(pinobotao, INPUT_PULLUP);
 pinMode(pinoled,OUTPUT);
 digitalWrite(pinoled,LOW);
}

void loop() {
  if(digitalRead(pinobotao)==LOW){
      digitalWrite(pinoled, HIGH);
    }
 else
 {
     digitalWrite(pinoled,LOW);
 }
}
