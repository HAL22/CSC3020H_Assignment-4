using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


    // Public variables
    public GameObject player;
    public  bool rot = true;
   

    // Private variables
    public Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        // The initial offset;
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate ()
    {

        if (Input.GetKey(KeyCode.N))
        {
            rot = true;

        }

        if (Input.GetKey(KeyCode.M))
        {
            rot = false;
        }

        // making sure the camera looks at the player object

        transform.LookAt(player.transform);


        if (!rot)
        {

            transform.position = player.transform.position + offset;

        }

       

        if (rot)
        {

            transform.RotateAround(player.transform.position, Vector3.up, Time.deltaTime * 100);

        }

      


        





    }
}
