using Project._Scripts.Library.UI;

namespace Project._Scripts.ProjectCore.LoginScreen
{
  public class Field : InputField
  {
    public enum Type{Username, Password}
    public Type FieldType;
    
    protected override void Change(string str)
    {
      base.Change(str);

      switch ( FieldType )
      {
        case Type.Username:
          Core.LoginScreen.OnUsernameChangedCallback?.Invoke(InputMessage);
          break;
        case Type.Password:
          Core.LoginScreen.OnPasswordChangedCallback?.Invoke(InputMessage);
          break;
      }
    }
  }
}
