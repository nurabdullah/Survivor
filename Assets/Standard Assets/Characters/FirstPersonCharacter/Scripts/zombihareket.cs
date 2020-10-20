using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombihareket : MonoBehaviour
{
    private GameObject oyuncu;
    void Start()
    {
        oyuncu = GameObject.Find("FPSController");
    }

    
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
    }
}
