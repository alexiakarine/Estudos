#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vAndar, vElevador, vEntrou, vSaiu;

    vElevador=0;
    vSaiu=0;

    printf("Quantos andares tem o predio? ");
    scanf("%d",&vAndar);


    for(vCont=1; vCont<=vAndar+1; vCont++){
        if(vCont==vAndar+1){
        printf("Chegamos no ultimo andar, todos os %d passageiros devera descer do elevador.",vElevador);
        break;
        }
        if(vCont==1){
        printf("Quantas pessoas entraram no elevador no terreo? ");
        scanf("%d",&vEntrou);
        }
        else{
        printf("Quantas pessoas entraram no elevador no %do andar? ",vCont-1);
        scanf("%d",&vEntrou);
        printf("Quantas pessoas sairam do elevador no %do andar? ",vCont-1);
        scanf("%d",&vSaiu);
        }
        vElevador=vElevador+vEntrou-vSaiu;
            if (vElevador>=16){
            printf("EXCESSO DE PASSAGEIROS, DESCA %d PASSAGEIROS\n",vElevador-15);
            vElevador=15;
            }
            if(vElevador<=-1){
            printf("O elevador nao pode possuir passageiros negativos, o programa sera finalizado.");
            break;
            }
    printf("O elevador possui %d passageiros\n",vElevador);
    }


}
