using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankcontroler : MonoBehaviour
{
    public GameObject bulet;
    public float speed , speedrot;
    Rigidbody2D rigid;
    public Joystick joustic;
    public Transform shootpos;
    Vector2 direction, rotation;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

   direction = new Vector2(joustic.Horizontal, joustic.Vertical);
     
        


    }
    void FixedUpdate()
    {
        rigid.velocity = direction * speed * Time.fixedDeltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation , Quaternion.LookRotation(transform.forward, direction) , speedrot*Time.fixedDeltaTime );
      

    }

 
}
