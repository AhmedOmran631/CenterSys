using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace CenterSys
{
   public  class RegistryControl
    {
        public RegistryKey Regkey;
        private static readonly String Password ="Center@Lab2003";


        /// <summary>
        /// Encrypt Text by Pass 
        /// </summary>
        /// <param name="Pass">Key</param>
        /// <param name="Txt_Decryption">Plain text</param>
        /// <returns></returns>
        public string Encrypt_Fun( string Txt_Decryption)
        {
            string EqulStr = "";
            Byte[] data_str = UTF8Encoding.UTF8.GetBytes(Txt_Decryption);

            using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
            {
                Byte[] keys = mds.ComputeHash(UTF8Encoding.UTF8.GetBytes(Password));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider())
                {

                    tripDes.Key = keys;
                    tripDes.Mode = CipherMode.ECB;
                    tripDes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    Byte[] results = transform.TransformFinalBlock(data_str, 0, data_str.Length);
                    EqulStr = Convert.ToBase64String(results, 0, results.Length);
                }
            }

            return EqulStr;
        }


        /// <summary>
        /// Decryption Text by Pass
        /// </summary>
        /// <param name="Pass">kay</param>
        /// <param name="txt_Encrypt">cipher text</param>
        /// <returns></returns>
        public string Decryption_Fun( string txt_Encrypt)
        {
            try
            {
                string EqulStr = "";
                Byte[] data_str = Convert.FromBase64String(txt_Encrypt);

                using (MD5CryptoServiceProvider mds = new MD5CryptoServiceProvider())
                {
                    Byte[] keys = mds.ComputeHash(UTF8Encoding.UTF8.GetBytes(Password));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider())
                    {

                        tripDes.Key = keys;
                        tripDes.Mode = CipherMode.ECB;
                        tripDes.Padding = PaddingMode.PKCS7;
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        Byte[] results = transform.TransformFinalBlock(data_str, 0, data_str.Length);
                        EqulStr = UTF8Encoding.UTF8.GetString(results);
                    }
                }

                return EqulStr;
            }
            catch (Exception ex)
            {
               // ConfigClass.log.Error($"E {ex.Message}");
                return "";
            }

        }



        //Save Settings for Server
        public bool Save_Setting(CommunicationModel communicationmodel)
        {
            try
            {
                var json =  JsonConvert.SerializeObject(communicationmodel);
                Regkey = Registry.CurrentUser.OpenSubKey("Software", true);
                Regkey.SetValue("Communication", Encrypt_Fun(json));
                Regkey.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        //Get Setting from registry
        //Key:  CenterLab-2021
        //serverName: localhost
        //DatabaseName: Centersys
        //userName: user
        //Password: 192837465

        public CommunicationModel get_setting()
        {
            try
            {
                Regkey = Registry.CurrentUser.OpenSubKey("Software", true);
                CommunicationModel Json = JsonConvert.DeserializeObject <CommunicationModel>( Decryption_Fun( Regkey.GetValue("Communication").ToString()));
                Regkey.Close();
                return Json;
            }
       
            catch 
            {
              //  ConfigClass.log.Error($"E {ex.Message}");
                return new CommunicationModel();
            }
        }

    }
}
