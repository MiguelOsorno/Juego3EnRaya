using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularGandor : MonoBehaviour {
    public string[,] posiblesCombinaciones = new string[3, 3];
    public int fila;
    public int columna;
    public int vecesIconos = 0;
    public string[] posiblesGanes=new string[8];
    public string ganador="";
    public int contadorTurnos = 0;
	// Use this for initialization
	void Start () {
       
	}

    public void llenarArray(string nombreCuadradoClick)
    {
        
        if(nombreCuadradoClick== "cuadrado3")
        {
            fila = 0;
            columna=0;
        }
        else if(nombreCuadradoClick== "cuadrado6")
        {
            fila = 0;
            columna=1;
        }
        else if(nombreCuadradoClick== "cuadrado9")
        {
            fila = 0;
            columna=2;
        }
        else if(nombreCuadradoClick=="cuadrado2")
        {
            fila = 1;
            columna = 0; 
        }
        else if(nombreCuadradoClick== "cuadrado5")
        {
            fila = 1;
            columna= 1;
        }
        else if(nombreCuadradoClick== "cuadrado8")
        {
            fila = 1;
            columna=2;
        }
        else if(nombreCuadradoClick=="cuadrado")
        {
            fila= 2;
            columna = 0; 
        }
        else if(nombreCuadradoClick== "cuadrado4")
        {
            fila=2;
            columna=1;
        }
        else if(nombreCuadradoClick=="cuadrado7")
        {
            fila= 2;
            columna=2;
        }

        switch(contadorTurnos)
        {
            case 1:
                posiblesCombinaciones[fila, columna] = "c";
            break;

            case 2:
                posiblesCombinaciones[fila, columna] = "t";
            break;

            case 3:
                posiblesCombinaciones[fila, columna] = "c";
                break;
            case 4:
                posiblesCombinaciones[fila, columna] = "t";
                break;
            case 5:
                posiblesCombinaciones[fila, columna] = "c";
                break;
            case 6:
                posiblesCombinaciones[fila, columna] = "t";
                break;
            case 7:
                posiblesCombinaciones[fila, columna] = "c";
                break;
            case 8:
                posiblesCombinaciones[fila, columna] = "t";
                break;
            case 9:
                posiblesCombinaciones[fila,columna] = "c";
                break;
        }
    }

    public void calcularGanador()
    {
        posiblesGanes[0] = ""+posiblesCombinaciones[0, 0]+posiblesCombinaciones[0, 1]+posiblesCombinaciones[0, 2];
        posiblesGanes[1] = ""+posiblesCombinaciones[1, 0]+posiblesCombinaciones[1, 1]+posiblesCombinaciones[1, 2];
        posiblesGanes[2] = ""+posiblesCombinaciones[2, 0]+posiblesCombinaciones[2, 1]+posiblesCombinaciones[2, 2];
        posiblesGanes[3] = ""+posiblesCombinaciones[0, 0]+posiblesCombinaciones[1, 0]+posiblesCombinaciones[2, 0];
        posiblesGanes[4] = ""+posiblesCombinaciones[0, 1]+posiblesCombinaciones[1, 1]+posiblesCombinaciones[2, 1];
        posiblesGanes[5] = ""+posiblesCombinaciones[0, 2]+posiblesCombinaciones[1, 2]+posiblesCombinaciones[2, 2];
        posiblesGanes[6] = ""+posiblesCombinaciones[0, 0]+posiblesCombinaciones[1, 1]+posiblesCombinaciones[2, 2];
        posiblesGanes[7] = ""+posiblesCombinaciones[0, 2]+posiblesCombinaciones[1, 1]+posiblesCombinaciones[2, 0];

    }

    /*public void imprimirLista()
    {
        Debug.Log(posiblesGanes[0]);
        Debug.Log(posiblesGanes[1]);
        Debug.Log(posiblesGanes[2]);
        Debug.Log(posiblesGanes[3]);
        Debug.Log(posiblesGanes[4]);
        Debug.Log(posiblesGanes[5]);
        Debug.Log(posiblesGanes[6]);
        Debug.Log(posiblesGanes[7]);
        Debug.Log(posiblesCombinaciones[0, 0]);
        Debug.Log(posiblesCombinaciones[0, 1]);
        Debug.Log(posiblesCombinaciones[0, 2]);
        Debug.Log(posiblesCombinaciones[1, 0]);
        Debug.Log(posiblesCombinaciones[1, 1]);
        Debug.Log(posiblesCombinaciones[1, 2]);
        Debug.Log(posiblesCombinaciones[2, 0]);
        Debug.Log(posiblesCombinaciones[2, 1]);
        Debug.Log(posiblesCombinaciones[2, 2]);
    }*/

    public void gane()
    {
        for(int contador=0; contador<posiblesGanes.Length;++contador)
        {
            if(posiblesGanes[contador]==(""+"ttt"))
            {
                ganador = "gano tacha";
            }
            else if(posiblesGanes[contador] == (""+"ccc"))
            {
                ganador = "gano circulo";
            }
        }
    }

    
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(contadorTurnos);
		if(contadorTurnos>=5)
        {
            calcularGanador();
            gane();
        }
        if (ganador == "gano tacha")
        {
            Debug.Log("tacha");
        }
        else if(ganador=="gano circulo")
        {
            Debug.Log("circulo");
        }
	}
}
