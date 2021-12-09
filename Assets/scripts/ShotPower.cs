using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShotPower : MonoBehaviour
{
    public GameObject line;

    public Rigidbody ball;

    public float rotationspeed = 5f;

    float xRot, yRot = 0f;

    public float strength = 15f;

    Vector3 orignalpos;

    public GameObject floor;

    public GameObject hoop;

    public Text score;

    public float number = 0f;

    private void Start() => orignalpos = gameObject.transform.position;

    

    private void OnTriggerEnter(Collider other){

        

        if(other.gameObject.CompareTag("floor"))
        {
            transform.position = orignalpos;
            ball.velocity = transform.position * 0;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        }
        else if (other.gameObject.tag == "hoop")
        {
            number = number + 1;
            score.text = number.ToString();
        }
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
