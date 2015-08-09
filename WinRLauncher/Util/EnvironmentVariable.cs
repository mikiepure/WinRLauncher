using Microsoft.Win32;

namespace WinRLauncher.Util
{
    public class EnvironmentVariable
    {
        // -- Properties -- //

        private static string EnvironmentUserPath { get; } = @"Environment";
        private static string EnvironmentMachinePath { get; } = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment";

        // -- Methods -- //

        public static string getUserValue(string key, RegistryValueOptions options)
        {
            return getValue(key, Registry.CurrentUser, EnvironmentUserPath, options);
        }

        public static string[] getUserValues(string key, RegistryValueOptions options)
        {
            return getValue(key, Registry.CurrentUser, EnvironmentUserPath, options).Split(new char[] { ';' });
        }

        public static string getMachineValue(string key, RegistryValueOptions options)
        {
            return getValue(key, Registry.LocalMachine, EnvironmentMachinePath, options);
        }

        public static string[] getMachineValues(string key, RegistryValueOptions options)
        {
            return getValue(key, Registry.LocalMachine, EnvironmentMachinePath, options).Split(new char[] { ';' });
        }

        private static string getValue(string key, RegistryKey type, string typePath, RegistryValueOptions options)
        {
            string value;
            using (var subKey = type.OpenSubKey(typePath))
            {
                value = (key != null) ? (string)(subKey.GetValue(key, null, options)) : (null);
            }
            return value;
        }

        public static void setUserValue(string key, string value, RegistryValueKind kind)
        {
            setValue(key, value, Registry.CurrentUser, EnvironmentUserPath, kind);
        }

        public static void setUserValues(string key, string[] value, RegistryValueKind kind)
        {
            setValue(key, string.Join(";", value), Registry.CurrentUser, EnvironmentUserPath, kind);
        }

        public static void setMachineValue(string key, string value, RegistryValueKind kind)
        {
            setValue(key, value, Registry.LocalMachine, EnvironmentMachinePath, kind);
        }

        public static void setMachineValues(string key, string[] value, RegistryValueKind kind)
        {
            setValue(key, string.Join(";", value), Registry.LocalMachine, EnvironmentMachinePath, kind);
        }

        private static void setValue(string key, string value, RegistryKey type, string typePath, RegistryValueKind kind)
        {
            using (var subKey = type.CreateSubKey(typePath))
            {
                subKey?.SetValue(key, value, kind);
            }
        }

        public static void deleteUserKey(string key)
        {
            deleteKey(key, EnvironmentUserPath);
        }

        public static void deleteMachineKey(string key)
        {
            deleteKey(key, EnvironmentMachinePath);
        }

        private static void deleteKey(string key, string typePath)
        {
            using (var subKey = Registry.CurrentUser.CreateSubKey(typePath))
            {
                subKey.DeleteValue(key, false);
            }
        }
    }
}
