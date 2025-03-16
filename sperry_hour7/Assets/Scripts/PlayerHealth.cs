using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 1004f ;
    public float posionDamage = 125.5f ;
    
    // Start is called before the first frame update
    void Start()
    {
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        health = (health - posionDamage);
        print(health);
        print("Player is unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
