using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoinPickup : MonoBehaviour
{
    public GameObject godFloor;
    public GameObject exitDoor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Coin[] coins = FindObjectsOfType<Coin>();
        if (coins.Length == 0)
        {
            godFloor.gameObject.SetActive(true);
            exitDoor.gameObject.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);

            GameManager.instance.coins++;

        }
    }
}
