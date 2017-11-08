using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializerScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        GameManager.Instance.StartApp();
	}
}
