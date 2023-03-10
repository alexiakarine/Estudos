#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vDiv, vNum;
    vDiv=0;

    for(vCont=1; vCont<=50; vCont++){
        printf("Digite um numero: ");
        scanf("%d",&vNum);

        if(vNum%3==0){
            vDiv=vDiv+1;
        }
    }
    printf("Dos 50 numeros digitados, %d sao divisiveis por 3",vDiv);

}
