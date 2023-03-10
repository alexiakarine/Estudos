#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){

    int vCont, vIdade, vMenorIdade, vMaiorIdade, vSalM;
    float vSalario, vSomaSal, vMediaSal;
    char vSexo;

    vMenorIdade=100;
    vMaiorIdade=0;
    vSalM=0;


    for (vCont=1; vCont<=30; vCont++){
        printf("Digite seu sexo: F/M ");
        scanf(" %c",&vSexo);
        printf("Digite sua idade: ");
        scanf(" %d",&vIdade);
        printf("Digite seu salario: ");
        scanf(" %f",&vSalario);
        printf("\n");

        vSomaSal=vSomaSal+vSalario;

        if(vMenorIdade>vIdade){
            vMenorIdade=vIdade;
        }
        if(vMaiorIdade<vIdade){
            vMaiorIdade=vIdade;
        }
        if(vIdade<0 || vSalario<0){
            break;
        }
        switch(vSexo){
    case 'f': case 'F':
        if(vSalario<=100){
            vSalM=vSalM+1;
            }
        }

    }
    vMediaSal=vSomaSal/3;

    if (vIdade>=0 && vSalario>=0){
    printf("A media dos salario e: %.2f\n",vMediaSal);
    printf("A maior idade e: %d\n",vMaiorIdade);
    printf("A menor idade e: %d\n",vMenorIdade);
    printf("A quantidade de mulheres com salario ate R$100,00 e: %d",vSalM);

    }

    else{
    printf("Numero incorreto");
        }


}
