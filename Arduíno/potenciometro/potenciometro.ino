 float luminosidade=0;
int pinoled=10;
int pinopot=A0;
int valorpot=0;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(pinoled,OUTPUT);
  pinMode(pinoled,INPUT);
  }

void loop() {
  // put your main code here, to run repeatedly:
  valorpot=analogRead(pinopot);
  luminosidade=map(valorpot,0,1023,0,255);
 // Serial.print("Valor lido no potenciômetro: ");
  //Serial.println(valorpot);
  //Serial.println("luminosidade: ");
  //Serial.println(luminosidade);
  analogWrite(pinoled,luminosidade);
}
