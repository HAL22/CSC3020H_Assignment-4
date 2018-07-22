using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

    public float damage = 10.0f;

    public float range = 100.0f;

    public Camera fpsCamera;

    public GameObject hiteffect;

    public GameObject groundhit;

    public ParticleSystem muzzleflash;

    public AudioClip clip;

    public AudioSource source;

	// Use this for initialization
	void Start ()
    {

        source.clip = clip;
   
		
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
                source.Play();

                GameObject hObject = Instantiate(hiteffect, hit.point, Quaternion.LookRotation(hit.normal));

                


                t.damage(damage);

                Destroy(hObject, 2f);
            }

            else
            {

                source.Play();

                GameObject gObject = Instantiate(groundhit, hit.point, Quaternion.LookRotation(hit.normal));

                

                Destroy(gObject, 2f);

            }

            







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
