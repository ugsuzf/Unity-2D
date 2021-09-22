using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] public string storyText;
    public State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }
    public State[] GetNextStates() {
        return nextStates;
    }


}
