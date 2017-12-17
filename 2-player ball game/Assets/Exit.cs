using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Exit : MonoBehaviour {




    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
