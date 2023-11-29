using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class StratButton : MonoBehaviour
{

        private void Update()
        {
                if (GameManager.I.NameText.text.Length < 2)
                {
                        GameManager.I.StartButton.interactable = false;
                }
                else
                {
                        GameManager.I.StartButton.interactable = true;
                }
        }
        public void goStrat()
        {
                GameManager.I.Player = Instantiate(GameManager.I.PickCharertherPrefab, GameManager.I.PickCharertherPrefab.transform.position, Quaternion.identity);
                GameManager.I.vcam.Follow = GameManager.I.Player.transform;
                GameManager.I.PlayerName = GameManager.I.Player.transform.Find("Canvas").Find("RawImage").Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
                GameManager.I.PlayerName.text = GameManager.I.NameText.text;
                GameManager.I.StartPanel.SetActive(false);
                GameManager.I.PickPanel.SetActive(false);
                GameManager.I.PickButton.SetActive(false);

        }
}
