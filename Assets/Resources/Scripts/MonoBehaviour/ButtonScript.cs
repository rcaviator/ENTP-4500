using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    UICanvases menu;

	//// Use this for initialization
	//void Start ()
 //   {
		
	//}
	
	//// Update is called once per frame
	//void Update ()
 //   {
		
	//}

    /// <summary>
    /// Changes the menu based on the enum set from the inspector
    /// </summary>
    public void OnButtonClickMenuChange()
    {
        UIManager.Instance.CloseAndChangeUI(menu);
    }
}
