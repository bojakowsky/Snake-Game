using UnityEngine;
using System.Collections;

public class SnakeMapCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.name == "Borders")
            Application.LoadLevel("Game_over");

    }
}
