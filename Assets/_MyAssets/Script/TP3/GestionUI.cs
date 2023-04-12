using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionUI : MonoBehaviour
{
    // Variables
    [SerializeField] private TMP_Text _penalite = default;
    [SerializeField] private TMP_Text _temps = default;
    [SerializeField] private GameObject _pause = default;

    private bool _actif; // En pause ou en jeu
    private GestionJeu _gestionJeu;


    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();


        _actif = false;
        _pause.SetActive(false);
        _penalite.text = "Pénalités : " + _gestionJeu.GetPointage();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float xTemps = Time.time - _gestionJeu.GetTempsDepart();
        _temps.text = "Temps : " + xTemps.ToString("f2");
        GestionPause();
    }

    // Détermine quand activer le menu de pause
    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_actif)
        {
            _pause.SetActive(true);
            Time.timeScale = 0;
            _actif = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _actif)
        {
            EnJeu();
        }
    }

    // Désactive le menu de pause
    public void EnJeu()
    {
        _pause.SetActive(false);
        Time.timeScale = 1;
        _actif = false;
    }

    // Ajuste le pointage
    public void SetPenalite(int num)
    {
        _penalite.text = "Pénalités : " + num.ToString();
    }
}
