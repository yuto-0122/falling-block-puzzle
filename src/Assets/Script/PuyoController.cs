using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuyoType
{
    Blank = 0,

    Green = 1,
    Red = 2,
    Yellow  = 3,
    Blue = 4,
    Purple = 5,
    
    Invalid = 7,
}

[RequireComponent(typeof(Renderer))]
public class PuyoController : MonoBehaviour
{
    //�ÓI�H
    static readonly Color[] color_table = new Color[]
    {
        //�v�f���w��
        Color.black,

        Color.green,
        Color.red,
        Color.yellow,
        Color.blue,
        Color.magenta,
        Color.cyan,

        Color.gray,
    };

    //���I
    [SerializeField] Renderer my_renderer = default!;
    PuyoType _type = PuyoType.Invalid;

    public void SetPuyoType(PuyoType type)
    {
        _type = type;

        my_renderer.material.color = color_table[(int)_type];
    }
    public PuyoType GetPuyoType()
    {
        return _type;
    }
    public void SetPos(Vector3 pos)
    {
        this.transform.localPosition = pos;
    }
}
