#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){

    int vCont, vContFem, vContMas;
    char vSexo=0;
    float vSal, vSalFem, vSalMas, vMedMas, vMedFem;

    vSalMas=0;
    vSalFem=0;
    vContMas=0;
    vContFem=0;
    for(vCont=1; vCont<=10; vCont++){
        printf("Digite seu sexo: M/F ");
        scanf(" %c",&vSexo);
        printf("Digite seu salario: ");
        scanf(" %f",&vSal);

            switch(vSexo){
        case 'm': case 'M':
            vSalMas=vSal+vSalMas;
            vContMas=vContMas+1;
            break;

        case 'f': case 'F':
            vSalFem=vSal+vSalFem;
            vContFem=vContFem+1;
            break;
        default:
            printf("Invalido\n");
            break;
        }
    }
    vMedFem=vSalFem/vContFem;
    vMedMas=vSalMas/vContMas;
    printf("A media do salario das mulheres e: %.2f\n",vMedFem);
    printf("A media do salario dos homens e: %.2f",vMedMas);

}
