using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float kecepatanPutar;
    public float speed;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Meluncur();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate (0f, 0f, Time.deltaTime * kecepatanPutar);
    }

    public void Meluncur(){
        rb.velocity = new Vector2(-speed, 0);
    }
}
