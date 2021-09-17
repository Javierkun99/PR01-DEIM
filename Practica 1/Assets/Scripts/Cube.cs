using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Toca contatenar
   
   public int num1;
   [SerializeField] int num2;

    private int resultado;




    // Start is called before the first frame update
    void Start()
    {
       resultado = num1 + num2;
        print("El resultado es:" + num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
