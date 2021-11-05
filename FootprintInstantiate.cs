using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootprintInstantiate : MonoBehaviour
{
    public GameObject prefab;
    public float timeForNext = 5f;
    public float maxHeight = 1;
    int set;
    bool wait;


    private void Update()
    {
        if (set == 1 && !wait && Input.GetKey("up"))
        {
            Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + maxHeight, transform.position.z), Quaternion.identity);
            wait = true;
            StartCoroutine("next");
        }

    }

    IEnumerator next()
    {
        yield return new WaitForSeconds(timeForNext);
        wait = false;
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.tag == "Ground")
        {
            set = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        set = 0;
    }

}
