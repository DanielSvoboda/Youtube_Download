using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_Download
{
    internal class decodeCipher
    {
        public static string DecodeCipher(string signatureCipher)
        {
            string primeiraParte = System.Web.HttpUtility.UrlDecode(signatureCipher.Substring(2, signatureCipher.IndexOf('&') - 2));
            string segundaParte = System.Web.HttpUtility.UrlDecode(signatureCipher.Substring(signatureCipher.IndexOf("&sp=sig&url=") + "&sp=sig&url=".Length));

            string a = System.Web.HttpUtility.UrlDecode(primeiraParte);
            string urlDecodificada = System.Web.HttpUtility.UrlDecode(segundaParte);

            char[] chars = a.ToCharArray();
            zP.G6(ref chars, 3);
            zP.Co(chars, 6);
            zP.G6(ref chars, 1);
            zP.W3(chars, 59);
            zP.Co(chars, 39);
            zP.W3(chars, 25);
            zP.Co(chars, 38);
            zP.W3(chars, 17);
            return urlDecodificada + "&sig=" + new string(chars);
        }
    }

    internal static class zP
    {
        public static void Co(char[] a, int b)
        {
            // Salva o caractere na posição 0
            char c = a[0];
            // Troca o caractere na posição 0 com o caractere na posição b % tamanho do array.
            a[0] = a[b % a.Length];
            // Coloca o caractere salvo na posição b % tamanho do array.
            a[b % a.Length] = c;
        }

        public static void G6(ref char[] a, int b)
        {
            // Remover os primeiros 'b' elementos do array 'a'
            if (b >= a.Length)
            {
                // Se 'b' for maior ou igual ao comprimento do array, tornar o array vazio
                a = new char[0];
            }
            else
            {
                // Caso contrário, copiar os elementos restantes
                Array.Copy(a, b, a, 0, a.Length - b);
                // Redimensionar o array para remover os elementos excedentes
                Array.Resize(ref a, a.Length - b);
            }
        }

        public static void W3(char[] a, int parametroNumerico)
        {
            //inverter o array
            Array.Reverse(a);
        }

    }

}
