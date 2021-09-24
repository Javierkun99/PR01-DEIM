using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Je,je... toca hacer operaciones matematicas usando las booleanas

    
     [SerielizeField] int a = 5;

     [SerielizeField] int b = 13;

     [SerielizeField] int c = 22;

     


    // Start is called before the first frame update
    void Start()
    {

        print(Multiplicar(a, c));

    }



    // Update is called once per frame
    void Update()
    {

    }

    float Multiplicar(int a, int c)

    {
        float resultado;
        resultado = a * c;
        return resultado;
    }

  
     
}
