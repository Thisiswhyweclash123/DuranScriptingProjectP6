using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunction : MonoBehaviour
{
    //create an integer variable
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //run the variable through my function
        myInt = MultiplyByTwo(myInt);

        //display the result in the console
        Debug.Log(myInt);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //creating a results variable
    int MultiplyByTwo(int number)
    {
        //create a results variable
        int result;
        result = number * 2;

        //return the result
        return result;

    }


}