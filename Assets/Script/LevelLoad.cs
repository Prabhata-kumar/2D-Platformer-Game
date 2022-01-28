using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelLoad : MonoBehaviour
{
    public Button button;
    public string LevelName;  

    public void Awakw()
    {
        button=GetComponent<Button>();
        button.onClick.AddListener(onClick);
    }

    private void onClick()
    {
        SceneManager.LoadScene(LevelName);
    }
}
 