#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 4

main ()
{

char l [15];

    printf("\nDigite uma letra: \n");
    scanf("%s",&l);

    if (strcmp(l,"a")==0 || strcmp(l,"A")==0)
    {
        printf("\n\nA letra informada e uma VOGAL\n\n");
    }

    else if (strcmp(l,"E")==0 || strcmp(l,"e")==0)
    {
        printf("\n\nA letra informada e uma VOGAL\n\n");
    }

     else if (strcmp(l,"I")==0 || strcmp(l,"i")==0)
    {
        printf("\n\nA letra informada e uma VOGAL\n\n");
    }

     else if (strcmp(l,"O")==0 || strcmp(l,"o")==0)
    {
        printf("\n\nA letra informada e uma VOGAL\n\n");
    }

     else if (strcmp(l,"U")==0 || strcmp(l,"u")==0)
    {
        printf("\n\nA letra informada e uma VOGAL\n\n");
    }

    else
    {
        printf("\nA letra informada e uma CONSOANTE\n\n");
    }


}







