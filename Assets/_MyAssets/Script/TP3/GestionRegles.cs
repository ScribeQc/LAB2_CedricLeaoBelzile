using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionRegles : MonoBehaviour
{
    // Variables
    [SerializeField] public GameObject Inst = default;

    // Start is called before the first frame update
    public void Start()
    {
        Inst.SetActive(false);
    }

    // Activer la page de règles
    public void ReglesActif()
    {
        Inst.SetActive(true);
    }

    // Désactiver la page de règles
    public void ReglesInactif()
    {
        Inst.SetActive(false);
    }
}
