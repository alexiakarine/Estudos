#include <SoftwareSerial.h>
SoftwareSerial MinhaSerial(2,3); //Define os pinos para a serial (RX,TX)
void setup() {
pinMode(13,OUTPUT);
MinhaSerial.begin(9600); // inicialização da porta serial para o modulo
}
void loop() {
if (MinhaSerial.read()=='1'){
digitalWrite(13,1);
}
if (MinhaSerial.read()=='2') {
digitalWrite(13,0);
}
}
