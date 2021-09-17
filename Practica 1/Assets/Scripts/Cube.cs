using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    //Contador de ciclos de while y for
    [SerializeField] string a = "Buenos";
    [SerializeField] string b = "dias";

    public int c = 7;
    public int d = 51;


    // Start is called before the first frame update
    void Start()
    {
        while (c<45)
        {
            print(c);
            c++;
        }
        
            for (c = 7; c < 45; c++) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
