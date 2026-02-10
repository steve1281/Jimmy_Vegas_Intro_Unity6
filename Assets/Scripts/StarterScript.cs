using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice=false;
    int myOtherNumber;

    [SerializeField] GameObject myGate;
    
    void Start()
    {
        myNumber = 4;
        myName = "Steve";
        myChoice = true;
    }

    void Update()
    {
        if (myChoice)
        {
            myGate.SetActive(true);
        } else
        {
            myGate.SetActive(false);
        }
        
    }
}
