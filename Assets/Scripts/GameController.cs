using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private GameObject menu;

    public static GameController instance;

    private void Start()
    {
        instance = this;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void GameEnd()
    {
        menu.SetActive(true);
    }
}
