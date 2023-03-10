algoritmo "lISTA DE EXERCICIOS"
// Função :  EXERCICIO 2
// Autor :
// Data : 09/08/2018
// Seção de Declarações 
// Defina as regras, faça o algoritmo e o algoritmo e o fluxograma para ler as coordenadas de dois pontos no plano cartesiano e imprimir a distância entre estes 2 pontos
// fórmula R=SQTR ((x2-x1) e2 + (y2-y1) e2
var

   R,p1,p2:REAL
inicio
// Seção de Comandos 

   Escreval ("Informe qual o ponto x : ")
   Leia (p1)
   
   Escreva ("Informe qual o ponto y: ")
   Leia (p2)
   
   R:= raizq((p1*2-p1*1)*(p1*2-p1*1) + (p2*2-p2*1)*(p2*2-p2*1))
   
   Escreva ("A distâncias entre X e Y são: ",R)

   
fimalgoritmo
