using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAim : MonoBehaviour {

    public Rigidbody2D rb;
    [SerializeField] float lookingAngle;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()
    {
        Vector3 mousepos = Input.mousePosition;
        mousepos = Camera.main.ScreenToWorldPoint(mousepos);
        

        Vector2 direction = new Vector2(
            mousepos.x - transform.position.x,
            mousepos.y - transform.position.y
            );

        if (Vector2.Angle(direction, Vector2.right) < lookingAngle / 2)
        {
              transform.right = direction;
        }
        
      

       
    }
}
