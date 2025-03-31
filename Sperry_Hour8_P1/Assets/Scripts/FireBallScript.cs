using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript: MonoBehaviour
{
    // private int playerHealth = 100;

    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }

        // Start is called before the first frame update
        void Start()
    {
        print("Starting...");

        int x = TakeDamageFromFireball(100,500);
        print("Player health: " + x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
