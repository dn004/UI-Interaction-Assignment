using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    public Slider _musicSlider;
    //public Button objectButton;
    public Slider _objectSlider;
    public Button targetButton;

    private RectTransform buttonRectTransform;

    public void ToggleMusic()
    {
        AudioManager.Instance.ToggleMusic();
    }

    public void MusicVolume()
    {
        AudioManager.Instance.MusicVolume(_musicSlider.value);
    }


    private void Start()
    {
        buttonRectTransform = targetButton.GetComponent<RectTransform>();  // Get the RectTransform component of the button
    }

    public void AdjustButtonSize()
    {
        float newSize = Mathf.Lerp(20, 150, _objectSlider.value);

        buttonRectTransform.sizeDelta = new Vector2(newSize, newSize);
    }
}
