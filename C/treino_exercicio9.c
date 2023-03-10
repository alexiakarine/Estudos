#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 9

main ()
{

float salario,reajuste,satual,valor;
char nome[15];

    printf("\nDigite qual valor do salario do funcionario: \n");
    scanf("%f",&salario);

    printf("\n\nDigite o nome do funcionario: \n");
    scanf("%s",&nome);

    if (salario>=280)

    {
        reajuste=((salario*20)/100);
        satual=salario+reajuste;

        printf("\n\nO funcionario %s, teve um aumento de 20 porcento, equivalente a %f ,seu salario anterior era %f, o valor atual do seu salario sera: %f",nome,reajuste,salario,satual);
    }

	else if (salario>280 && salario<700)

    {
        reajuste=((salario*15)/100);
        satual=salario+reajuste;

        printf("\n\nO funcionario %s, teve um aumento de 15 porcento, equivalente a %f,seu salario anterior era %f,o valor atual do seu salario sera: %f",nome,reajuste,salario,satual);
    }

    else if (salario>700 && salario<1500)

    {   reajuste=((salario*10)/100);
        satual=salario+reajuste;

        printf("\n\nO funcionario %s, teve um aumento de 10 porcento, equivalente a %f,seu salario anterior era %f,o valor atual do seu salario sera: %f",nome,reajuste,salario,satual);
    }

    else if (salario>1500)

     {
        reajuste=((salario*5)/100);
        satual=salario+reajuste;

        printf("\n\nO funcionario %s, teve um aumento de 5 porcento, equivalente a %f,seu salario anterior era %f,o valor atual do seu salario sera: %f",nome,reajuste,salario,satual);
    }


    else
    {
        printf("\n\n\n");
    }


}







