using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    //public variables visible in unity
    public TextMesh displayText;

    //private variables cant be touched by other scripts
    private int currentValue = 0;

    //UPDATE BOTH THE DATA VALUE AND THE VISUAL DISPLAY 
    public void ChangeValue(int _toChange)
    {

        currentValue = currentValue + _toChange;
        displayText.text = currentValue.ToString();

    }

}
