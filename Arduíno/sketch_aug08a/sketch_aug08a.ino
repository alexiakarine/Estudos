
int led = 10;
void setup() {
pinMode(led, OUTPUT);
}
void loop() {
  morse('a');
}

void morse(char letra)
{
  switch(letra)
  {
    case 'a':
        piscar(false,1);
        piscar(true,1);
        break;
     
  }  
}
void piscar(bool longo,int x)
{
  for(int i = 0; i< x; i++)
  {
    digitalWrite(led, HIGH);//Liga a porta 10
    delay((longo?250:750));
    digitalWrite(led, LOW);
    delay(500);
  }
}
