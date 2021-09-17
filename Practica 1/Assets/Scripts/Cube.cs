using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Contador de ciclos de while y for
    [SerializeField] string a = "vidas";
    [SerializeField] string b = "Tu personaje tiene";

    public int c = 7;
    public int d = 51;


    // Start is called before the first frame update
    void Start()
    {
        for (c = 0; c < 100; c++)
        {
            if (c < 8)

            {


                print("Es mayor que 8");
            }

            else if (d >= 68)
            {


                print("Es igual a 68");
            }
        }
           
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
