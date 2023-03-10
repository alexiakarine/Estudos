#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 5

main ()
{

float m,nota1,nota2;

    printf("\nDigite a primeira nota: \n");
    scanf("%f",&nota1);

    printf("\nDigite a segunda nota: \n");
    scanf("%f",&nota2);

    m=((nota1+nota2)/2);

    if (m>=7 && m<=9)
    {
        printf("\n\nAprovado(a)\n\n");
    }

    else if (m=10)
    {
        printf("\n\nAprovado(a) com distincao\n\n");
    }

    else
    {
        printf("\nReprovada\n\n");
    }


}







