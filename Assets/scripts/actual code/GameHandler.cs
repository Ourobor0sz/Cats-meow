using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { }
        public void StartGame()
    {
        SceneManager.LoadScene("Scene1");
    }
    //starts the scene
    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    //Loads Credits
    public void RestartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //brings you to main menu!!

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    }

