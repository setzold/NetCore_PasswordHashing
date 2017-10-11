using System;
using System.Runtime.InteropServices;
using System.Security;

namespace PasswordHashing_Pbkdf2.Console
{
    public class SecureStringBuilder
    {
        public SecureString ConvertToSecureString(string strPassword)
        {
            var result = new SecureString();
            if (strPassword.Length > 0)
            {
                foreach (var chr in strPassword.ToCharArray())
                    result.AppendChar(chr);
            }
            return result;
        }

        public string ConvertFromSecureString(SecureString secureString)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
