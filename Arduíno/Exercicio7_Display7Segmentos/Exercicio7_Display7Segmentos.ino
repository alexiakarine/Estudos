/*

  
  ~~~~ Liga o 1 e o 4 LED ao mesmo tempo, depois o 2 e o 3 ~~~~
  
 */
 
// Pin 13 has an LED connected on most Arduino boards.
// give it a name:
int a = 2;
int b = 3;
int c = 4;
int d = 5;
int e = 6;
int f = 7;
int g = 8;


// the setup routine runs once when you press reset:
void setup() {                
  // initialize the digital pin as an output.
  pinMode(a, OUTPUT); // PINMODE (Qual? Como?) - Define se é entrada ou saída
  pinMode(b, OUTPUT);   
  pinMode(c, OUTPUT);   
  pinMode(d, OUTPUT);
  pinMode(e, OUTPUT); // PINMODE (Qual? Como?) - Define se é entrada ou saída
  pinMode(f, OUTPUT);   
  pinMode(g, OUTPUT);   
}

// the loop routine runs over and over again forever:
void loop() {
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, LOW);
  delay(1000);   

  digitalWrite(a, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, LOW);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, LOW);
  digitalWrite(g, LOW);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, LOW);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, LOW);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, LOW);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, LOW);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, LOW);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, LOW);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, LOW);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, LOW);
  digitalWrite(g, LOW);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, HIGH);
  digitalWrite(e, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  delay(1000);
  
  digitalWrite(a, HIGH);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(b, HIGH);
  digitalWrite(c, HIGH);
  digitalWrite(d, LOW);
  digitalWrite(e, LOW);   // turn the LED on (HIGH is the voltage level) // (DIGITAL MODE Define se quer que ligue em 5V ou no GND, alto ou baixo)
  digitalWrite(f, HIGH);
  digitalWrite(g, HIGH);
  delay(1000);

  // wait for a second  // ~~~~ DELAY é um atraso
  

}
