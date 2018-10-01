﻿using System.Diagnostics;
using System.Linq;

namespace ConvertWork
{
    using System;

    public static class Program
    {
        // Roman

        private const string RomanNarrow =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        private const string RomanWide =
            "ＡＢＣＤＥＦＧＨＩＪＫＬＭＮＯＰＱＲＳＴＵＶＷＸＹＺａｂｃｄｅｆｇｈｉｊｋｌｍｎｏｐｑｒｓｔｕｖｗｘｙｚ";

        // Numeric

        private const string NumericNarrow =
            "0123456789";

        private const string NumericWide =
            "０１２３４５６７８９";

        // ASCII

        private const string AsciiNarrow =
            "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~｡｢｣､･";

        private const string AsciiWide =
            "！”＃＄％＆’（）＊＋，－．／：；＜＝＞？＠［￥］＾＿｀｛｜｝￣。「」、・";

        // Kana

        private const string KanaNarrow =
            "ｧｨｩｪｫｬｭｮｯｰｱｲｳｴｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾅﾆﾇﾈﾉﾊﾋﾌﾍﾎﾏﾐﾑﾒﾓﾔﾕﾖﾗﾘﾙﾚﾛﾜｦﾝﾞﾟ";

        private const string KanaWide =
            "ァィゥェォャュョッーアイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲン゛゜";

        private const string HiraganaWide =
            "ぁぃぅぇぉゃゅょっーあいうえおかきくけこさしすせそたちつてとなにぬねのはひふへほまみむめもやゆよらりるれろわをん゛゜";

        // KanaDakuon

        private const string KanaDakuonNarrow =
            "ｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾊﾋﾌﾍﾎｳﾜｦ";

        private const string KanaDakuonWide =
            "ガギグゲゴザジズゼゾダヂヅデドバビブベボヴ\u30f7\u30fa";

        private const string HiraganaDakuonWide =
            "がぎぐげござじずぜぞだぢづでどばびぶべぼヴ\u30f7\u30fa";

        // KanaHandakuon

        private const string KanaHandakuonNarrow =
            "ﾊﾋﾌﾍﾎ";

        private const string KanaHandakuonWide =
            "パピプペポ";

        private const string HiraganaHandakuonWide =
            "ぱぴぷぺぽ";

        public static void Main(string[] args)
        {
            //Test(RomanNarrow);
            //Test(RomanWide);
            //Test(NumericNarrow);
            //Test(NumericWide);
            //Test(AsciiNarrow);
            Test(AsciiWide);

            //Test(KanaNarrow);
            //Test(KanaWide);
            //Test(HiraganaWide);
            //Test(KanaDakuonNarrow);
            //Test(KanaDakuonWide);
            //Test(HiraganaDakuonWide);
            //Test(KanaHandakuonNarrow);
            //Test(KanaHandakuonWide);
            //Test(HiraganaHandakuonWide);
        }

        private static void Test(string str)
        {
            var chars = str.ToCharArray().OrderBy(x => x).ToArray();
            Debug.WriteLine("--" + new string(chars));

            var start = -1;
            for (var i = 0; i < chars.Length; i++)
            {
                if (start == -1)
                {
                    start = i;
                }

                if ((i == chars.Length - 1) || ((i < chars.Length - 1) && (chars[i] + 1 != chars[i + 1])))
                {
                    var convert = new char[i - start + 1];
                    for (var j = 0; j < convert.Length; j++)
                    {
                        convert[j] = chars[start + j];
                    }

                    Debug.WriteLine(new string(convert));

                    start = -1;
                }
            }

            Debug.WriteLine("");
        }
    }
}