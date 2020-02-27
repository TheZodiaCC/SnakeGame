using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cage_GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("GameOver Cage");
    }
}
