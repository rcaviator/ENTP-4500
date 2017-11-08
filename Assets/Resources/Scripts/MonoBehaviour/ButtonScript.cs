using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    UICanvases menu;

    /// <summary>
    /// Changes the menu based on the enum set from the inspector
    /// </summary>
    public void OnButtonClickMenuChange()
    {
        if (menu == UICanvases.HamburgerMenuCanvas)
        {
            UIManager.Instance.EnableDisableHamburgerMenu(true);
        }
        else
        {
            UIManager.Instance.CloseAndChangeUI(menu);
        }
    }
}
