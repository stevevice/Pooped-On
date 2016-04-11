using UnityEngine;
using System.Collections;

public class PoopFeatures : MonoBehaviour
{
    float PoopTime;

    public GameObject Pooped;

    public float poopTime;

    // Update is called once per frame
    void Update()
    {
        PoopTime += Time.deltaTime;

        if (PoopTime >= poopTime)
        {
            Destroy(this.gameObject);
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(Pooped, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
