using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseHamburgerMenuScript : MonoBehaviour
{
    /// <summary>
    /// Closes the hamburger menu
    /// </summary>
    public void OnHamburgerMenuClose()
    {
        UIManager.Instance.EnableDisableHamburgerMenu(false);
    }
}
