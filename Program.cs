using System;

namespace I_praktine_uzduotis_Vigenere
{

    class Vigenere
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("####################################################");
            Console.WriteLine("VIGENERE ENCRYPTION/DECRYPTION");
            Console.WriteLine("####################################################");


            Console.WriteLine("Please input word or phrase: ");
            String enteredText = Console.ReadLine();
            Console.WriteLine("Please input key: ");
            String keyword = Console.ReadLine();



            String key = keyGenerator(enteredText, keyword);
            String encryptedtxt = encryptedText(enteredText, key);


            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Encrypted text: "
                + encryptedtxt + "\n");

            Console.WriteLine("Decrypted Text: "
                + decryptedText(encryptedtxt, key));
        }

        static String keyGenerator(String str, String key) //generate key until it is same length as enetered text
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);
            }
            return key;
        }


        // encryption
        static String encryptedText(String str, String key)
        {
            String encryptedtxt = "";

            for (int i = 0; i < str.Length; i++)
            {
                //ASCII range
                int x = (str[i] + key[i]) % 128;



                encryptedtxt += (char)(x);
            }
            return encryptedtxt;
        }

        //decryption
        static String decryptedText(String encryptedtxt, String key)
        {
            String decryptedtxt = "";

            for (int i = 0; i < encryptedtxt.Length &&
                                    i < key.Length; i++)
            {

                int x = (encryptedtxt[i] -
                            key[i] + 128) % 128;


                decryptedtxt += (char)(x);
            }
            return decryptedtxt;
        }



    }

}