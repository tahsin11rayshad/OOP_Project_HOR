﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_HOR
{
    static class utility
    {
        public static List<user> users = new List<user>();
        public static List<user> Bariwala= new List<user>();
        public static List<user> Varatia = new List<user>();
        
        public static List<property> properties = new List<property>();
        public static List<property> allproperties= new List<property>();


        public static string folderdir = @"C:\HoR";
        public static string slash = @"\";

        public static string currentdir;
        public static user currentuser;

        public static void addkori()
        {
            foreach(user u in Bariwala)
            {
                users.Add(u);
            }
            foreach(user u in Varatia)
            {
                users.Add(u);
            }
        }
    }
}
