using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Contador de ciclos usando Update
    [SerializeField] int a = 3;
 

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (a >= 15)
        {
            print("Es mayor que 15");
        }
         a=a+1;
        print(a);
    }
}
