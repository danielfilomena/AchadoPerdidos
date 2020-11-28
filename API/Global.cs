using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public static class Global
    {
                
        public static string CriptografaSenha(string senha)
        {
            
            char[] c = senha.ToUpper().ToCharArray();
            string texto = string.Empty;
            
            for (int i = 0; i < senha.Length; i++)
            {                

                if (i % 2 == 0)
                {

                    texto += (char)(c[i] + 3);
                                       
                }
                else
                {
                    texto += (char)(c[i] + 17);
                }

            }

            texto = GerarHashSenha(texto);

            return texto;

        }

        private static string GerarHashSenha(string senha)
        {

            StringBuilder sb = new StringBuilder();
            
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(inputBytes);
                
            foreach (var item in hash)
            {

                sb.Append(item.ToString("X2"));

            }            

            return sb.ToString();

        }

    }
}
