using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 1004f;
    public float poisonDamage = 125.5f;
    // Start is called before the first frame update
    void Start()
    {
        while (health > 0)
        {
            health -= poisonDamage;
            print(health);
        }
        if (health >= 0)
        {
            print("Player Is Dead!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
