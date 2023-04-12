using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestionScore : MonoBehaviour
{
    // Variables
    [SerializeField] private TMP_Text _temps = default;
    [SerializeField] private TMP_Text _penalite = default;
    [SerializeField] private TMP_Text _total = default;

    private GestionJeu _gestionJeu;

    // Start is called before the first frame update
    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();

        _temps.text = "Temps : " + _gestionJeu.GetTempsFinal().ToString("f2") + " secondes";
        _penalite.text = "Pénalités : " + _gestionJeu.GetPointage().ToString();
        float total = _gestionJeu.GetTempsFinal() + _gestionJeu.GetPointage();
        _total.text = "Total : " + total.ToString("f2") + " secondes";   
    }
}
