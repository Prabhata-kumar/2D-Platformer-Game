using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverController : MonoBehaviour
{
   public void PlayerDied()
    {
        gameObject.SetActive(true);
    }
}
