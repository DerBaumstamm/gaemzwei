using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UAU");
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 0.01f ;
        }
     if(Input.GetKeyDown(KeyCode.F)) {
            StartCoroutine(UAUA());
        }
    }

    IEnumerator UAUA()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Selbstzerstörung in...");
        yield return new WaitForSeconds(1f);
        Debug.Log("3");
        yield return new WaitForSeconds(1f);
        Debug.Log("2");
        yield return new WaitForSeconds(1f);
        Debug.Log("1");
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < 1000; i++)
        {
            transform.Rotate(Vector3.up * 1f);
            yield return new WaitForSeconds(0.001f);
        }
        yield return new WaitForSeconds(1f);
        Debug.Log("B.");
        yield return new WaitForSeconds(0.2f);
        Debug.Log("E.");
        yield return new WaitForSeconds(0.2f);
        Debug.Log("A.");
        yield return new WaitForSeconds(0.2f);
        Debug.Log("N.");
        yield return new WaitForSeconds(1.5f);
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
        yield return new WaitForSeconds(1.5f);
        GetComponent<Rigidbody>().AddForce(Vector3.forward * 10000);
        yield return new WaitForSeconds(1.5f);
        GetComponent<Rigidbody>().AddForce(Vector3.right * 10000);
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        transform.position = Vector3.zero;
#sehr wichtig für schulinternet
    }
}
