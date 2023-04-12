using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
    // Charge la scène suivante
    public void SceneSuivante()
    {
        int scene_id = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene_id + 1);
    }

    // Charge la scène de départ
    public void SceneDepart()
    {
        SceneManager.LoadScene(0);
    }

    // Quitte le jeu
    public void SceneQuitter()
    {
        Application.Quit();
    }
}
