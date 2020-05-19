using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Enable_WDigest
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Win32.RegistryKey key;
            //Set Key Location
            key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\SecurityProviders\WDigest", true);
            //Create a new key with set value's
            key.SetValue("UseLogonCredential", "1", RegistryValueKind.DWord);
            //Close Key
            key.Close();
        }
    }
}
