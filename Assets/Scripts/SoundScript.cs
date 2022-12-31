using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip CoinClip;
    static AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        CoinClip = Resources.Load<AudioClip>("arrow");
        audio1= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string Clip)
    {
        switch(Clip)
        {
            case "arrow":
                audio1.PlayOneShot(CoinClip);
                break;
        }
    }
}
