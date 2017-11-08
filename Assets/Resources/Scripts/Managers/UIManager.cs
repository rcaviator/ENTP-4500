//using System;
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
    //default
    None,

    //main menus
    HamburgerMenuCanvas, MainMenuCanvas, FitnessGoalsCanvas,
    WorkoutBuilderCanvas, ProgressCanvas, DailyPlannerCanvas,

    //helper uis
    FitnessGoalsHelpCanvas,

    //exploration goals
    StrengthExplorationGoalCanvas,

    //exercise explaination uis
    PushUpExerciseCanvas,
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
    Dictionary<UICanvases, GameObject> uiDictPrefabs;
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
        uiDictPrefabs = new Dictionary<UICanvases, GameObject>()
        {
            //add any new UI canvas prefab names to this list at the end of the string
            //leave { UICanvases.None, <load> } out
            { UICanvases.HamburgerMenuCanvas, Resources.Load<GameObject>("Prefabs/UI/HamburgerMenuCanvas") },
            { UICanvases.MainMenuCanvas, Resources.Load<GameObject>("Prefabs/UI/MainMenuCanvas") },
            { UICanvases.FitnessGoalsCanvas, Resources.Load<GameObject>("Prefabs/UI/FitnessGoalsCanvas") },
            { UICanvases.FitnessGoalsHelpCanvas, Resources.Load<GameObject>("Prefabs/UI/HelpFitnessGoalsCanvas") },
            { UICanvases.StrengthExplorationGoalCanvas, Resources.Load<GameObject>("Prefabs/UI/StrengthExplorationGoalCanvas") },
            { UICanvases.WorkoutBuilderCanvas, Resources.Load<GameObject>("Prefabs/UI/WorkoutBuilderCanvas") },
            { UICanvases.PushUpExerciseCanvas, Resources.Load<GameObject>("Prefabs/UI/PushUpExerciseCanvas") },
            { UICanvases.ProgressCanvas, Resources.Load<GameObject>("Prefabs/UI/ProgressCanvas") },
            { UICanvases.DailyPlannerCanvas, Resources.Load<GameObject>("Prefabs/UI/DailyPlannerCanvas") },

        };

        uiDict = new Dictionary<UICanvases, GameObject>();
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
    /// Initiallizes the canvases
    /// </summary>
    public void Initialize()
    {
        //Debug.Log("Run canvas creation");

        //loop through the dictionary and load all prefabs,
        //set their camera, add them to the gameobject dictionary, and disable them
        foreach (KeyValuePair<UICanvases, GameObject> entry in uiDictPrefabs)
        {
            GameObject u = MonoBehaviour.Instantiate(entry.Value, Vector3.zero, Quaternion.identity);
            u.GetComponent<Canvas>().worldCamera = Camera.main;
            uiDict.Add(entry.Key, u);
            u.SetActive(false);
        }

        //enable the main menu
        if (uiDict.ContainsKey(UICanvases.MainMenuCanvas))
        {
            uiDict[UICanvases.MainMenuCanvas].SetActive(true);
        }

        //set the current fitness goal
        GameManager.Instance.SelectedFitnessGoal = FitnessGoal.None;
    }

    /// <summary>
    /// Enables or disables the hamburger menu canvas
    /// </summary>
    public void EnableDisableHamburgerMenu(bool active)
    {
        uiDict[UICanvases.HamburgerMenuCanvas].SetActive(active);
    }

    /// <summary>
    /// Closes the UI and enables the one to change to
    /// </summary>
    /// <param name="newMenu">the new menu to go to</param>
    public void CloseAndChangeUI(UICanvases newMenu)
    {
        //check if enum is in dictionary
        if (!uiDict.ContainsKey(newMenu))
        {
            Debug.Log(newMenu + " is not in the uiDict dictionary! Aborting menu change.");
            return;
        }

        //loop through the dictionary and disable all the ui
        foreach (KeyValuePair<UICanvases, GameObject> entry in uiDict)
        {
            entry.Value.SetActive(false);
        }

        //enable the menu to change to
        uiDict[newMenu].SetActive(true);
    }

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