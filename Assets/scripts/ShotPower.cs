using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShotPower : MonoBehaviour
{
    public GameObject line;

    public Rigidbody ball;

    public float rotationspeed = 5f;

    float xRot, yRot = 0f;

    public float strength = 15f;

    Vector3 orignalpos;

    Vector3 orignalrot;

    public GameObject floor;

    public GameObject hoop;

    public  scoretext;

    private void Start()
    {
        orignalpos = gameObject.transform.position;
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (floor != null)
            transform.position = orignalpos;
        ball.velocity = transform.position * 0;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        
        if (hoop != null)


    }
    void Update()
    {
       

        if (Input.GetMouseButton(0))
        {
            line.SetActive(true);
            xRot += Input.GetAxis("Mouse X")*rotationspeed;
            yRot += Input.GetAxis("Mouse Y")*rotationspeed;
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }

        if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            line.SetActive(false);
            ball.velocity = transform.forward * strength;
            Debug.Log("Up");

        }

       
    }
}
