algoritmo "lISTA DE EXERCICIOS"
// Fun��o :  EXERCICIO 2
// Autor :
// Data : 09/08/2018
// Se��o de Declara��es 
// Defina as regras, fa�a o algoritmo e o algoritmo e o fluxograma para ler as coordenadas de dois pontos no plano cartesiano e imprimir a dist�ncia entre estes 2 pontos
// f�rmula R=SQTR ((x2-x1) e2 + (y2-y1) e2
var

   R,p1,p2:REAL
inicio
// Se��o de Comandos 

   Escreval ("Informe qual o ponto x : ")
   Leia (p1)
   
   Escreva ("Informe qual o ponto y: ")
   Leia (p2)
   
   R:= raizq((p1*2-p1*1)*(p1*2-p1*1) + (p2*2-p2*1)*(p2*2-p2*1))
   
   Escreva ("A dist�ncias entre X e Y s�o: ",R)

   
fimalgoritmo
