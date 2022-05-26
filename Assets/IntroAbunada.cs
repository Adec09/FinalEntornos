using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAbunada : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camara;

    private void Update()
    {
        StartCoroutine(tiempo());
    }

    IEnumerator tiempo()
    {
        yield return new WaitForSeconds(24f);
        Destroy(Camara, 0.1f);
        Player.SetActive(true);
    }

}
