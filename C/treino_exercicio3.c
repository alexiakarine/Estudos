#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 3

main ()
{

char s [15];

    printf("\nDigite se seu sexo e F-feminino ou M-masculino: \n");
    scanf("%s",&s);

    if (strcmp(s,"F")==0 || strcmp(s,"f")==0)

    {
        printf("\n\nO sexo FEMININO");

    }

    else if (strcmp(s,"M")==0 || strcmp(s,"m")==0)
    {
        printf("\nsexo MASCULINO ");
    }

    else
    {
        printf("\nSexo invalido");
    }


}







