using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            GameManager.instance.lives--;
            player.transform.position = respawnPoint.position;
        }

        if (GameManager.instance.lives == 0)
        {
            SceneManager.LoadScene("4 - Failure");
        }
    }
}
