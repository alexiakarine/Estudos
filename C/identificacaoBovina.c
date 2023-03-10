#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vId, vIdGordo, vIdMagro;
    float vGordo, vPeso, vMagro;

    for(vCont=1; vCont<=400; vCont++){
        printf("Digite o numero de identificacao do boi: ");
        scanf("%d",&vId);
        printf("Digite o peso do boi: ");
        scanf("%f",&vPeso);
        if(vCont==1){
            vIdMagro=vId;
            vIdGordo=vId;
            vGordo=vPeso;
            vMagro=vPeso;
        }
        if(vPeso>vGordo){
            vGordo=vPeso;
            vIdGordo=vId;
        }
        if(vPeso<vMagro){
            vMagro=vPeso;
            vIdMagro=vId;
        }
    }
    printf("O numero de identificacao do boi mais gordo e %d e ele pesa %.2f quilos\n", vIdGordo, vGordo);
    printf("O numero de identificacao do boi mais magro e %d e ele pesa %.2f quilos", vIdMagro, vMagro);

}
