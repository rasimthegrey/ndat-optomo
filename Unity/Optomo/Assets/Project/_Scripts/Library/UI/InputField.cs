using Project._Scripts.Runtime.Library.UI.Core;
using TMPro;
using UnityEngine;

namespace Project._Scripts.Library.UI
{
  public class InputField : InputFieldBase
  {
    protected string InputMessage { get; set; }
    protected override void Change(string str) {InputMessage = str;}
    protected override void Submit(string str) {}
    protected override void End(string str){}
  }
}
