using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Naninovel;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    public async void Click()
    {
        await RuntimeInitializer.InitializeAsync();
    }

}
