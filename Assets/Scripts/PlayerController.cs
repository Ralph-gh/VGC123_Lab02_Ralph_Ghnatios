using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Bindings;
using UnityEngine.Internal;



[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Range(3, 10)]
    public float speed = 5.5f;
    Rigidbody2D rb;


    //awake happens before everything
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hInput * speed, rb.velocity.y);
        float vInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x,vInput * speed);
    }
}
