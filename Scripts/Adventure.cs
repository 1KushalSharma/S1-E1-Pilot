using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Adventure : MonoBehaviour
{
    [SerializeField] State StateA1;
    [SerializeField] Text textComponent1;


    // Start is called before the first frame update

    State state;

    void Start()
        {
            state = StateA1;
            textComponent1.text = state.GetStateStory();
            Debug.Log(textComponent1.text.ToString());
        }
       
    // Update is called once per frame
    void Update()
    {
        NextStates();
    }

    private void NextStates()
    {
       
        State[] tempstate = state.GetState();
        for(int i=0;i<tempstate.Length;i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1+ i ))
            {
                state = tempstate[i];
            }
        }
        textComponent1.text = state.GetStateStory();
    }
}
