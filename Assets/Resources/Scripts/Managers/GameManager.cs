//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// enum for the selected fitness goal
/// </summary>
public enum FitnessGoal
{
    None, Strength, Endurance, Balance, Flexability
}

/// <summary>
/// GameManager is the main managing singlton class for the application
/// </summary>
class GameManager
{
    #region Fields

    //singleton instance
    static GameManager instance;

    //start controll
    bool firstRun = true;

    //selected fitness goal
    //FitnessGoal selectedGoal = FitnessGoal.None;

    #endregion

    #region Constructor

    /// <summary>
    /// Private internal constructor called when the Instance
    /// property is invoked
    /// </summary>
    private GameManager()
    {
        //creates the object that calls GM's Update method. It's an
        //object that barrows Update() from a MonoBehaviour object
        //and is continuously kept saved across all Unity scenes
        Object.DontDestroyOnLoad(new GameObject("gmUpdater", typeof(Updater)));
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the singleton instance of the GameManager
    /// </summary>
    public static GameManager Instance
    {
        get { return instance ?? (instance = new GameManager()); }
    }

    //other properties can be stored here.
    //example:

    /// <summary>
    /// Property for the current fitness goal
    /// </summary>
    public FitnessGoal SelectedFitnessGoal
    { get; set; }


    public SliderStatScript Strength
    { get; set; }


    public SliderStatScript Endurance
    { get; set; }


    public SliderStatScript Balance
    { get; set; }


    public SliderStatScript Flexibility
    { get; set; }

    #endregion

    #region Public Methods

    /// <summary>
    /// Starts the app
    /// </summary>
    public void StartApp()
    {
        if (firstRun)
        {
            UIManager.Instance.Initialize();
            firstRun = false;
        }
    }

    /// <summary>
    /// Returns the current fitness goal enum as a string
    /// </summary>
    /// <returns></returns>
    public string GetCurrentFitnessGoal()
    {
        switch (SelectedFitnessGoal)
        {
            case FitnessGoal.None:
                return "None";
                break;
            case FitnessGoal.Strength:
                return "Strength";
                break;
            case FitnessGoal.Endurance:
                return "Endurance";
                break;
            case FitnessGoal.Balance:
                return "Balance";
                break;
            case FitnessGoal.Flexability:
                return "Flexability";
                break;
            default:
                return "Error";
                break;
        }
    }

    #endregion

    #region Private Methods

    private void Update()
    {
        //anything that must be updated constantly for GM goes here
        //example:
        //UIManager.Instance.Update();
    }

    #endregion

    #region Internal Updater class

    /// <summary>
    /// Internal class that updates the GameManager
    /// </summary>
    class Updater : MonoBehaviour
    {
        // Update is called once per frame
        private void Update()
        {
            Instance.Update();
        }
    }

    #endregion
}