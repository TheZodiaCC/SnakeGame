﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public GameObject snake;
    public GameObject food;
    public GameObject currFood;
    public SnakeController head;
    public SnakeController tail;

    public int xB;
    public int yB;

    public Vector2 nextP;
    public int dir;

    public int maxSize = 1;
    public int currSize;

    public int score = 0;

    
    void TimeRep()
    {
        Move();
        if(currSize >= maxSize)
        {
            tailFun();
        }
        else
        {
            currSize++;
        }
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

    void tailFun()
    {
        SnakeController tmpSnake = tail;
        tail = tail.getNext();
        tmpSnake.rmTail();
    }

    void genFood()
    {
        int xP = Random.Range(-xB, xB);
        int yP = Random.Range(-yB, yB);

        currFood = (GameObject)Instantiate(food, new Vector2(xP, yP), transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimeRep", 0, 0.5f);
        genFood();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && dir != 2)
        {
            dir = 0;
        }
        else if(Input.GetKeyDown(KeyCode.D) && dir != 3)
        {
            dir = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S) && dir != 0)
        {
            dir = 2;
        }
        else if (Input.GetKeyDown(KeyCode.A) && dir != 1)
        {
            dir = 3;
        }

        //if (head.transform.position == currFood.transform.position)
        //{
        //    Destroy(currFood);
        //    maxSize += 1;
        //    score++;
        //    genFood();
        //}
    }
    void OnTriggerEnter(Collider other)
    {
        if (head.transform.position == currFood.transform.position)
        {
            Destroy(currFood);
            maxSize += 1;
            score++;
            genFood();
        }
    }
}
