using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool isGameActive;

    public TextMeshProUGUI gameOverText;

    public GameObject spawnManager;

    public Button resetButton;

    public GameObject player;

    //Colliding with a wall blocks game from view and bring restart button out
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("GameOver!!");
            Destroy(player);
            gameOverText.gameObject.SetActive(true);
            resetButton.gameObject.SetActive(true);
            spawnManager.gameObject.SetActive(false);
            isGameActive = false;
                      
        }
    }
}