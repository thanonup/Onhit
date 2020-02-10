using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour
{
    public Collider HitBox;

    public GameObject SFXAttackYellow, SFXAttackBlue;
    public AudioClip SoundAttackYellow, SoundAttackBlue;

    public Slider SliderHealth;
    float amountReduce;

    private void Start()
    {
        HitBox = gameObject.GetComponent<Collider>();
    }
    private void OnCollisionEnter(Collision other)
    {
        ParticleCtrl(other.gameObject.tag);
        PlaySoundCtrl(other.gameObject.tag);
        reduceHealthBar(other.gameObject.tag);
    }
    void ParticleCtrl(string other)
    {
        switch (other)
        {
            case "YellowNPC":
                SFXCtrl.instance.ShowAttackSparkle(gameObject.transform.position, SFXAttackYellow);
                break;

            case "BlueNPC":
                SFXCtrl.instance.ShowAttackSparkle(gameObject.transform.position, SFXAttackBlue);
                break;

            default:
                break;
         

        }
    }
    void PlaySoundCtrl(string other)
    {
        switch (other)
        {
            case "YellowNPC":
                SoundCtrl.instance.ShowAttackSparkle(gameObject.transform.position,SoundAttackYellow);
                break;

            case "BlueNPC":
                SoundCtrl.instance.ShowAttackSparkle(gameObject.transform.position,SoundAttackBlue);
                break;

            default:
                break;
        }
    }
    void reduceHealthBar(string other)
    {
        switch (other)
        {
            case "YellowNPC":
                amountReduce = 0.2f;
                break;
            case "BlueNPC":
                amountReduce = 0.1f;
                break;

            default:
                break;
        }
        if (SliderHealth)
        {
            SliderHealth.value = SliderHealth.value - amountReduce;
        }
    }

    
}
