using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UsePassword.Librerias
{
    public class Cifrado
    {
        AesCryptoServiceProvider Cifrador;
        public void IniciarAES(string Llave)
        {
            Rfc2898DeriveBytes llaveSimetrica = new Rfc2898DeriveBytes(Llave, 20);

            Cifrador = new AesCryptoServiceProvider();
            Cifrador.BlockSize = 128;
            Cifrador.KeySize = 256;
            Cifrador.GenerateIV();
            Cifrador.Key = llaveSimetrica.GetBytes(24);
            Cifrador.Mode = CipherMode.CBC;
            Cifrador.Padding = PaddingMode.PKCS7;
        }

        public String Cifrar(String cadena)
        {
            ICryptoTransform transforma = Cifrador.CreateEncryptor();
            byte[] CadenaCifrada = transforma.TransformFinalBlock(System.Text.ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
            return Convert.ToBase64String(CadenaCifrada);
        }

        public string Decifrar(string Cadena)
        {
            ICryptoTransform transforma = Cifrador.CreateDecryptor();
            byte[] Base64 = Convert.FromBase64String(Cadena);
            byte[] Texto = transforma.TransformFinalBlock(Base64, 0, Base64.Length);
            return System.Text.ASCIIEncoding.ASCII.GetString(Texto);
        }
    }
}
