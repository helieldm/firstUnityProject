using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float speed = 10f, rot = 4000f, curspeed;
    private Vector3 deplacement = Vector3.zero;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightControl)){
            curspeed = speed * 2;
        } else {
            curspeed = speed;
        }

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curspeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
        
    }
}
