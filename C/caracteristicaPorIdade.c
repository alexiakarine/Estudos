#include <stdio.h>
#include <stdlib.h>
#include <string.h>

main(){

    int vCont, vIdade, vMaiorIdade, vSomaIdade, vM, vH;
    float vMediaIdade;
    char vSexo=0, vOlho=0, vCabelo=0;

    vMaiorIdade=0;
    vSomaIdade=0;
    vMediaIdade=0;
    vM=0;
    vH=0;


    for(vCont=1; vCont<=5; vCont++){
        printf("Digite seu sexo: M/F ");
        scanf(" %c",&vSexo);
        printf("Digite a cor dos seus olhos: A-Azuis, V- Verdes, C-Castanhos ");
        scanf(" %c",&vOlho);
        printf("Digite a cor dos seus cabelos: L-Loiros, C-Castanhos, P-Pretos ");
        scanf(" %c",&vCabelo);
        printf("Digite sua idade: ");
        scanf(" %d",&vIdade);
        printf("\n");
        //MAIOR IDADE//
        if(vIdade>vMaiorIdade){
            vMaiorIdade=vIdade;
        }
        //MAIOR IDADE//

        //MEDIA IDADE//
        vSomaIdade=vSomaIdade+vIdade;
        //MEDIA IDADE//

        switch(vSexo){
    case 'f': case 'F':
            switch(vOlho){
        case 'v': case 'V':
                switch(vCabelo){
                case 'l': case 'L':
                    if(vIdade>=18 && vIdade<=35){
                        vM=vM+1;
                    }

                }
            }


    case 'm': case 'M':
            switch(vOlho){
        case 'p': case 'P':
                    switch(vCabelo){
                case 'c': case 'C':
                    if(vIdade>=20 && vIdade<=25){
                        vH=vH+1;
                    }

                }
            }



        }



    }

    vMediaIdade=vSomaIdade/3;

    printf("A maior idade e: %d anos\n",vMaiorIdade);
    printf("A media de idade dos habitantes e de: %.2f anos\n",vMediaIdade);
    printf("A quantidade de mulheres com idade entre 18 e 35 anos, com cabelo loiro e olhos verde e: %d\n",vM);
    printf("A quantidade de homens com idade entre 20 e 25 anos, com cabelo castanho e olhos pretos e: %d\n",vH);

}
