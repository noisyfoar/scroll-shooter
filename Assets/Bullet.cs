using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Remove), 4, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Remove()
    {
        gameObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        rb.velocity = Vector3.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.CompareTag(""))
    }
}
