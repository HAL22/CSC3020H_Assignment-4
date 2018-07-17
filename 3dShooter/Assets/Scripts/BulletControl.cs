using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    public GameObject target;
    public GameObject bullet;
    public float bulletstrength;

	// Use this for initialization
	void Start ()
    {
        bulletstrength = 15.5f;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject tempholder;

            tempholder = Instantiate(bullet, target.transform.position, target.transform.rotation) as GameObject;

            Rigidbody rigTemp = tempholder.GetComponent<Rigidbody>();

            rigTemp.AddForce(transform.forward * bulletstrength);

            //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            Destroy(tempholder, 10.0f);
        }

		
	}
}
