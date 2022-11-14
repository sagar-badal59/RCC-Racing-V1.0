using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkConst : MonoBehaviour
{
    [Serializable]
    public struct postLogin
    {
        public string email;
        public string password;
    }


    [Serializable]
    public struct postRegister
    {
        public string name;
        public string email;
        public string password;
        public int mobile;
        public string companyName;
        public string city;
        public string country;
        public int user_type;
    }

    public struct postRevover
    {
        public string name;
        public string email;
    }
    public struct series
    {
        public string ID;
        public string name;
        public string serieVersion;
        public int creatoraccountID;
        public float price;
        public bool enabled;
        public string availabilityMode;
        public DateTime dateCreated;
        public string Comment;
        public string Settings;
        public string Explanations;
        public int Level;
        public string Category;
        public string SubCategory;
        public string Tag;
        public byte[] previewPicture;
        public string previewText;

    }

}
