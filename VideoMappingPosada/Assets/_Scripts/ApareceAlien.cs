using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceAlien : MonoBehaviour {
    private Animator estados;
    public float TApareceAlien;
    private bool BanInicio;
    // Use this for initialization
	void Start () {

        estados = gameObject.GetComponentInParent<Animator>();
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = false;
        //Esta corrutina hace que el alien aparezca
        StartCoroutine(ActivoAlien(TApareceAlien));
        //Esta corutina hace que el alien entre en modo de ataque. 
        StartCoroutine(ActivoAnimacion(TApareceAlien + 10.0f));
    }

    // Update is called once per fra
    IEnumerator ActivoAlien(float retardo) {
        yield return new WaitForSeconds(retardo);
        gameObject.GetComponent<SkinnedMeshRenderer>().enabled = true;
    }

    IEnumerator ActivoAnimacion(float TAnimacion) {
        if (BanInicio == true)
        {
            yield return new WaitForSeconds(TAnimacion);
            estados.SetBool("ataque", true);
            BanInicio = false;
            StartCoroutine(ActivoAnimacion(0.0f));
        }
        else {
            estados.SetBool("ataque", false);
            yield return new WaitForSeconds(10.0f);
            estados.SetBool("ataque", true);
            yield return new WaitForSeconds(3.0f);
            StartCoroutine(ActivoAnimacion(0.0f));
        }
    }
    
}
