#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

main ()
{

char L;

    printf("\n\nDigite uma letra: ");
    scanf("%s",&L);

    switch(L)
    {
        case 'A':
            printf("\n\nVOGAL A");
            break;

        case 'a':
            printf("\n\nVOGAL a");
            break;

        case 'E':
            printf("\n\nVOGAL E");
            break;

        case 'e':
            printf("\n\nVOGAL e");
            break;

        case 'I':
            printf("\n\nVOGAL I");
            break;

        case 'i':
            printf("\n\nVOGAL i");
            break;

        case 'O':
            printf("\n\nVOGAL O");
            break;


        case 'o':
            printf("\n\nVOGAL o");
            break;

        case 'U':
            printf("\n\nVOGAL U");
            break;

        case 'u':
            printf("\n\nVOGAL u");
            break;

        default:
            printf("\n\nCONSOANTE %c",L);
            break;

    }

}
