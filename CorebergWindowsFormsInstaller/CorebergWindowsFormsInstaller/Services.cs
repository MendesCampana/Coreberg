﻿using System.ServiceProcess;

namespace CorebergWindowsFormsInstaller
{
    internal class Services
    {
        private static ServiceController[] services = ServiceController.GetServices();

        public static void DisplayList()
        {
            foreach (ServiceController sc in services)
            {
                //Console.WriteLine(sc.DisplayName);
            }
        }

        public static void DisplayList(string str)
        {
            foreach (ServiceController sc in services)
            {
                if (sc.DisplayName.ToLower().Contains(str))
                {
                    //Console.WriteLine(sc.DisplayName);
                }
            }
        }

        static public bool Check(string str)
        {
            bool flag = false;
            foreach (ServiceController sc in services)
            {
                if (sc.DisplayName.ToLower().Contains(str.ToLower())) flag = true;
            }
            return flag;
        }
    }
}