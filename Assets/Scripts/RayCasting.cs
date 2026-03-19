using UnityEngine;
using UnityEngine.InputSystem;

public class RayCasting : MonoBehaviour
{
    public static float distanceFromTarget = 3.0f;
    [SerializeField] float toTarget = 0.0f;
    [SerializeField] GameObject hitThing;

    void Update()
    {
        Vector3 test = new Vector3(transform.position.x, transform.position.y+1f, transform.position.z);
        Debug.DrawRay(test, transform.forward, Color.green);

        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                toTarget = hit.distance;
                distanceFromTarget = toTarget;
                hitThing = hit.collider.gameObject;
            }
        }

    }
}
