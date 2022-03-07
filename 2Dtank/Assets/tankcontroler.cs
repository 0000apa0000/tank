using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroler : MonoBehaviour
{

    Rigidbody2D rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rigid.velocity = direction * 3;

    }

 
}
