using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    // Start is called before the first frame update
    [TextArea(14, 10)] [SerializeField] string StoryText;
    [SerializeField] State[] nextstates;
    
    public string GetStateStory()
    {
        return StoryText;
    }
    public State[] GetState()
    {
        return nextstates;
    }
}
