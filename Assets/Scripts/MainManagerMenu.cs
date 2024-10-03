using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainManagerMenu : MonoBehaviour
{
    public static MainManagerMenu Instance;
    public string username;

    private void Awake() {
        if(Instance != null) {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);    
    }

    public static void PlayerName(string name) {
        MainManagerMenu.Instance.username = name;
    }
}
