using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{

    public GameObject bullet;
    public GameObject shootingOffset;
    public AudioSource gunshot;
    float time = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject currentBullet = Instantiate(bullet, shootingOffset.transform.position, shootingOffset.transform.rotation);
            currentBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 100, ForceMode.Impulse);
            gunshot.Play();
            time -= Time.deltaTime;
            if (time <= 0)
            {
                Destroy(currentBullet);
                time = 2;
            }
        }

        
    }
}
