using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Dichoso programa. Espero que no me de dolor de cabeza XD

 

    // Start is called before the first frame update
    void Start()
    {
        Saludar("Jaime");
        Saludar("Carlos");
    }



    // Update is called once per frame
    void Update()
    {

    }

    void Saludar(string a)
    {
        print("Hola "+ a);

    }

   
     
}
