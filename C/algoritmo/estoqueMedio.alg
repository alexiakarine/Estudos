algoritmo "Lista de exercicios"
// Função :  exercico 1
// Autor :
// Data : 09/08/2018
// Seção de Declarações 
// Faça um algoritmo para calcular o estoque médio de uma peça, sendo que
//ESTOQUE MÉDIO= quantidade minima + quantidade máxima /2
var
     EM, QMIN, QMAX:REAL
inicio
// Seção de Comandos 
   EscrevaL ("Qual á quantidade miníma de peças em estoque?")
   Leia (QMIN)
   
   Escreva ("Qual a quantidade máxima de peças em estoque? ")
   Leia (QMAX)
   
   EM <-(QMAX + QMIN)/2
   
   Escreval ("Seu estoque médio é de: ", EM)
   
   
fimalgoritmo
