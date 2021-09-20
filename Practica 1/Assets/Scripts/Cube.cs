using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //A ver como hago los numeros al azar
    [SerializeField] string a = "Benito";
    [SerializeField] string b = "Elver";

    public int f1;
    public int d = 51;



    // Start is called before the first frame update
    void Start()
    {
        while (d != 60) 
        {
            

            d = Random.Range(56, 61);

            print(d);
        }

       




    }



    // Update is called once per frame
    void Update()
    {

        
        

    }
}
