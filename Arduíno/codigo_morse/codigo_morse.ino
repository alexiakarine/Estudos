
int led = 10;
void setup() {
pinMode(led, OUTPUT);
}
void loop() {
  morse('a');
  delay(1000);
  morse('b');
  delay(1000);
  morse('c');
  delay(1000);
  morse('d');
  delay(1000);
}

void morse(char letra)
{
  switch(letra)
  {
    case 'a':
        piscar(false,1);
        piscar(true,1);
        break;
     case 'b':
        piscar(true,1);
        piscar(false,3);
        break;
     case 'c':
        piscar(true,1);
        piscar(false,1);
        piscar(true,1);
        piscar(false,1);
        break;
     case 'd':
        piscar(true,1);
        piscar(false,2);
        break;
     case 'e':
        piscar(false,1);
        break;
     case 'f':
        piscar(false,2);
        piscar(true,1);
        piscar(false,1);
        break;
      case 'g':
        piscar(true,2);
        piscar(false,1);
        break;
      case 'h':
        piscar(false,4);
        break;
      case 'i':
        piscar(false,2);
        break;
       case 'j':
        piscar(false,1);
        piscar(true,3);
        break;
       case 'k':
        piscar(true,1);
        piscar(false,1);
        piscar(true,1);
        break;
       case 'l':
        piscar(false,1);
        piscar(true,1);
        piscar(false,2);
        break;
      case 'm':
        piscar(true,2);
        break;
        case 'o':
        piscar(true,4);
        break;
  }  
}
void piscar(bool longo,int x)
{
  for(int i = 0; i< x; i++)
  {
    digitalWrite(led, HIGH);//Liga a porta 10
    delay((longo?500:150));
    digitalWrite(led, LOW);
    delay((longo?500:150));
  }
}
