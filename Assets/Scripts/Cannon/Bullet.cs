using System;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 15f;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;
    
    void Start() {
        gameObject.tag = "Bullet";
        rb.velocity = transform.up * speed;
    }
}
