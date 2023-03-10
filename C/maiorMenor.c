#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont;
    float vNum, vMaior, vMenor;

    printf("Digite um numero: ");
    scanf("%f",&vMaior);
    vMenor=vMaior;

    for(vCont=1; vCont<=49; vCont++){
        printf("Digite um numero: ");
        scanf("%f",&vNum);

        if(vNum>vMaior){
            vMaior=vNum;
        }
        if(vNum<vMenor){
            vMenor=vNum;
        }

    }
    printf("O menor numero e: %.2f\n",vMenor);
    printf("O maior numero e: %.2f\n",vMaior);
}
