using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;

    private void OnTriggerEnter(Collider other)
    {
        //Destory this object that a script is attached to
        Destroy(gameObject);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

        //Destory other object that hits a trigger
        Destroy(other.gameObject);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

    }
}