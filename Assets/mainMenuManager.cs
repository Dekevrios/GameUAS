using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void ToggleStart()
    {
        SceneManager.LoadScene("Garden");
    }

    public void CreditGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    
}
