using UnityEngine;
using UnityEngine.Events;

namespace Project._Scripts.ProjectCore.LoginScreen
{
  public class SubmitButton : MonoBehaviour
  {
    public UnityEvent OnSuccess;
    public UnityEvent OnFail;
    
    
    public void UIF_BUTTON_Submit()
    {
      if (Core.LoginScreen.TargetUsername == Core.LoginScreen.Username
          && Core.LoginScreen.TargetPassword == Core.LoginScreen.Password)
      {
        OnSuccess?.Invoke();
      }

      else
      {
        OnFail?.Invoke();
      }
    }
  }
}
