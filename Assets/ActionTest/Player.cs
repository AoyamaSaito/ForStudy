using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public event Action PlayerDeathCallBack;

    public void Death()
    {
        PlayerDeathCallBack.Invoke();
    }
}
