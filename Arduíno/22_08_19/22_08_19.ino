int pinoBotao = 7; //PINO DIGITAL UTILIZADO PELO PUSH BUTTON
int pinoBotao2 = 8;
int pinoLed = 2; //PINO DIGITAL UTILIZADO PELO LED

void setup() {
pinMode(pinoBotao, INPUT_PULLUP); //DEFINE O PINO COMO ENTRADA / "_PULLUP" É PARA DO ARDUINO PARA GARANTIR QUE NÃO EXISTA FLUTUAÇÃO ENTRE 0 (LOW) E 1 (HIGH)
pinMode(pinoBotao2,INPUT_PULLUP ); 
pinMode(pinoLed, OUTPUT); //DEFINE O PINO COMO SAÍDA
digitalWrite(pinoLed, LOW); //LED INICIA DESLIGADO
}
void loop(){
if (digitalRead(pinoBotao2) == LOW){ //SE A LEITURA DO PINO FOR IGUAL A LOW, FAZ
digitalWrite(pinoLed,HIGH); //ACENDE O LED
}
else{
  digitalWrite(pinoLed,LOW);
}

if(digitalRead(pinoBotao) == LOW){ //SE A LEITURA DO PINO FOR IGUAL A LOW, FAZ
digitalWrite(pinoLed,LOW); //ACENDE O LED
}
else{ //SENÃO, FAZ
  digitalRead(pinoBotao) == HIGH;
digitalWrite(pinoLed,LOW); //APAGA O LED
}
} 
