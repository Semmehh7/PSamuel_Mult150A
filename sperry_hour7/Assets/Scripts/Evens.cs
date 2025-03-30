using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    private int Num = 22;

    // Start is called before the first frame update
    void Start()
    {
        print(Num);

        while (Num < 100)
        {
            Num += 2;
            print(Num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
}
