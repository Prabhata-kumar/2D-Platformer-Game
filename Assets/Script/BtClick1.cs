using UnityEngine;
using UnityEngine.SceneManagement;

public class BtClick1 : MonoBehaviour
{
    public void BtNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
};
