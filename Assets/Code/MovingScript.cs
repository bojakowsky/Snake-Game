﻿using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour
{

    

    int direction = 2;
    int act_direction = 2;
    // 1 - left
    // 2 - right
    // 3 - up
    // 4 - down

    float seconds = 0.5f;
    public int speed = 1;

    void MoveInDirection()
    {
        seconds -= speed * Time.deltaTime;
        if (seconds <= 0)
            oneMove();
    }

    void oneMove()
    {
        

        if (direction == 1)
            transform.position = new Vector2(transform.position.x - 0.5f, transform.position.y);
        else if (direction == 2)
            transform.position = new Vector2(transform.position.x + 0.5f, transform.position.y);
        else if (direction == 3)
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
        else 
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.5f);
        act_direction = direction;
        seconds = 0.5f;
   
    }


    void OnSwipeLeft()
    {
        if (act_direction != 1 && act_direction != 2)
            direction = 1;
    }
    void OnSwipeRight()
    {
        if (act_direction != 1 && act_direction != 2)
            direction = 2;
    }
    void OnSwipeUp()
    {
        if (act_direction != 3 && act_direction != 4)
             direction = 3;
    }
    void OnSwipeDown()
    {
        if (act_direction != 3 && act_direction != 4)
            direction = 4;
    }

    void Start()
    {
        if (GameObject.Find("SliderManager").GetComponent<GlobalSpeedSetter>() != null)
            speed = (int)GameObject.Find("SliderManager").GetComponent<GlobalSpeedSetter>().speed;
        else speed = 1;
    }
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (act_direction != 1 && act_direction != 2)
                direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (act_direction != 1 && act_direction != 2)
                direction = 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (act_direction != 3 && act_direction != 4)
                direction = 3;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (act_direction != 3 && act_direction != 4)
                direction = 4;
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
                Time.timeScale = 0;
            else Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            Application.LoadLevel("Menu");
        }
        MoveInDirection();

    }
}
