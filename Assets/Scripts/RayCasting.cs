using UnityEngine;

public class RayCasting : MonoBehaviour
{
    public static float distanceFromTarget = 0.0f;
    [SerializeField] float toTarget = 0.0f;
    [SerializeField] GameObject hitThing;

    void Update()
    {
        Vector3 test = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
        Debug.DrawRay(test, transform.forward, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
            hitThing = hit.collider.gameObject;
        }

    }
}
