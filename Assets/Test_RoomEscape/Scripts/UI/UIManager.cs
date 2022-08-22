using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test_RoomEscape
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager I;

        GameObject _backBtnObj;
        GameObject _leftBtnObj;
        GameObject _rightBtnObj;

        public UI_Inventory _ui_iven;

        void Awake()
        {
            I = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            _ui_iven = transform.Find("UI_Inventory").GetComponent<UI_Inventory>();

            _backBtnObj = transform.Find("BackButton").gameObject;
            _leftBtnObj = transform.Find("LeftButton").gameObject;
            _rightBtnObj = transform.Find("RightButton").gameObject;

            bool mainView = true;
            OnChangeView(mainView);
        }

        public void OnChangeView(bool isMainView) // true: 메인 뷰 상태, false: 확대된 상태
        {
            // 현재 메인뷰 상태라면 (true) 백버튼은 더이상 못하도록 비활성화, 나머지는 활성화
            _backBtnObj.SetActive(!isMainView);
            _leftBtnObj.SetActive(isMainView);
            _rightBtnObj.SetActive(isMainView);
        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}
