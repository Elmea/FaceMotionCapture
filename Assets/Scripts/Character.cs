using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniVRM10;

[RequireComponent(typeof(AnimationHandler))]
[RequireComponent(typeof(Vrm10Instance))]
public class Character : MonoBehaviour
{
    AnimationHandler animHandler;
    Vrm10Instance vrmInstance;
    VRM10Object vrmObject;

    // Start is called before the first frame update
    void Start()
    {
        animHandler = GetComponent<AnimationHandler>();
        vrmInstance = GetComponent<Vrm10Instance>();
        vrmObject = vrmInstance.Vrm;
    }

    // Update is called once per frame
    void Update()
    {
        vrmInstance.Runtime.Expression.SetWeight(ExpressionKey.CreateFromPreset(ExpressionPreset.happy), 1.0f);
    }
}
