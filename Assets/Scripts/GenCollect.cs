using UnityEngine;

public class GenCollect : MonoBehaviour
{
    [SerializeField] AudioSource ding;

    void OnTriggerEnter(Collider other)
    {
        ding.Play(); 
        Destroy(gameObject);
    }
}
