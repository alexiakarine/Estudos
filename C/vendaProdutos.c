#include <stdio.h>
#include <stdlib.h>

main(){

    int vCont, vProd, vQuant, vTotCamBr, vTotCamCol, vTotMol, vTotCal, vTotAga, vTotBon, vDinCamBr, vDinCamCol, vDinMol, vDinCal, vDinAga, vDinBon, vTotPro, vTotDin;

    vTotCamBr=0;
    vTotCamCol=0;
    vTotMol=0;
    vTotCal=0;
    vTotAga=0;
    vTotBon=0;
    vDinCamBr=0;
    vDinCamCol=0;
    vDinMol=0;
    vDinCal=0;
    vDinAga=0;
    vDinBon=0;

    for(vCont=1; vCont<=2; vCont++){
    printf("|=============================================|\n");
    printf("|             TABELA DE PRECOS                |\n");
    printf("|=============================================|\n");
    printf("| Codigo |       Produto     | Preço Unitario |\n");
    printf("|=============================================|\n");
    printf("|    1   |  Camiseta Branca  |     R$7,00     |\n");
    printf("|    2   | Camiseta Colorida |     R$9,00     |\n");
    printf("|    3   |       Moleton     |     R$17,00    |\n");
    printf("|    4   |        Calça      |     R$12,00    |\n");
    printf("|    5   |      Agasalho     |     R$25,00    |\n");
    printf("|    6   |        Bone       |     R$5,00     |\n");
    printf("|=============================================|\n\n");
    printf("Digite o codigo do produto que deseja: \n");
    scanf(" %d",&vProd);
    printf("Digite a quantidade de produtos que deseja: \n");
    scanf(" %d",&vQuant);

    switch(vProd){
case 1:
    vTotCamBr=vTotCamBr+vQuant;
    vDinCamBr=(vQuant*7)+vDinCamBr;


break;
case 2:
    vTotCamCol=vTotCamCol+vQuant;
    vDinCamCol=(vQuant*9)+vDinCamCol;

break;
case 3:
    vTotMol=vTotMol+vQuant;
    vDinMol=(vQuant*17)+vDinMol;

break;
case 4:
    vTotCal=vTotCal+vQuant;
    vDinCal=(vQuant*12)+vDinCal;

break;
case 5:
    vTotAga=vTotAga+vQuant;
    vDinAga=(vQuant*25)+vDinAga;

break;
case 6:
    vTotBon=vTotBon+vQuant;
    vDinBon=(vQuant*5)+vDinBon;

break;
default:
    printf("Codigo invalido");

break;
        }


    }
    vTotPro=vTotCamBr+vTotCamCol+vTotMol+vTotCal+vTotAga+vTotBon;
    vTotDin=vDinCamBr+vDinCamCol+vDinMol+vDinCal+vDinAga+vDinBon;
    printf("O total vendido de Camiseta Branca e: %d\n",vTotCamBr);
    printf("O valor medio vendido em reais de Camiseta Branca e: %d\n",vDinCamBr);
    printf("O total vendido de Camiseta Colorida e: %d\n",vTotCamCol);
    printf("O valor medio vendido em reais de Camiseta Colorida e: %d\n",vDinCamCol);
    printf("O total vendido de Moleton e: %d\n",vTotMol);
    printf("O valor medio vendido em reais Moleton e: %d\n",vDinMol);
    printf("O total vendido de Calca e: %d\n",vTotCal);
    printf("O valor medio vendido em reais de Calca e: %d\n",vDinCal);
    printf("O total vendido de Agasalho e: %d\n",vTotAga);
    printf("O valor medio vendido em reais de Agasalho e: %d\n",vDinAga);
    printf("O total vendido de Bone e: %d\n",vTotBon);
    printf("O valor medio vendido em reais de Bone e: %d\n",vDinBon);
    printf("O total de produtos vendidos foi: %d\n",vTotPro);
    printf("O total em reais vendido foi: %d",vTotDin);



}
