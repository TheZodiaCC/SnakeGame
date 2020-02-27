using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public GameObject snake;
    public SnakeController head;
    public SnakeController tail;

    public Vector2 nextP;
    public int dir;

    
    void TimeRep()
    {
        Move();
    }
    void Move()
    {
        GameObject tmp;
        nextP = head.transform.position;
        
        switch(dir)
        {
            case 0:
                nextP = new Vector2(nextP.x, nextP.y + 1);
                break;
            case 1:
                nextP = new Vector2(nextP.x + 1, nextP.y);
                break;
            case 2:
                nextP = new Vector2(nextP.x, nextP.y - 1);
                break;
            case 3:
                nextP = new Vector2(nextP.x - 1, nextP.y);
                break;
        }
        tmp = (GameObject)Instantiate(snake, nextP, transform.rotation);
        head.setNext(tmp.GetComponent<SnakeController>());
        head = tmp.GetComponent<SnakeController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimeRep", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            dir = 0;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            dir = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            dir = 2;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            dir = 3;
        }
    }
}
