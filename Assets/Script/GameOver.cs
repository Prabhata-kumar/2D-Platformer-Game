using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public gameOverController GameOverController;
    public GameObject playerDiedText;
    public Button buttonRestart;

    public void Awake()
    {
        buttonRestart.onClick.AddListener(RelodeLevel);
    }
    private void Start()
    {
        playerDiedText.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Finish"))
        {
            playerDiedText.SetActive(true);
        }
        else if (other.CompareTag("Enemie"))
        {
            playerDiedText.SetActive(true);
        }
    }

    private void RelodeLevel()
    {
        SceneManager.LoadScene(0);
    }
}


