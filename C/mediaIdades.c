#include <stdio.h>
#include <stdlib.h>

main(){
    int vCont, vIda, vSom;
    float vMed;
    char vNome[20];

    vSom=0;
    for(vCont=1; vCont<=20; vCont++){
        printf("Digite seu nome: ");
        scanf("%s",&vNome);
        printf("Digite sua idade: ");
        scanf("%d",&vIda);
        vSom=vSom+vIda;

    }
    vMed=vSom/5;
    printf("A media das idades e: %.2f",vMed);

}
