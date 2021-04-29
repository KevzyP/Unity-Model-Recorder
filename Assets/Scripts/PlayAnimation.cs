using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Animancer;


public class PlayAnimation : MonoBehaviour
{
    [SerializeField] private AnimancerComponent _Animancer;
    [SerializeField] private AnimationClip _Idle;
    [SerializeField] private AnimationClip _Action;
    string m_Path;
    



    public void PlayClip()
    {
        
        if (GameObject.Find("B-hand_L (1)").GetComponent<ActivateRecording>().activated == true)
        {
            //DestroyPlayable(_Action);
        }
        //string animPath = "Assets/Animation/animResult.anim";
        //_Action = animPath;
        var state = _Animancer.Play(_Action);
        state.Time = 0;
        state.Events.OnEnd = () => _Animancer.Play(_Idle);
    }
    
    private void OnEnable()
    {
        m_Path = Application.dataPath;
        Debug.Log("dataPath : " + m_Path);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
