using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Pongo variables de ambito publico
   
    public int myVar = 10;
    public int y = 54;
    int myResult;

    // Start is called before the first frame update
    void Start()
    {
        myResult = myVar + y;

        print(myResult);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
