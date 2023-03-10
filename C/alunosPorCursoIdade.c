#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vCurso, vIdade, vContEng, vContComp, vContAdm, vAdm25, vComp25, vEng25;
    float vMedEng, vMedComp, vMedAdm, vSomEng, vSomComp, vSomAdm;

    vContEng=0;
    vContComp=0;
    vContAdm=0;
    vAdm25=0;
    vComp25=0;
    vEng25=0;

    for(vCont=1; vCont<=500; vCont++){
        printf("\nQual curso frequenta:\n1-Engenharia\n2-Computacao\n3-Administracao ");
        scanf("%d",&vCurso);
        printf("Qual a idade do aluno: ");
        scanf("%d",&vIdade);

        switch(vCurso){
    case 1:
        vContEng=vContEng+1;
        vSomEng=vMedEng+vIdade;
        if(vIdade>=20 && vIdade<=25){
            vEng25=vEng25+1;
        }
        break;
    case 2:
        vContComp=vContComp+1;
        vSomComp=vMedComp+vIdade;
        if(vIdade>=20 && vIdade<=25){
            vComp25=vComp25+1;
        }
        break;
    case 3:
        vContAdm=vContAdm+1;
        vSomAdm=vMedAdm+vIdade;
        if(vIdade>=20 && vIdade<=25){
            vAdm25=vAdm25+1;
        }
        break;
    default:
        printf("Curso invalido\n");
        break;
        }

    }
    vMedEng=vSomEng/vContEng;
    vMedComp=vSomComp/vContComp;
    vMedAdm=vSomAdm/vContAdm;

    if(vMedEng<vMedComp && vMedEng<vMedAdm){
        printf("Numero de alunos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vContEng, vContComp, vContAdm);
        printf("Numero de alunos com idade entre 20 e 25 anos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vEng25, vComp25, vAdm25);
        printf("O curso com menor media de idade e : Engenharia");
    }
    else if(vMedComp<vMedEng && vMedComp<vMedAdm){
        printf("Numero de alunos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vContEng, vContComp, vContAdm);
        printf("Numero de alunos com idade entre 20 e 25 anos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vEng25, vComp25, vAdm25);
        printf("O curso com menor media de idade e : Computacao");
    }
    else if(vMedAdm<vMedComp && vMedAdm<vMedEng){
        printf("Numero de alunos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vContEng, vContComp, vContAdm);
        printf("Numero de alunos com idade entre 20 e 25 anos por curso:\nEngenharia: %d\nComputacao: %d\nAdministracao: %d\n",vEng25, vComp25, vAdm25);
        printf("O curso com menor media de idade e : Administracao");
    }

}
