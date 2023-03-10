int porta1 = 10;
int porta2 = 11;

int c4 = 261;
int cs4 = 277;
int d4 = 293;
int ds4 = 311;
int e4 = 329;
int f4 = 349;
int fs4 = 369;
int g4 = 392;
int gs4 = 415;
int a4 = 440;
int as4 = 466;
int b4 = 493;

void setup() {
  pinMode(porta1, OUTPUT);
  pinMode(porta2, OUTPUT);
}

void loop() {
  tone(porta1,b4,300);
  tone(porta1,e4,500);
  tone(porta1,g4,200);
  tone(porta1,fs4,200);
  tone(porta1,e4,500);
  
  tone(porta1,b4,300);
  tone(porta1,a4,300);
  tone(porta1,fs4,600);
  
  tone(porta1,e4,100);
  tone(porta1,g4,100);
  tone(porta1,fs4,100);
  tone(porta1,ds4,100);
  
  tone(porta1,f4,100);
  tone(porta1,b4,100);
  
  tone(porta1,b4,100);
  tone(porta1,e4,100);
  tone(porta1,g4,100);
  tone(porta1,fs4,100);
  tone(porta1,e4,100);
  
  tone(porta1,b4,100);
  tone(porta1,d4,100);
  tone(porta1,cs4,100);
  tone(porta1,c4,100);
  
  tone(porta1,gs4,100);
  tone(porta1,c4,100);
  tone(porta1,b4,100);
  tone(porta1,as4,100);
  tone(porta1,as4,100);
  //delay(100);

  
}