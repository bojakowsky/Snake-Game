using UnityEngine;
using System.Collections;

public class SnakeMapCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.name == "Borders"){
            GameObject buf = GameObject.Find("block");
            GameObject buf_a = GameObject.Find("block_0");

            if ( buf.transform.position.x > 6)
            {
                buf.transform.position = new Vector2(-6f, transform.position.y);
            }
            else if (buf.transform.position.x < -6)
            {
                buf.transform.position = new Vector2(6f, transform.position.y);
            }
            else if (buf.transform.position.y > 3)
            {
                buf.transform.position = new Vector2(transform.position.x, -4f);
            }
            else if (buf.transform.position.y < -4)
            {
                buf.transform.position = new Vector2(transform.position.x, 3f);
            }
            buf_a.transform.position = buf.transform.position;
        }
            

    }
}
