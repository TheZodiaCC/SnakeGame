using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{

    private SnakeController next;

    public void setNext(SnakeController i)
    {
        next = i;
    }

    public SnakeController getNext()
    {
        return next;
    }

    public void rmTail()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hi");
    }

}
