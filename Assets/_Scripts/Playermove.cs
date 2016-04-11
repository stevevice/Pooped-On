using UnityEngine;
using System.Collections;

public class Playermove : MonoBehaviour
{
    public float speed;

    public GameObject Poop;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Sidespeed = Input.GetAxis("Horizontal") * speed;

        Vector3 PPosition = new Vector3(Sidespeed, 0.0f, 0.0f);

        rb.AddForce(PPosition * speed);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(Poop, gameObject.transform.position + new Vector3(0.0f, -1f, 0.0f) , Quaternion.identity);
        }
    }
}