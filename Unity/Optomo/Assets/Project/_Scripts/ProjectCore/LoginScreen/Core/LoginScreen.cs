using System;
using UnityEngine;

namespace Project._Scripts.ProjectCore.LoginScreen.Core
{
  public class LoginScreen : MonoBehaviour
  {
    public const string Username = "admin";
    public const string Password = "password123";
    
    public static string TargetUsername { get; set; }
    public static string TargetPassword { get; set; }
    
    public static Action<string> OnUsernameChangedCallback { get; set; }
    public static Action<string> OnPasswordChangedCallback { get; set; }

    private void OnEnable()
    {
      OnUsernameChangedCallback += UpdateUsername;
      OnPasswordChangedCallback += UpdatePassword;
    }

    private void OnDisable()
    {
      OnUsernameChangedCallback = null;
      OnPasswordChangedCallback = null;
    }

    public void UpdateUsername(string content) => TargetUsername = content;
    public void UpdatePassword(string content) => TargetPassword = content;
  }
}
