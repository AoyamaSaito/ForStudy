using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager
{
    private Player player;
    public void SpawnPlayer()
    {
        player.PlayerDeathCallBack += OnPlayerDeath;
    }

    //直接呼び出される訳ではなく、コールバックによって呼び出される
    private void OnPlayerDeath()
    {
        //プレイヤーが死んだ時の処理
    }
}
