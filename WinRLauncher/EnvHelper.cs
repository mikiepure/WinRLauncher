using Microsoft.Win32;
using System.Collections.Generic;

namespace WinRLauncher
{
    internal class EnvHelper
    {
        private static readonly string ENV_USER_PATH = @"Environment";
        private static readonly string ENV_MACHINE_PATH = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";

        public static string GetUserValue(string key, RegistryValueOptions options)
        {
            return GetValue(key, Registry.CurrentUser, ENV_USER_PATH, options);
        }

        public static string[] GetUserValues(string key, RegistryValueOptions options)
        {
            return GetValue(key, Registry.CurrentUser, ENV_USER_PATH, options).Split(new char[] { ';' });
        }

        public static string GetMachineValue(string key, RegistryValueOptions options)
        {
            return GetValue(key, Registry.LocalMachine, ENV_MACHINE_PATH, options);
        }

        public static string[] GetMachineValues(string key, RegistryValueOptions options)
        {
            return GetValue(key, Registry.LocalMachine, ENV_MACHINE_PATH, options).Split(new char[] { ';' });
        }

        private static string GetValue(string key, RegistryKey type, string typePath, RegistryValueOptions options)
        {
            string value;
            using (var subKey = type.OpenSubKey(typePath))
            {
                value = (key != null) ? (string)(subKey.GetValue(key, null, options)) : (null);
            }
            return value;
        }

        public static void SetUserValue(string key, string value, RegistryValueKind kind)
        {
            SetValue(key, value, Registry.CurrentUser, ENV_USER_PATH, kind);
        }

        public static void SetUserValues(string key, IEnumerable<string> value, RegistryValueKind kind)
        {
            SetValue(key, string.Join(";", value), Registry.CurrentUser, ENV_USER_PATH, kind);
        }

        public static void SetMachineValue(string key, string value, RegistryValueKind kind)
        {
            SetValue(key, value, Registry.LocalMachine, ENV_MACHINE_PATH, kind);
        }

        public static void SetMachineValues(string key, IEnumerable<string> value, RegistryValueKind kind)
        {
            SetValue(key, string.Join(";", value), Registry.LocalMachine, ENV_MACHINE_PATH, kind);
        }

        private static void SetValue(string key, string value, RegistryKey type, string typePath, RegistryValueKind kind)
        {
            using (var subKey = type.CreateSubKey(typePath))
            {
                subKey?.SetValue(key, value, kind);
            }
        }

        public static void DeleteUserKey(string key)
        {
            DeleteKey(key, Registry.CurrentUser, ENV_USER_PATH);
        }

        public static void DeleteMachineKey(string key)
        {
            DeleteKey(key, Registry.LocalMachine, ENV_MACHINE_PATH);
        }

        private static void DeleteKey(string key, RegistryKey type, string typePath)
        {
            using (var subKey = type.CreateSubKey(typePath))
            {
                subKey.DeleteValue(key, false);
            }
        }
    }
}
