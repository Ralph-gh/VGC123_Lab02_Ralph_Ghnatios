using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Range(3,10)]
    public float speed = 5.5f;
    Rigidbody2D rb;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horinzontal");
        rb.velocity = new Vector2(hInput * speed, rb.velocity.y);
    }
}
