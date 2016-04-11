using UnityEngine;
using System.Collections;

public class Movement2nd : MonoBehaviour
{
    float speed;

    public GameObject PoopedCharacter;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //    gameObject.transform.position = new Vector3(.5f, 0.0f, 0.0f);

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //    gameObject.transform.position = new Vector3(-.5f, 0.0f, 0.0f);

    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(PoopedCharacter, gameObject.transform.position, Quaternion.identity);
    }
}
