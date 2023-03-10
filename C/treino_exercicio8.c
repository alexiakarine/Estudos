#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 8

main ()
{

char turno [15];

    printf("\nDigite qual turno voce estuda: \n");
    scanf("%s",&turno);

    if (strcmp(turno,"V")==0 || strcmp(turno,"vespertino")==0)
    {
        printf("\n\nBOA TARDE !!!");
    }

	else if (strcmp(turno,"M")==0 || strcmp (turno,"matutino")==0)
    {
        printf("\n\nBOM DIA !!!");
    }

    else if (strcmp(turno,"N")==0 || strcmp(turno,"norutno")==0)
    {
         printf("\n\nBOA NOITE !!!!");
    }

    else
    {
        printf("\n\n\nValor Invalido");
    }


}







