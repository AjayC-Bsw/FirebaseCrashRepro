using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Extensions;
// using Firebase.Messaging;
// using GoogleMobileAds.Api;
public class FirebaseInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(_ => Debug.Log("firebase initialized"));

        
    }


}
