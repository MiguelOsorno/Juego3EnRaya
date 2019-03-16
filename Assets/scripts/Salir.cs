using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        salirDeJuego();
    }

    public void salirDeJuego()
    {
        Debug.Log("Adios");
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
