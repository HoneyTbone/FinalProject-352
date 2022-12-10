using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    // Update is called once per frame
    private void FixedUpdate()
    {
         transform.Translate(0, moveSpeed, 0);
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ob")
        {
            Destroy(gameObject);
        }
    }
}
