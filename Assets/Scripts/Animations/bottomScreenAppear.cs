using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomScreenAppear : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void appear()
    {
        transform.LeanScale(Vector2.one, 0.6f).setEaseOutQuart();
        //transform.LeanMoveLocal(new Vector2((float)0.0050049, (float)-668.4), 1).setEaseOutQuart();
    }

    public void disapear()
    {
        transform.LeanScale(Vector2.zero, 0.7f).setEaseOutQuart();
        //transform.LeanMoveLocal(new Vector2((float)0.0050049, (float)-1017.19), 1).setEaseOutQuart();
    }
}
