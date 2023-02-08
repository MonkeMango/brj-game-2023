using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButton : MonoBehaviour
{
    public void PlayGame()
    {
        Application.LoadLevel("Testing");
    }
}
