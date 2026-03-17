using TMPro;
using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumber;
    [SerializeField] string myName;
    [SerializeField] bool myChoice=false;
    int myOtherNumber;

    [SerializeField] GameObject myGate;
    [SerializeField] GameObject name1;
    [SerializeField] GameObject name2;
    [SerializeField] GameObject gateButton;

    void Start()
    {
        myNumber = 4;
        myName = "Steve";
        myChoice = true;

       // Unlock and show the cursor
       // Cursor.lockState = CursorLockMode.None;
       // Cursor.visible = true;
    }

    void Update()
    {
        if (myChoice)
        {
            //name1.GetComponent<TMP_Text>().text = myName;
            name1.GetComponent<TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
            name2.GetComponent<TMP_Text>().text = $"";
            //myGate.SetActive(true);
        } else
        {
            //myGate.SetActive(false);
            name1.GetComponent<TMP_Text>().text = $"";
            name2.GetComponent<TMP_Text>().text = $"My Number: {myNumber} My Name: {myName}";
        }
        
    }

    public void OpenGate()
    {
        myGate.GetComponent<Animator>().Play("GateSwing");
    }
    public void HideButton()
    {
        gateButton?.SetActive(false);
    }
}
