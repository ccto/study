using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview
{
    public class StringUnique
    {

        //实现一个算法来判断一个字符串中的字符是否唯一(即没有重复).不能使用额外的数据结构。 (即只使用基本的数据结构)


        public bool IsUniqueChars(string str)
        {
            bool[] char_set = new bool[256];

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];
                if (char_set[val]) return false;
                char_set[val] = true;
            }
            return true;
        }

        public bool IsUniqueChars2(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - (int)'a';
                if ((checker & (1 << val)) > 0) return false;
                checker |= (1 << val);
            }

            return true;
        }
    }
}
