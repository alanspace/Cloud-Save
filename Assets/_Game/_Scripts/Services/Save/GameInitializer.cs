using Unity.Services.Core;
using Unity.Services.CloudSave;
using UnityEngine;

public class GameInitializer : MonoBehaviour
{
    private async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
            Debug.Log("Unity Gaming Services initialized.");
        }
        catch (System.Exception ex)
        {
            Debug.LogError($"Failed to initialize Unity Gaming Services: {ex}");
        }
    }
}