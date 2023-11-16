using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace QuickProcessPlayerPrefs
{
    public class PlayerPrefUtils : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public string ListTostring(List<string> lst)
        {
            string result = string.Join(", ", lst);
            Debug.Log(result);
            return result;
        }
        public List<string> StringToLst(string lst)
        {

            string[] elements = lst.Split(new string[] { ", " }, StringSplitOptions.None);

            List<string> myList = new List<string>(elements);

            foreach (var item in myList)
            {
                Debug.Log(item);
            }
            return myList;
        }
    }
}