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
        LevelStatus levelStatus = LevelManager.instance.GetLevelStatus(LevelName);
            switch (levelStatus) 
        {
            case LevelStatus.locked:
                Debug.Log("Can't play this level till you unlock it");
                break;

            case LevelStatus.Unlocked:
                SceneManager.LoadScene(LevelName);
                break;

            case LevelStatus.Complet:
                SceneManager.LoadScene(LevelName);
                break;
        }
    } 
}
 