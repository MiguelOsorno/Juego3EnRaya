using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEnCuadrado : MonoBehaviour {
    public bool primerClick;
    public bool repeticion;
    public GameObject generadorIconos;
    public ColocarIcono scripGeneradorIconos;
    private float posicionX;
    private float posicionY;
	// Use this for initialization
	void Start () {
        scripGeneradorIconos = generadorIconos.gameObject.GetComponent<ColocarIcono>();
	}

    private void OnMouseDown()
    {
        primerClick = true;
        if (primerClick && repeticion == false)
        {
            scripGeneradorIconos.crearIcono();
            optenerCordenadas();
            repeticion = true;
        }
    }



    public void optenerCordenadas()
    {
        posicionX = this.gameObject.transform.position.x;
        posicionY = this.gameObject.transform.position.y;
        scripGeneradorIconos.posicionarIcono(posicionX, posicionY);
    }

    // Update is called once per frame
    void Update () {
        
    }
}
