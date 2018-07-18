using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    public float damage = 10.0f;

    public float range = 100.0f;

    public Camera fpsCamera;

    public GameObject hiteffect;

    public ParticleSystem muzzleflash;

	// Use this for initialization
	void Start ()
    {
   
		
	}

    void shoot()
    {
        muzzleflash.Play();

        RaycastHit hit;

        if (Physics.Raycast(fpsCamera.transform.position,fpsCamera.transform.forward,out hit,range))
        {
            Debug.Log(hit.transform.name);

            target t = hit.transform.GetComponent<target>();

            if (t != null)
            {
                t.damage(damage);
            }

            Instantiate(hiteffect, hit.point, Quaternion.LookRotation(hit.normal));

        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            shoot();
           
        }

		
	}
}
