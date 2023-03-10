#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vNum, vMaior, vSoma, vMenor;
    float vMedia;

    vMedia=0;
    vMaior=0;
    vSoma=0;


    for (vCont=1; vCont<=500; vCont++){
    printf("Digite um numero inteiro e positivo: ");
    scanf("%d",&vNum);
    if(vCont==1){
        vMenor=vNum;
    }

    if(vNum>=0){
        vSoma=vSoma+vNum;

        if(vMaior<vNum){
            vMaior=vNum;
            }
        if(vMenor>vNum){
            vMenor=vNum;
            }
        }
    else{
        printf("Numero errado");
        break;
        }
    }

    vMedia=vSoma/5;
    printf("A media dos numeros e: %.2f \n",vMedia);
    printf("O maior numero e %d \n",vMaior);
    printf("O menor numero e %d",vMenor);




}
