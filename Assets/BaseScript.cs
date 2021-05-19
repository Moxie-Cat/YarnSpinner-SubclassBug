using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class BaseScript : MonoBehaviour
{
    public string ExampleField = "Base Script";

    [YarnCommand("ExampleCommand")]
    public void ExampleMethod()
    {
        Debug.Log("ExampleMethod has been called!");
    }
}
