using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    private float fireTime;
    public float fireRate;
    public ParticleSystem ps;
   // public AudioSource ses;
    void Start()
    {
        fireTime = 0f + Time.time;
        Instantiate(ps,new Vector3(transform.position.x-1, transform.position.y, transform.position.z),new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z+90, transform.rotation.w),transform);
    }

    void Update()
    {
        if (Time.time > fireTime )
        {
            //Instantiate(ses, transform.position, transform.rotation);
            Instantiate(bullet, transform.position, transform.rotation);
            fireTime += fireRate;
        }
    }
}
