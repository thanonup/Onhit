using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCtrl : MonoBehaviour
{
    public static SoundCtrl instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void ShowAttackSparkle(Vector3 pos, AudioClip Soundname)
    {
        AudioSource.PlayClipAtPoint(Soundname, pos);

    }

}
