#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <locale.h>

main ()
{
setlocale(LC_ALL,"");

int op;

    do
    {
    printf(" Menu do curso: \n");
    printf("0- Sair  \n");
    printf("1-Dar Boas vindas \n");
    printf("2-Dar Oi  \n");
    printf("3-Repetir o menu \n");
    printf("4-Ler mais uma vez o menu \n");

    printf("Opção \n");
    scanf("%d",&op);

    switch(op)
    {
        case 0:
            system("cls || clear");
            printf("Saindo do menu ... \n");
            break;

        case 1:
            system("cls || clear");
            printf("BEM VINDO AO MENU \n");
            break;

        case 2:
            system("cls || clear");
            printf("Oiiii \n");
            break;

        case 3:

        case 4:
            system("cls || clear");
            printf("Ler mais uma vez o menu \n");
            break;

        default:
            system("cls || clear");
            printf("Opção inválida");
    }
}
while(op);
}


