using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// enum for setting the determined valued sliders
/// </summary>
public enum DeterminedSliderType
{
    Strength, Endurance, Balance, Flexibility
}

public class SliderStatScript : MonoBehaviour
{
    [SerializeField]
    DeterminedSliderType type;

    Slider statSlider;

	// Use this for initialization
	void Start ()
    {
        statSlider = GetComponent<Slider>();

        switch (type)
        {
            case DeterminedSliderType.Strength:
                GameManager.Instance.Strength = this;
                break;
            case DeterminedSliderType.Endurance:
                GameManager.Instance.Endurance = this;
                break;
            case DeterminedSliderType.Balance:
                GameManager.Instance.Balance = this;
                break;
            case DeterminedSliderType.Flexibility:
                GameManager.Instance.Flexibility = this;
                break;
            default:
                break;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        switch (type)
        {
            case DeterminedSliderType.Strength:
                switch (GameManager.Instance.SelectedFitnessGoal)
                {
                    case FitnessGoal.None:
                        statSlider.value = 0f;
                        break;
                    case FitnessGoal.Strength:
                        statSlider.value = Constants.STRENGTH_STRENGTH_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Endurance:
                        statSlider.value = Constants.STRENGTH_ENDURANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Balance:
                        statSlider.value = Constants.STRENGTH_BALANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Flexibility:
                        statSlider.value = Constants.STRENGTH_FLEXIBILITY_DETERMINED_SLIDER_VALUE;
                        break;
                    default:
                        break;
                }
                break;
            case DeterminedSliderType.Endurance:
                switch (GameManager.Instance.SelectedFitnessGoal)
                {
                    case FitnessGoal.None:
                        statSlider.value = 0f;
                        break;
                    case FitnessGoal.Strength:
                        statSlider.value = Constants.ENDURANCE_STRENGTH_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Endurance:
                        statSlider.value = Constants.ENDURANCE_ENDURANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Balance:
                        statSlider.value = Constants.ENDURANCE_BALANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Flexibility:
                        statSlider.value = Constants.ENDURANCE_FLEXIBILITY_DETERMINED_SLIDER_VALUE;
                        break;
                    default:
                        break;
                }
                break;
            case DeterminedSliderType.Balance:
                switch (GameManager.Instance.SelectedFitnessGoal)
                {
                    case FitnessGoal.None:
                        statSlider.value = 0f;
                        break;
                    case FitnessGoal.Strength:
                        statSlider.value = Constants.BALANCE_STRENGTH_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Endurance:
                        statSlider.value = Constants.BALANCE_ENDURANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Balance:
                        statSlider.value = Constants.BALANCE_BALANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Flexibility:
                        statSlider.value = Constants.BALANCE_FLEXIBILITY_DETERMINED_SLIDER_VALUE;
                        break;
                    default:
                        break;
                }
                break;
            case DeterminedSliderType.Flexibility:
                switch (GameManager.Instance.SelectedFitnessGoal)
                {
                    case FitnessGoal.None:
                        statSlider.value = 0f;
                        break;
                    case FitnessGoal.Strength:
                        statSlider.value = Constants.FLEXIBILITY_STRENGTH_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Endurance:
                        statSlider.value = Constants.FLEXIBILITY_ENDURANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Balance:
                        statSlider.value = Constants.FLEXIBILITY_BALANCE_DETERMINED_SLIDER_VALUE;
                        break;
                    case FitnessGoal.Flexibility:
                        statSlider.value = Constants.FLEXIBILITY_FLEXIBILITY_DETERMINED_SLIDER_VALUE;
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    }
}
