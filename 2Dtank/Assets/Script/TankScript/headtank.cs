using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headtank : MonoBehaviour
{
    public GameObject Headtank;
    public Joystick joystick;
    Vector2 rot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot = new Vector2(joystick.Horizontal, joystick.Vertical);

        Headtank.transform.rotation = Quaternion.LookRotation(transform.forward, rot);
    }
}
