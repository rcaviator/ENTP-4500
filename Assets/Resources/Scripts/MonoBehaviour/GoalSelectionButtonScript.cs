using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalSelectionButtonScript : MonoBehaviour
{
    [SerializeField]
    FitnessGoal goal;

    Text goalSelectionText;

	// Use this for initialization
	void Start ()
    {
        goalSelectionText = transform.GetChild(0).GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (goal == GameManager.Instance.SelectedFitnessGoal)
        {
            goalSelectionText.text = "Goal Selected";
        }
        else
        {
            goalSelectionText.text = "Select goal";
        }
	}

    /// <summary>
    /// Changes the goal in GameManager
    /// </summary>
    public void OnSelectionClick()
    {
        GameManager.Instance.SelectedFitnessGoal = goal;
    }
}
