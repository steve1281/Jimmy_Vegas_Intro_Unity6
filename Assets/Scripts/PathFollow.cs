using System.Collections;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    private GameObject destination;

    void Start()
    {
        destination = new GameObject("Destination");
        destination.transform.position = new Vector3(20, 2, 0);
        StartCoroutine(NextDestination());
    }

    void Update()
    {
        transform.LookAt(destination.transform);
        transform.position = Vector3.MoveTowards(transform.position,
            destination.transform.position,
            0.01f);
    }

    IEnumerator NextDestination()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(22, 2, -6);
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(16, 2, -6);
            yield return new WaitForSeconds(2f);
            destination.transform.position = new Vector3(20, 2, 0);
        }
    }
}
