using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceAlien : MonoBehaviour {
    private Animator estados;
    // Use this for initialization
	void Start () {
        estados = gameObject.GetComponentInParent<Animator>();
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = false;
        StartCoroutine(ActivoAlien(3.5f));
        StartCoroutine(ActivoAnimacion(7.0f));
    }

    // Update is called once per fra
    IEnumerator ActivoAlien(float retardo) {
        yield return new WaitForSeconds(retardo);
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    IEnumerator ActivoAnimacion(float TAnimacion) {
        yield return new WaitForSeconds(TAnimacion);
        Debug.Log("Hola");
        estados.SetBool("ataque", false);
        yield return new WaitForSeconds(5.0f);
        Debug.Log("Hola 3 ");
        estados.SetBool("ataque", true);
        StartCoroutine(ActivoAnimacion(5.0f));
    }
    
}
