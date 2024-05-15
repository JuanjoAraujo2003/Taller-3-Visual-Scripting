using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTanque : MonoBehaviour
{
    public float velocidad = 3f;

    void Update()
    {
        
        float movimientoAdelanteAtrás = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        
        float movimientoLateral = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;

        
        transform.Translate(movimientoLateral, 0, movimientoAdelanteAtrás);
    }
}
