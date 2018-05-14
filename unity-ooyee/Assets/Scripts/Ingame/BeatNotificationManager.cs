using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class BeatNotificationManager : MonoBehaviourSingleton<BeatNotificationManager>
{
    private Action chain;

    public void AddObserver(Action observer)
    {
        chain += observer;
    }

    private void Update()
	{
		
	}
}
