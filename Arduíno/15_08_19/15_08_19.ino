int Verm1=2;
int Am1=3;
int Verde1=4;

int Verm2=5;
int Am2=6;
int Verde2=7;


void setup() {
  // put your setup code here, to run once:

    pinMode(Am1,OUTPUT);
    pinMode(Am2,OUTPUT);
    pinMode(Verm1,OUTPUT);
    pinMode(Verm2,OUTPUT);
    pinMode(Verde1,OUTPUT);
    pinMode(Verde2,OUTPUT);  

}

void loop() {
  // put your main code here, to run repeatedly:

    digitalWrite(Verm2,HIGH);
    delay(1000);
    digitalWrite(Verde1,HIGH);
    delay(1000);
    digitalWrite(Verde1,LOW);
    delay(1000);     
    digitalWrite(Am1,HIGH);
    delay(1000);
    digitalWrite(Am1,LOW);
    delay(1000);
    digitalWrite(Verm1,HIGH);
    delay(1000);
    digitalWrite(Verm2,LOW);
    delay(3000);     
    digitalWrite(Verde2,HIGH);
    delay(1000);
    digitalWrite(Verde2,LOW);
    delay(1000);
    digitalWrite(Am2,HIGH);
    delay(1000);
    digitalWrite(Am2,LOW);
    delay(1000);
      digitalWrite(Verm2,HIGH);
    delay(2000);  
     digitalWrite(Verm1,LOW);
    delay(2000);   
    
    
    

    
   
    
   
}
