using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;
using UnityEngine.Animations;
using UnityEditor;

public class AnimatorStuff : MonoBehaviour
{
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{

        //    if (anim != null)
        //    {
        //        // play Bounce but start at a quarter of the way though
        //        anim.Play("Base Layer.Animation");
        //    }
        //}
    }
}
