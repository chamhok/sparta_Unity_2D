using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharertherPickButton : MonoBehaviour
{
        public void OnCharertherPickPanel()
        {
                GameManager.I.PickPanel.SetActive(true);
                GameManager.I.PickButton.SetActive(false);
                GameManager.I.StartPanel.SetActive(false);
        }
}
