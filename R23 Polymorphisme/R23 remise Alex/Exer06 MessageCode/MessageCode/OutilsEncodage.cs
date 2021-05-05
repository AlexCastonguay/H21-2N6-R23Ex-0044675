using System.Text;

namespace MessageCode
{
    public static class OutilsEncodage
    {
        public static string EffectuerUnEncodageSimple(string pMessage)
        {
            StringBuilder objStringBuilder = new StringBuilder(pMessage);
            for (int index = 0; index < objStringBuilder.Length / 2; index++)
            {
                char temp = objStringBuilder[index];
                objStringBuilder[index] = objStringBuilder[objStringBuilder.Length - index - 1];
                objStringBuilder[objStringBuilder.Length - index - 1] = temp;
            }
            return objStringBuilder.ToString();
        }

        public static string EffectuerUnEncodageMoyen(string pMessage)
        {
            StringBuilder objStringBuilder = new StringBuilder(pMessage);
            for (int index = 0; index < objStringBuilder.Length; index++)
                objStringBuilder[index] = (char)(objStringBuilder[index] + 3);
            return objStringBuilder.ToString();
        }

        public static string EffectuerUnEncodageComplexe(string pMessage)
        {
            StringBuilder objStringBuilder = new StringBuilder(pMessage);
            for (int index = 0; index < objStringBuilder.Length; index++)
                objStringBuilder[index] = (char)(objStringBuilder[index] ^ 15);
            return objStringBuilder.ToString();
        }
    }
}