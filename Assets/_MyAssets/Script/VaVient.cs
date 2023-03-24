using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaVient : MonoBehaviour
{
    // Start is called before the first frame update
     bool _switch = true;
    // Update is called once per frame
    private void Update()
    {
        if (_switch){
            droite();
        }
        if (!_switch){
            gauche();
        }
        if (this.transform.Translate(new Vector3(6f, 0f, 0f))){

        }
    }

    private void droite()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime);
    }

    private void gauche()
    {
        this.transform.Translate(-Vector3.forward * Time.deltaTime);
    }
}
