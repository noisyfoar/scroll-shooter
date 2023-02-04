using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float healthBar = 100f;
    public float moveSpeed = 100f;
    public Rigidbody rb;
    Vector2 movement;
    // Start is called before the first frame update Salad j
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MainInput();
        

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (new Vector3(movement.x, 0, movement.y) * moveSpeed * Time.fixedDeltaTime));
    }
    private void MainInput()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }
}
