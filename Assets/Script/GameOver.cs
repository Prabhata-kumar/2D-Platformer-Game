using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public GameObject playerDiedText;

    private void Start()
    {
        playerDiedText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Finish"))
        {
            playerDiedText.SetActive(true);
        }}

}


