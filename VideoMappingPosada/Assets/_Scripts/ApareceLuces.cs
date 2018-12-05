using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApareceLuces : MonoBehaviour {

    // Use this for initialization
    public GameObject[] Particulas;

    void Start () {

        for (int i = 0; i < Particulas.Length; i++)
        {
            Particulas[i].SetActive(false);
        }
        StartCoroutine(ActivaLuces(5.0f));
	}

    IEnumerator ActivaLuces(float tactiva) {
        yield return new WaitForSeconds(tactiva);
        for (int i = 0; i < Particulas.Length; i++)
        {
            Particulas[i].SetActive(true);
        }
    }

}
