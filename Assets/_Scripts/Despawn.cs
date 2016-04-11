using UnityEngine;
using System.Collections;

public class Despawn : MonoBehaviour
{
    float PoopTime;
    public float poopTime;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        PoopTime += Time.deltaTime;

        if (PoopTime >= poopTime)
        {
            Destroy(this.gameObject);
        }
    }
}
