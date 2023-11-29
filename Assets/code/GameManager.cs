using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class GameManager : MonoBehaviour
{
        public static GameManager I;

        public TextMeshProUGUI NameText;
        public Button StartButton;

        public GameObject Player;

        public GameObject[] Prefabs;
        public GameObject PickCharertherPrefab;

        public TextMeshProUGUI PlayerName;
        public CinemachineVirtualCamera vcam;
        public TextMeshProUGUI TimeText;

        public GameObject PickPanel; //ĳ���� ���� â
        public GameObject StartPanel; // ����ȭ��
        public GameObject PickButton; // ����â�� ���� ��ư


        private void Awake()
        {
                I = GetComponent<GameManager>();
                Prefabs = Resources.LoadAll<GameObject>("Prefabs");
        }

        private void Update()
        {
                TimeText.text = System.DateTime.Now.ToString("HH:mm");
        }
}
