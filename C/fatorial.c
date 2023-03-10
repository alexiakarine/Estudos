#include <stdio.h>
#include <stdlib.h>

main(){

    int vNum, vCont, vVoltas, vFat;

    printf("Digite quantos numeros voce deseja inserir: ");
    scanf("%d",&vVoltas);

    for(vCont=1; vCont<=vVoltas; vCont++){
        printf("\nDigite o numero que deseja saber o fatorial: ");
        scanf("%d",&vNum);
        for(vFat=1; vNum>1; vNum=vNum-1){
            vFat=vFat*vNum;
            printf("\n%d",vFat);


        }


    }
}
