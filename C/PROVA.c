#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <locale.h>

main ()
{

setlocale(LC_ALL, "");

int idadeds,idadejd,idadecc,idadeads,idadeoutros,p;
char sexo,curso,fem,masc;
float somag,somaig,somads,somajd,somacc,somaads,somaoutros,somaids,somaijd,somaicc,somaiads,somaioutros,mediag,mediacc,mediads,mediajd,mediaads,mediaoutros,contfds,contfjd,contfcc,contfads,contfoutros,contmds,contmjd,contmcc,contmads,contmoutros,contids,contijd,conticc,contiads,contioutros,contds,contjd,contcc,contads,contoutros,contm,contf,cont,mediaids,mediaijd,mediaicc,mediaiads,mediaioutros;

cont=1;
somag=0;
somads=0;
somajd=0;
somacc=0;
somaads=0;
somaoutros=0;
somaids=0;
somaijd=0;
somaicc=0;
somaiads=0;
somaig=0;
somaioutros=0;
mediag=0;
mediaads=0;
mediajd=0;
mediacc=0;
mediaads=0;
mediaoutros=0;
mediaids=0;
mediaijd=0;
mediaicc=0;
mediaiads=0;
mediaioutros=0;
contm=0;
contf=0;
contfds=0;
contmds=0;
contfjd=0;
contmjd=0;
contfcc=0;
contmcc=0;
contfads=0;
contmads=0;
contfoutros=0;
contmoutros=0;

    printf("\nDigite com quantas pessoas pretende fazer esta pesquisa?:  ");
    scanf("%d",&p);

while(cont<=p)
{
    printf("\nDigite qual curso prefere?\n1-Desenvolvimento de sistemas \n2-Jogos digitais \n3-Ciência da computação \n4-Ánalise de sistemas \n5-Outros \n: ");
    scanf("%s",&curso);

    switch (curso)
    {
        case 1:
            {
                printf("\nDesenvolvimento de sistemas \n\nQual sua idade?: ");
                scanf("%d",&idadeds);
                printf("\nQual seu sexo?\nF-feminino ou M-masculino\n: ");
                scanf("%s",&sexo);

                contds=contds+1;
                contids=contids+1;
                somaids=somaids+idadeds;
                somads=somads+contds;
                contmds=contmds+1;
                contfds=contfds+1;
                break;
            }

        case 2:
            {
                printf("\nJogos digitais \n\nQual sua idade?: ");
                scanf("%d",&idadejd);
                printf("\nQual seu sexo?\nF-feminino ou M-masculino\n: ");
                scanf("%s",&sexo);

                contjd=contjd+1;
                contijd=contijd+1;
                somaijd=somaijd+idadejd;
                somajd=somajd+contjd;
                contmjd=contmjd+1;
                contfjd=contfjd+1;
                break;

            }

        case 3:
            {
                printf("\nCiência da computação\n\nQual sua idade?: ");
                scanf("%d",&idadecc);
                printf("\nQual seu sexo?\nF-feminino ou M-masculino\n: ");
                scanf("%s",&sexo);

                contcc=contcc+1;
                conticc=conticc+1;
                somaicc=somaicc+idadecc;
                somacc=somacc+contcc;
                contmcc=contmcc+1;
                contfcc=contfcc+1;
                break;

            }

        case 4:
            {
                printf("\nÁnalise de sistema\n\nQual sua idade?: ");
                scanf("%d",&idadeads);
                printf("\nQual seu sexo?\nF-feminino ou M-masculino\n: ");
                scanf("%s",&sexo);

                contads=contads+1;
                contiads=contiads+1;
                somaiads=somaiads+idadeads;
                somaads=somaads+contads;
                contmads=contads+1;
                contfads=contfads+1;
                break;

            }

        case 5:
            {
                printf("\nOutrosn\nQual sua idade?: ");
                scanf("%d",&idadeoutros);
                printf("\nQual seu sexo?\nF-feminino ou M-masculino\n: ");
                scanf("%s",&sexo);

                contoutros=contoutros+1;
                contioutros=contioutros+1;
                somaioutros=somaioutros+idadeoutros;
                somaoutros=somaoutros+contoutros;
                contmoutros=contmoutros+1;
                contfoutros=contfoutros+1;
                break;

            }

        default:
            {
                printf("");
            }

    }

    cont++;

}

        somag=somads+somajd+somacc+somaads+somaoutros;
        somaig=somaids+somaijd+somaicc+somaads+somaioutros;
        mediag=somag/p;
        mediads=somads/contds;
        mediajd=somajd/contjd;
        mediacc=somacc/contcc;
        mediaads=mediaads/contads;
        mediaoutros=somaoutros/contoutros;
        mediaids=somaids/contds;
        mediaijd=somaijd/contjd;
        mediacc=somaicc/contcc;
        mediaads=somaiads/contads;
        mediaoutros=somaioutros/contoutros;
        contm=contmds+contmjd+contmcc+contmcc+contmads+contmoutros;
        contf=contfds+contfjd+contfcc+contfads+contfoutros;


        printf("\n\nA média geral de pessoas em todos os cursos é %f\nA quantidade de pessoas do sexo Masculino é %f e a quantidade de pessoas do sexo Feminino é %f",mediag,contm,contf);
        printf("\nA média por pessoa dos cursos são: \nDdesenvolvimento de sistemas %f\nJogos digitais %f\nCiências da computação %f\nÁnalise de sistemas %f\nOutros %f",mediads,mediajd,mediacc,mediaads,mediaoutros);
        printf("\n\nA média das idades por curso são: \nDdesenvolvimento de sistemas %f\nJogos digitais %f\nCiências da computação %f\nÁnalise de sistemas %f\nOutros %f",mediaids,mediaijd,mediaicc,mediaiads,mediaioutros);

}
