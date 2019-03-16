using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour {
    public string[] escenas;
    // Use this for initialization
    void Start () {
		
	}
    public void FadeOut()
    {

        StartCoroutine(cambiar(escenas[2]));
    }

    IEnumerator cambiar(string escena)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(escena);

    }

    private void OnMouseDown()
    {
        FadeOut();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
