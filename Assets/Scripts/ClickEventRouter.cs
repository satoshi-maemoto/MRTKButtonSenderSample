using Microsoft.MixedReality.Toolkit.UI;
using System;
using UnityEngine;
using UnityEngine.Events;

public class ClickEventRouter : MonoBehaviour
{
    [Serializable]
    public class InternalButtonClickedEvent : UnityEvent<GameObject> { }

    public InternalButtonClickedEvent OnClick;

    void Start()
    {
        this.GetComponent<ButtonConfigHelper>()?.OnClick.AddListener(() =>
        {
            this.OnClick?.Invoke(this.gameObject);
        });
    }
}
