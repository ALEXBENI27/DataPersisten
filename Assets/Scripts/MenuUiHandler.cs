using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUiHandler : MonoBehaviour
{
   public TMP_InputField username;

    public void StartNew() {
        GetName();
        SceneManager.LoadScene(1);
    }

    public void Exit() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    
    public void GetName() {
        MainManagerMenu.PlayerName(username.text);
    }

}
