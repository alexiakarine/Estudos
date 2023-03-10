#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 6

main ()
{

float p1,p2,p3;

    printf("\nDigite o  valor do primeiro produto: \n");
    scanf("%f",&p1);

    printf("\nDigite o valor do segundo produto: \n");
    scanf("%f",&p2);

    printf("\nDigite o valor do terceiro produto: \n");
    scanf("%f",&p3);

    if (p1<=p2 && p1<=p3)
    {
        printf("\n\nO primero produto e o mais barato COMPRE-O!!!\n\n");
    }

    else if (p2<=p1 && p2<=p3)
    {
        printf("\n\nO segundo produto e o mais barato COMPRE-O!!!\n\n");
    }

    else
    {
        printf("\nO terceiro produto e o mais barato COMPRE-O!!!\n\n");
    }


}







