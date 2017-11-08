using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    Text currentText;

	// Use this for initialization
	void Start ()
    {
        currentText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentText.text = "Current selected goal: " + GameManager.Instance.SelectedFitnessGoal;
	}
}
