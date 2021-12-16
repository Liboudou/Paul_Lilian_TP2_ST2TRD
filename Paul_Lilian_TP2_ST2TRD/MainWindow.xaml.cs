using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Paul_Lilian_TP2_ST2TRD
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
	/// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Encryption(object sender, RoutedEventArgs e)
        {
            int a = 0;
            string b = null;
            string Encry_text = "";
            string valueCb = null;
            if (ComboBox1.SelectedItem != null) valueCb = ComboBox1.SelectedValue.ToString(); 
            

           
            if (valueCb == "Cesar")
            {
                
                try { a = Int32.Parse(TextBox1.Text); }
                catch(System.FormatException) { };
                Encry_text = Cesar(lstNames.Text, a);
                
            }
            if (valueCb == "Vigenere")
            {
               
                try { b = TextBox1.Text;
                    
                }
                catch (System.FormatException) { };
                Encry_text = V_Encipher(lstNames.Text, b);
                
            }
            if (valueCb == "Froduleux")
            {

                try { a = Int32.Parse(TextBox1.Text); }
                catch (System.FormatException) { };
                Encry_text = Froduleux(lstNames.Text, a);

            }
            if (valueCb == "Hexa")
            {

                try { a = Int32.Parse(TextBox1.Text); }
                catch (System.FormatException) { };
                Encry_text = ToHexString(lstNames.Text);

            }

            lstNames2.Text = Encry_text;

            

            
            
        }
        private void Decryption(object sender, RoutedEventArgs e)
        {
            int a = 0;
            string b = null;
            string Decry_test = null;
            string valueCb = null;
            if (ComboBox1.SelectedItem != null) valueCb = ComboBox1.SelectedValue.ToString();

            if (valueCb == "Cesar")
            {

                try { a = Int32.Parse(TextBox1.Text); }
                catch (System.FormatException) { };
                Decry_test = Cesar_reverse(lstNames.Text, a);

            }


            if (valueCb == "Vigenere")
            {

                try { b = TextBox1.Text; }
                catch (System.FormatException) { };
                Decry_test = V_Decipher(lstNames.Text, b);

            }
            if (valueCb == "Froduleux")
            {

                try { a = Int32.Parse(TextBox1.Text); }
                catch (System.FormatException) { };
                Decry_test = Reverse_Froduleux(lstNames.Text, a);

            }
            if (valueCb == "Hexa")
            {

                try { a = Int32.Parse(TextBox1.Text); }
                catch (System.FormatException) { };
                Decry_test = FromHexString(lstNames.Text);

            }


            lstNames2.Text = Decry_test;
            


        }

        

        private void del1(object sender, RoutedEventArgs e)
        {

            lstNames.Clear();
            lstNames2.Clear();
            TextBox1.Clear();
            
            MessageBox.Show("All clear chef !");


        }
        private void Export(object sender, RoutedEventArgs e)
        {

            lstNames.Text = lstNames2.Text;
            lstNames2.Clear();



        }


        public static string ToHexString(string str)
        {
            var sb = new StringBuilder();

            var bytes = Encoding.Unicode.GetBytes(str);
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString(); 
        }

        public static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                try { bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16); }
                catch { };
            }

            return Encoding.Unicode.GetString(bytes);
        }


        public string Cesar(string mot, int decalage)
        {
            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            char[] chars = mot.ToCharArray();
            for (int i = 0; i < mot.Length; i++)
            {
                int c = chars[i];
                if ('a' <= c && c <= 'z')
                    c = 'a' + mod(c - 'a' + decalage, 26);
                else if ('A' <= c && c <= 'Z')
                    c = 'A' + mod(c - 'A' + decalage, 26);
                else if ('0' <= c && c <= '9')
                    c = '0' + mod(c - '9' + decalage, 10);
                chars[i] = (char)c;
            }

            return new String(chars);
        }
        public string Cesar_reverse(string mot, int decalage)
        {
            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            char[] chars = mot.ToCharArray();
            for (int i = 0; i < mot.Length; i++)
            {
                int c = chars[i];
                if ('a' <= c && c <= 'z')
                    c = 'a' + mod(c - 'a' - decalage, 26);
                else if ('A' <= c && c <= 'Z')
                    c = 'A' + mod(c - 'A' - decalage, 26);
                else if ('0' <= c && c <= '9')
                    c = '0' + mod(c - '9' - decalage, 10);
                chars[i] = (char)c;
            }

            return new String(chars);
        }
        public string Froduleux(string mot, int decalage)
        {
            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            char[] chars = mot.ToCharArray();
            for (int i = 0; i < mot.Length; i++)
            {
                int c = chars[i];
                if ('a' <= c && c <= 'z')
                    c = 'a' + mod(c - 'a' + decalage + 2, 26);
                else if ('A' <= c && c <= 'Z')
                    c = 'A' + mod(c - 'A' + decalage + 2, 26);
                else if ('0' <= c && c <= '9')
                    c = '0' + mod(c - '9' + decalage + 2, 10);
                chars[i] = (char)c;
            }

            return new String(chars);
        }
        public string Reverse_Froduleux(string mot, int decalage)
        {
            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            char[] chars = mot.ToCharArray();
            for (int i = 0; i < mot.Length; i++)
            {
                int c = chars[i];
                if ('a' <= c && c <= 'z')
                    c = 'a' + mod(c - 'a' - decalage -2, 26);
                else if ('A' <= c && c <= 'Z')
                    c = 'A' + mod(c - 'A' - decalage -2, 26);
                else if ('0' <= c && c <= '9')
                    c = '0' + mod(c - '9' - decalage -2, 10);
                chars[i] = (char)c;
            }

            return new String(chars);
        }


        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static string Cipher(string input, string key, bool encipher)
        {
            
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // Error

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }
            
            return output;
        }

        public static string V_Encipher(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public static string V_Decipher(string input, string key)
        {
            return Cipher(input, key, false);
        }



    }
}
