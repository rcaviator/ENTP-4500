using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// Sound effect enum
/// </summary>
public enum SoundEffect
{
    //all sound effects go here
    //UI
    ButtonPressForward, ButtonPressBackward, MenuChange, 

    //game sound effects
    Achievement, LevelUp, ExerciseAdded, ExerciseRemoved, StatBarReached,
    SessionWin, SessionLost, TimerTick
}

/// <summary>
/// AudioManager loads and stores all sounds as a singlton
/// </summary>
class AudioManager
{
    #region Fields

    //singleton instance
    static AudioManager instance;

    //music and soundeffect dictionaries
    Dictionary<string, AudioClip> musicDict;
    Dictionary<SoundEffect, AudioClip> sfxDict;

    #endregion

    #region Constructor

    /// <summary>
    /// Private internal constructor called when the Instance
    /// property is invoked
    /// </summary>
    private AudioManager()
    {
        //create the music dictionary and populate it
        musicDict = (Resources.LoadAll<AudioClip>("Assets/Sounds/Music")).ToDictionary(s => s.name);

        //create the sfx dictionary and populate it
        sfxDict = new Dictionary<SoundEffect, AudioClip>()
        {
            //add the name of the sound file to the end of each string minus the .extention
            //UI sounds
            { SoundEffect.ButtonPressForward, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.ButtonPressBackward, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.MenuChange, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            
            //game sound effects
            { SoundEffect.Achievement, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.LevelUp, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.ExerciseAdded, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.ExerciseRemoved, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.StatBarReached, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.SessionWin, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.SessionLost, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
            { SoundEffect.TimerTick, Resources.Load<AudioClip>("Assets/Sounds/Effects/") },
        };
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the singleton instance of the AudioManager
    /// </summary>
    public static AudioManager Instance
    {
        get { return instance ?? (instance = new AudioManager()); }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Gets a music track from the music dictionary
    /// </summary>
    /// <param name="name">the name of the track</param>
    /// <returns>the track as an AudioClip</returns>
    public AudioClip GetMusic(string name)
    {
        if (musicDict.ContainsKey(name))
        {
            return musicDict[name];
        }
        else
        {
            Debug.Log("Key " + name + " is not in the music dictionary");
            return null;
        }
    }

    /// <summary>
    /// Gets a sound effect from the sound effect dictionary
    /// </summary>
    /// <param name="name">the name of the sound effect</param>
    /// <returns>the sound effect as an AudioClip</returns>
    public AudioClip GetSoundEffect(SoundEffect name)
    {
        if (sfxDict.ContainsKey(name))
        {
            return sfxDict[name];
        }
        else
        {
            Debug.Log("Key " + name + " is not in the sound effect dictionary");
            return null;
        }
    }

    #endregion
}