using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ejecutortrigger : MonoBehaviour
{
    [SerializeField]
    private UnityEvent evento; 

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            evento.Invoke();
        }
    }
}
