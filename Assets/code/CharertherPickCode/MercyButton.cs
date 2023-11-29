using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MercyButton : MonoBehaviour
{
        public void OffCharertherPickPanel()
        {
                GameManager.I.PickPanel.SetActive(false);
                GameManager.I.PickButton.SetActive(true);
                GameManager.I.StartPanel.SetActive(true);
        }
        public void PickMercy()
        {
                GameManager.I.PickCharertherPrefab = GameManager.I.Prefabs[0];
/*
                GameManager.I.Player = Instantiate(GameManager.I.Prefabs[0], GameManager.I.Prefabs[0].transform.position, Quaternion.identity);
                GameManager.I.vcam.Follow = GameManager.I.Player.transform;
                GameManager.I.PlayerName = GameManager.I.Player.transform.Find("Canvas").Find("RawImage").Find("Text (TMP)").GetComponent<TextMeshProUGUI>();
*/        }
}
