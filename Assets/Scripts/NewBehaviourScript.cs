using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public ToolTip toolTip01;
    public ToolTip toolTip02;

    public void ButtonClicked()
    {
        this.toolTip01.ToolTipText = this.GetEventSender()?.name;
    }

    private GameObject GetEventSender()
    {
        foreach (var inputSource in CoreServices.InputSystem.DetectedInputSources)
        {
            foreach (var pointer in inputSource.Pointers)
            {
                if (pointer.IsInteractionEnabled)
                {
                    var sender = CoreServices.InputSystem.FocusProvider.GetFocusedObject(pointer);
                    if (sender?.GetComponent<Interactable>() != null)
                    {
                        return sender;
                    }
                }
            }
        }
        return null;
    }



    public void ButtonClickedWithGameObject(GameObject go)
    {
        this.toolTip02.ToolTipText = go?.name;
    }
}
