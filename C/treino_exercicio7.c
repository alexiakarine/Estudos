#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>

// exercico para treino 7

main ()
{

float n1,n2,n3;

    printf("\nDigite um numero: \n");
    scanf("%f",&n1);

    printf("\nDigite outro numero: \n");
    scanf("%f",&n2);

    printf("\nDigite mais um numero: \n");
    scanf("%f",&n3);

    if (n1>n2 && n1>n3 && n2>n3)
    {
        printf("\n\nOs numeros informados foram: %f,%f,%f\n\n",n1,n2,n3);
    }

	else if (n1>n2 && n1>n3 && n3>n2)
    {
        printf("\n\nOs numeros informados foram: %f,%f,%f\n\n",n1,n3,n2);
    }

    else if (n2>n1 && n2>n3 && n3>n1)
    {
         printf("\n\nOs numeros informados foram: %f,%f,%f \n\n",n2,n3,n1);
    }

	else if (n2>n1 && n2>n3 && n1>n3)
    {
         printf("\n\nOs numeros informados foram: %f,%f,%f \n\n",n2,n1,n3);
    }

     else if (n3>n1 && n3>n2 && n2>n1)
    {
         printf("\n\nOs numeros informados foram:%f,%f,%f \n\n",n3,n2,n1);
    }

	     else if (n3>n1 && n3>n2 && n1>n2)
    {
         printf("\n\nOs numeros informados foram:%f,%f,%f \n\n",n3,n1,n2);
    }


    else
    {
        printf("\n\n\nOs numeros digitados sao iguais");
    }


}







