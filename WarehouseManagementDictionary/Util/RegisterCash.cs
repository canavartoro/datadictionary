using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System;
using Microsoft.Win32;

namespace ORSMESEntegrasyonu.Util
{
    public class RegisterCash
    {
        private TRegister tr;

        private TRegister Req
        {
            get
            {
                if (tr == null)
                    tr = new TRegister();
                return tr;
            }
        }

        #region Genel
        public string ReadCash(string name, string dval)
        {
            return Req.ReadRegister(name, dval);
        }

        public void WriteCash(string name, string val)
        {
            Req.WriteRegister(name, val);
        }
        #endregion

        public static void WriterSerialize(object serObj, string name)
        {
            try
            {
                string fname = Utility.AppPath + "\\" + name;
                if (serObj == null)
                {
                    if (File.Exists(fname))
                        File.Delete(fname);
                    return;
                }

                XmlSerializer x = new XmlSerializer(serObj.GetType());
                using (StreamWriter writer = new StreamWriter(fname))
                {
                    x.Serialize(writer, serObj);
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (System.Exception exc)
            {
                Utility.Hata(string.Format("Obe kaydedilirken hata:{0}", exc.Message));
            }
        }

        public static object ReadFile(Type objTye, string name)
        {
            try
            {
                if (File.Exists(Utility.AppPath + "\\" + name))
                {
                    object obj;
                    XmlSerializer x = new XmlSerializer(objTye);
                    using (StreamReader reader = new StreamReader(Utility.AppPath + "\\" + name))
                    {
                        obj = x.Deserialize(reader);
                        reader.Close();
                    }
                    return obj;
                }
            }
            catch { }
            return null;
        }
    }

    public class TRegister
    {
        private RegistryKey hKey;
        private string hKeyName;

        public TRegister()
        {
        }

        public TRegister(RegistryKey pkey)
        {
            hKey = pkey;
        }

        public TRegister(string keyname)
        {
            hKeyName = keyname;
        }

        //public RegistryKey GetKeyByName(RegistryHive hive, string path)
        //{
        //    if (hive == -2147483648)
        //    {
        //        return Registry.ClassesRoot.OpenSubKey(path, true);
        //    }
        //    if (hive == -2147483643)
        //    {
        //        return Registry.CurrentConfig.OpenSubKey(path, true);
        //    }
        //    if (hive != -2147483647)
        //    {
        //        if (hive == -2147483642)
        //        {
        //            return Registry.DynData.OpenSubKey(path, true);
        //        }
        //        if (hive == -2147483646)
        //        {
        //            return Registry.LocalMachine.OpenSubKey(path, true);
        //        }
        //        if (hive == -2147483644)
        //        {
        //            return Registry.PerformanceData.OpenSubKey(path, true);
        //        }
        //        if (hive == -2147483645)
        //        {
        //            return Registry.Users.OpenSubKey(path, true);
        //        }
        //    }
        //    return Registry.CurrentUser.OpenSubKey(path, true);
        //}

        public string ReadRegister(string key, string dvalue)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey("Barset") == null)
                {
                    Registry.CurrentUser.CreateSubKey("Barset");
                    WriteRegister(key, dvalue);
                    return dvalue;
                }
                RegistryKey key2 = Registry.CurrentUser.OpenSubKey("Barset");
                string str = key2.GetValue(key, dvalue).ToString();
                key2.Close();
                return str;
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
                return dvalue;
            }
        }

        public string ReadRegister(string name, string key, string dvalue)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(name) == null)
                {
                    Registry.CurrentUser.CreateSubKey(name);
                    WriteRegister(name, key, dvalue);
                    return dvalue;
                    return null;
                }
                RegistryKey key2 = Registry.CurrentUser.OpenSubKey(name);
                RegistryKey key3 = key2.OpenSubKey(name, true);
                if (key3 == null)
                {
                    key2.Close();
                    return null;
                }
                if (key3.GetValue(key) == null)
                {
                    return null;
                }
                string str = key3.GetValue(key).ToString();
                key3.Close();
                key2.Close();
                return str;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool WriteRegister(string key, string svalue)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey("Barset", true) == null)
                {
                    Registry.CurrentUser.CreateSubKey("Barset");
                }
                Registry.CurrentUser.OpenSubKey("Barset", true).SetValue(key, svalue);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool WriteRegister(string name, string key, string svalue)
        {
            try
            {
                if (Registry.CurrentUser.OpenSubKey(name, true) == null)
                {
                    Registry.CurrentUser.CreateSubKey(name);
                }
                RegistryKey key2 = Registry.CurrentUser.OpenSubKey(name, true);
                if (key2.OpenSubKey(name, true) == null)
                {
                    key2.CreateSubKey(name);
                }
                key2.OpenSubKey(name, true).SetValue(key, svalue);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}