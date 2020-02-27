using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFood : MonoBehaviour
{
    //public MainController main;
    //MainController main = new MainController();

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
