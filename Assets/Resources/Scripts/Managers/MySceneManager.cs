using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// enum of all the scenes in the game
/// </summary>
public enum Scenes
{
    //add all scene names to this enum
    //main scenes
    Main,

    //test scenes
    
}

/// <summary>
/// MySceneManager is the main class that controlls the game's scenes
/// </summary>
class MySceneManager
{
    #region Fields

    //singleton instance
    static MySceneManager instance;

    //dictionary of scenes
    Dictionary<Scenes, string> sceneDict;

    #endregion

    #region Constructor

    /// <summary>
    /// Private internal constructor called when the Instance
    /// property is invoked
    /// </summary>
    private MySceneManager()
    {
        //initialize the scene dictionary
        sceneDict = new Dictionary<Scenes, string>()
        {
            //add any new scene to this load list
            { Scenes.Main, "Main" }
        };
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the singleton instance of MySceneManager
    /// </summary>
    public static MySceneManager Instance
    {
        get { return instance ?? (instance = new MySceneManager()); }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Changes the Unity scene to a different one
    /// </summary>
    /// <param name="name">the name of the scene to change to</param>
    public void ChangeScene(Scenes name)
    {
        if (sceneDict.ContainsKey(name))
        {
            SceneManager.LoadScene(sceneDict[name]);
        }
    }

    /// <summary>
    /// Updates the scene for when a change must be made and saved later on
    /// </summary>
    /// <param name="name">the name of the scene to update</param>
    /// <param name="entity">the thing that is changing</param>
    public void UpdateScene(Scenes name, GameObject entity)
    {
        //not implemented
    }

    #endregion

    #region SceneDate Class

    /// <summary>
    /// SceneDate will store all date of a scene for
    /// easy read and right to disk in serialized binary
    /// </summary>
    class SceneData
    {
        //not implemented
    }

    #endregion
}