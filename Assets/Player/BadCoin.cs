using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCoin : MonoBehaviour
{
    //Keep track of total picked coins (Since the value is static, it can be accessed at "SC_2DCoin.totalCoins" from any script)
    public static int totalBadCoins = 0; 

    void Awake()
    {
        //Make Collider2D as trigger 
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            totalBadCoins++;
            //Test: Print total number of coins
            Debug.Log("You currently lost " + BadCoin.totalBadCoins + " Coins.");
            //Destroy coin
            Destroy(gameObject);
        }
    }
}
