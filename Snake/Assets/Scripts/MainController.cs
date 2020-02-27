using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public GameObject snake;
    public SnakeController head;
    public SnakeController tail;

    public Vector2 next;
    public int dir;

    
    void TimeRep()
    {
        Move();
    }
    void Move()
    {
        GameObject tmp;
        next = head.transform.position;
        
        switch(dir)
        {
            case 0:
                next = new Vector2(next.x, next.y + 1);
                break;
            case 1:
                next = new Vector2(next.x + 1, next.y);
                break;
            case 2:
                next = new Vector2(next.x, next.y - 1);
                break;
            case 3:
                next = new Vector2(next.x - 1, next.y);
                break;
        }
        tmp = (GameObject)Instantiate(snake, next, transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimeRep", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
