#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vNum, vSom;

    vSom=0;

    printf("Digite um numero: ");
    scanf("%d",&vNum);

    for(vCont=1; vCont<=vNum; vCont++){


    vSom=vCont+vSom;

    }
    printf("A soma de todos os numeros anteriores a %d e: %d",vNum, vSom);

}
