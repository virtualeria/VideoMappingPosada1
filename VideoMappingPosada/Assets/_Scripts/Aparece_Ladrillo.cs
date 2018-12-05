using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aparece_Ladrillo : MonoBehaviour {

    // Use this for initialization
	void Start () {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        StartCoroutine(CorutinaLadrillo(Random.Range(0.0f, 3.0f)));
	}

    IEnumerator CorutinaLadrillo (float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
