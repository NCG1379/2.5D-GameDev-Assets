using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1.0f, 0.0f);
        }else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }



    }
}
