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
    public string nombreDeCuadrado;
   
    public GameObject calcularGanadorGo;
    public CalcularGandor scriptCalcularGanador;
    // Use this for initialization
    void Start () {
        scripGeneradorIconos = generadorIconos.gameObject.GetComponent<ColocarIcono>();
        scriptCalcularGanador = calcularGanadorGo.gameObject.GetComponent<CalcularGandor>();
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
        nombreDeCuadrado = this.gameObject.name;
        scripGeneradorIconos.posicionarIcono(posicionX, posicionY);
        ++scriptCalcularGanador.contadorTurnos;
        scriptCalcularGanador.llenarArray(nombreDeCuadrado);
    }

    // Update is called once per frame
    void Update () {
        
    }
}
