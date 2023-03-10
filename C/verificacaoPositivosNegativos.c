#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vNumNeg, vNumPos;
    float vNum, vMed, vSom;

    vNumNeg=0;
    vNumPos=0;
    vSom=0;
    for(vCont=1; vCont<=6; vCont++){
        printf("Digite um numero: ");
        scanf("%f",&vNum);
        if(vNum<=-1){
            vNumNeg=vNumNeg+1;
        }
        else{
            vNumPos=vNumPos+1;
            vSom=vSom+vNum;
        }
    }
    vMed=vSom/vNumPos;
    printf("Dos 40 numeros digitados, %d sao negativos\nA media dos numeros positivos e: %.2f",vNumNeg, vMed);

}
