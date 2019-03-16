using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocarIcono : MonoBehaviour {
    public GameObject tachaGo;
    public GameObject circuloGo;
    public GameObject[] iconos = new GameObject[9];
    public int contador=0;
    public Vector2 poscionNueva;
    public bool turnoTacha;
	// Use this for initialization
	void Start () {
		
	}

    public void crearIcono()
    {
       
        if(turnoTacha)
        {
            if(contador<iconos.Length)
            {
                iconos[contador] = Instantiate(tachaGo);
                turnoTacha = false;
            }
        }
        else
        {
            if (contador < iconos.Length)
            {
                iconos[contador] = Instantiate(circuloGo);
                turnoTacha = true;
            }
        }
    }

    public void posicionarIcono(float x, float y)
    {
        poscionNueva = new Vector2(x, y);
        iconos[contador].transform.position = poscionNueva;
        ++contador;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
