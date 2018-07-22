using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

    public float health=50f;
    public GameObject explosion;
    private Transform loc;

    public AudioClip clip;

   // public AudioSource source;





    // Use this for initialization
    void Start ()
    {
      //  source.clip = clip;
        //s mat = GetComponent<Material>();




    }

    public void changeMaterial(Material m)
    {
        GetComponent<Renderer>().material  = m;
        loc = GetComponent<Transform>();
    }



    public void damage(float amount)
    {
        health = health - amount;

        if (health <= 0)
        {
            die();
        }
    }

    void die()
    {
        AudioSource source = GetComponent<AudioSource>();
     //   source.clip = clip;
        GameObject exe= Instantiate(explosion,transform.position,Quaternion.identity);

        source.PlayOneShot(clip);
        
        Destroy(gameObject);

        Destroy(exe, 2f);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
