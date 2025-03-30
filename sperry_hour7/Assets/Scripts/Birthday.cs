using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    private int month = 9;
    private int day = 1;

    // Start is called before the first frame update
    void Start()
    {
        print(day);

        while (day < 30)
        {
            day += 1;
            if (day == 9)
            {
                print("happy birthday!");
            }
            else
            {
                print(day);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
