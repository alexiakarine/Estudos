#include <stdlib.h>
#include <stdio.h>

main(){

    int vCont, vNum, vRaiz, vMenor;

    for(vCont=1; vCont<=5; vCont++){
        printf("Digite um numero: ");
        scanf("%d",&vNum);

        vRaiz=sqrt(vNum);
        vMenor=vRaiz*vRaiz;
        printf("O menor quadrado e: %d (quadrado de %d)\n",vMenor, vRaiz);
        }
}
