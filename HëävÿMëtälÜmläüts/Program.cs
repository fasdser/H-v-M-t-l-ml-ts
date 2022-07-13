using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HëävÿMëtälÜmläüts
{
    internal class Program
    {
        /* Your retro heavy metal band, VÄxën, originally started as kind of a joke, just because why would anyone want to use the crappy foosball table in your startup's game room when they could 
         * be rocking out at top volume in there instead? Yes, a joke, but now all the top tech companies are paying you top dollar to play at their conferences and big product-release events.
         * And just as how in the early days of the Internet companies were naming everything "i"-this and "e"-that, now that VÄxënmänïä has conquered the tech world, any company that doesn't use Hëävÿ Mëtäl Ümläüts in ëvëry pössïblë pläcë is looking hopelessly behind the times.
        Well, with great power chords there must also come great responsibility! 
        You need to help these companies out by writing a function that will guarantee that their web sites and ads and everything else will RÖCK ÄS MÜCH ÄS PÖSSÏBLË! Just think about it -- with the licensing fees you'll be getting from Gööglë, Fäcëböök, Äpplë, and Ämäzön alone, you'll probably be able to end world hunger, make college and Marshall stacks free to all, and invent self-driving bumper cars.Sö lët's gët röckïng and röllïng! Pëdal tö thë MËTÄL!
        Here's a little cheatsheet that will help you write your function to replace the so-last-year letters a-e-i-o-u-and-sometimes-y with the following totally rocking letters:*/

        /* Ваша ретро-хэви-метал группа, VÄxën, изначально создавалась как своего рода шутка, потому что зачем кому-то хотеть использовать дрянной настольный футбол в игровой комнате вашего стартапа, когда они могли
        * вместо этого качаться на максимальной громкости? Да, шутка, но теперь все ведущие технологические компании платят вам большие деньги за участие в их конференциях и крупных мероприятиях по выпуску продуктов.
        * И точно так же, как в первые дни Интернета компании называли все «i» — это и «e» — это, теперь, когда VÄxënmanïa завоевала мир технологий, любая компания, которая не использует Hëävÿ Mëtäl Ümläuts в ëvëry pössïblë pläcë безнадежно отстает от времени.
       Что ж, с мощными аккордами должна прийти и большая ответственность!
       Вы должны помочь этим компаниям, написав функцию, гарантирующую, что их веб-сайты, реклама и все остальное будут ПОТРЯСАЮЩИМИ! Только подумайте об этом — с лицензионными отчислениями, которые вы будете получать только от Gööglë, Fäcëböok, Äpplë и Ämäzön, вы, вероятно, сможете покончить с голодом в мире, сделать колледжи и стеки Marshall бесплатными для всех и изобрести самостоятельную за рулем машинок с бамперами. Педаль в пол!
       Вот небольшая шпаргалка, которая поможет вам написать функцию, заменяющую буквы «так-последнего года» a-e-i-o-u-and-sometimes-y следующими совершенно потрясающими буквами:*/

        /*A = Ä = \u00c4      E = Ë = \u00cb     I = Ï = \u00cf
          O = Ö = \u00d6      U = Ü = \u00dc     Y = Ÿ = \u0178
          a = ä = \u00e4      e = ë = \u00eb     i = ï = \u00ef
          o = ö = \u00f6      u = ü = \u00fc     y = ÿ = \u00ff*/
        static void Main(string[] args)
        {
            HeavyMetalUmlauts("Ännöüncïng thë Mäcböök Äïr Güïtär");
            Console.WriteLine(HeavyMetalUmlauts("Ännöüncïng thë Mäcböök Äïr Güïtär"));
            // Console.WriteLine('\u00c4');
            Console.ReadLine();

        }

        public static string HeavyMetalUmlauts(string boringText)
        {
            char[] chars = boringText.ToCharArray();
            string result = "";
            char[] oporttunities = new char[] { 'Ä', 'Ö', 'ä', 'ö', 'Ë', 'Ü', 'ë', 'ü', 'Ï', 'Ÿ', 'ï', 'ÿ' };
            char[] charsEn = new char[] { '\u00c4', '\u00d6', '\u00e4', '\u00f6', '\u00cb', '\u00dc', '\u00eb', '\u00fc', '\u00cf', '\u0178', '\u00ef', '\u00ff' };
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < oporttunities.Length; j++)
                {
                    if (chars[i] == oporttunities[j])
                    {
                        result += charsEn[j];
                        break;
                    }
                    else if (chars[i] != oporttunities[j])
                    {
                        result += chars[i];
                        break;
                    }
                }
            }


            return result;
        }

        public static string HeavyMetalUmlauts1(string boringText)
        {
            string strfrom = "AEIOUYaeiouy";
            string strto = "ÄËÏÖÜŸäëïöüÿ";
            for (int i = 0; i < strfrom.Length; i++)
                boringText = boringText.Replace(strfrom[i], strto[i]);
            return boringText;
        }

        public static string HeavyMetalUmlauts2(string boringText)
        {
            var letters = new Dictionary<char, char>(){
      {'A', 'Ä'}, {'O', 'Ö'}, {'a', 'ä'}, {'o', 'ö'},
      {'E', 'Ë'}, {'U', 'Ü'}, {'e', 'ë'}, {'u', 'ü'},
      {'I', 'Ï'}, {'Y', 'Ÿ'}, {'i', 'ï'}, {'y', 'ÿ'}
    };

            return String.Concat(boringText.Select(c => letters.ContainsKey(c) ? letters[c] : c).ToArray());
        }

        public static string HeavyMetalUmlauts3(string boringText)
        {
            string NewString = "";
            foreach (var item in boringText)
            {
                NewString += OneLetterChange(item);
            }
            return NewString;
        }
        public static string OneLetterChange(char letter)
        {
            switch (letter.ToString())
            {
                case "A": return "Ä";
                case "O": return "Ö";
                case "a": return "ä";
                case "o": return "ö";
                case "E": return "Ë";
                case "U": return "Ü";
                case "e": return "ë";
                case "u": return "ü";
                case "I": return "Ï";
                case "Y": return "Ÿ";
                case "i": return "ï";
                case "y": return "ÿ";
                default: return letter.ToString();
            }
        }
    }
}
