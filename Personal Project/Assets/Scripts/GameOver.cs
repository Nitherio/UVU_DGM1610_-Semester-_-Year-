using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public bool isGameActive = true;

    public TextMeshProUGUI gameOverText;


    public GameObject blackout;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            isGameActive = false;
            Debug.Log("GameOver!!");
            gameOverText.gameObject.SetActive(true);
            blackout.gameObject.SetActive(true);
        }
    }

}