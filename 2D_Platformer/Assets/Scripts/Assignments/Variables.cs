using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string firstName = "Preston";
    int age = 40;
    float height = 6.3f;
    bool married = true;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Married: " + married);
    }

    
}
