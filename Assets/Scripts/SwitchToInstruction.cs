using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToInstruction : MonoBehaviour
{
    public string sceneName;

    public void onButtonClick()
    {
        SceneManager.LoadScene("Instruction");
    }
}
