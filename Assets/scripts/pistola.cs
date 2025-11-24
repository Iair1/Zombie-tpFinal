using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistola : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float shootingForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject bulletClone = Instantiate(bullet, firePoint.position, transform.rotation);
            bulletClone.GetComponent<Rigidbody>().AddForce(transform.forward * shootingForce, ForceMode.Impulse);
        }
    }
}