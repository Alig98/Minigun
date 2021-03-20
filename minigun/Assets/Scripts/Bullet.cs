using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float destroyTime;
    public ParticleSystem ps;
    void Start()
    {
        transform.Rotate(Random.Range(-2, 2), Random.Range(-2, 2), Random.Range(-2, 2));
        destroyTime = Time.time + 3f;
    }
    void Update()
    {
        transform.position += transform.up * 300f * Time.deltaTime;
        if (Time.time > destroyTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Instantiate(ps,collision.collider.transform.position,Quaternion.identity);
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        Destroy(gameObject);
    }

}
