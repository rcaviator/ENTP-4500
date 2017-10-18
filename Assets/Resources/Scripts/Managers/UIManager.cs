using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// enum of all the major UICanvases
/// </summary>
public enum UICanvases
{
    //add all ui canvase GameObject prefab names here
    MainMenuCanvas,
}

/// <summary>
/// UIManager is the main class that controlls the game's UI
/// </summary>
class UIManager
{
    #region Fields

    //singleton instance of class
    static UIManager instance;

    //dictionary of all the UI canvases
    Dictionary<UICanvases, GameObject> uiDict;

    #endregion

    #region Constructor

    /// <summary>
    /// Private internal constructor called when the Instance
    /// property is invoked
    /// </summary>
    private UIManager()
    {
        //initialize the UI dictionary
        uiDict = new Dictionary<UICanvases, GameObject>()
        {
            //add any new UI canvas prefab names to this list at the end of the string
            { UICanvases.MainMenuCanvas, Resources.Load<GameObject>("Prefabs/UI/") },
        };
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the singletong instance of UIManager
    /// </summary>
    public static UIManager Instance
    {
        get { return instance ?? (instance = new UIManager()); }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Gets the UI canvas GameObject if it is in the UI dictionary
    /// </summary>
    /// <param name="name">the name of the canvase GameObject</param>
    /// <returns>the canvas GameObject</returns>
    public GameObject GetUICanvas(UICanvases name)
    {
        if (uiDict.ContainsKey(name))
        {
            return uiDict[name];
        }
        else
        {
            Debug.Log("Key " + name + " was not in the UI dictionary");
            return null;
        }
    }

    #endregion
}