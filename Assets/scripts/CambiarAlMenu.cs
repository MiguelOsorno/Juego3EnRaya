using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarAlMenu : MonoBehaviour {
    public string[] escenas;
    // Use this for initialization
    void Start () {
		
	}
    public void FadeOut()
    {

        StartCoroutine(cambiar(escenas[1]));
    }

    IEnumerator cambiar(string escena)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(escena);

    }

   

    // Update is called once per frame
    void Update () {
		
	}
}
