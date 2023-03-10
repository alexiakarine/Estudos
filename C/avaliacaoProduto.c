#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){

    int vCont, vBom, vRuim;
    char vVoto=0;

    vBom=0;
    vRuim=0;

        for(vCont=1; vCont<=10; vCont++){
            printf(" ======================================================== \n");
            printf("|GOSTARIAMOS DE SABER SUA OPNIAO SOBRE NOSSO NOVO PRODUTO|\n");
            printf("|========================================================|\n");
            printf("|            DIGITE S SE GOSTOU DO PRODUTO.              |\n");
            printf("|           DIGITE N SE NAO GOSTOU DO PRODUTO.           |\n");
            printf("|      DIGITE QUALQUER LETRA PARA SABER O RESULTADO      |\n");
            printf(" ======================================================== \n");
            scanf(" %c",&vVoto);

            switch(vVoto){
        case 'S': case 's':
            vBom=vBom+1;
            break;
        case 'N': case 'n':
            vRuim=vRuim+1;
            break;
        default:
            printf("                           NUMERO INVALIDO\n");
            vCont=10;
            break;
        }
    }
    if(vBom>vRuim){
        printf("     ================================================================\n");
        printf("     |EXISTE MAIS VOTOS POSITIVOS DO QUE NEGATIVOS, O PRODUTO E BOM!|\n");
        printf("     ================================================================\n");
        }
    else if(vRuim>vBom){
        printf("     =================================================================\n");
        printf("     |EXISTE MAIS VOTOS NEGATIVOS DO QUE POSITIVOS, O PRODUTO E RUIM!|\n");
        printf("     =================================================================\n");
        }
    else{
        printf("EMPATE");
        }
    }

