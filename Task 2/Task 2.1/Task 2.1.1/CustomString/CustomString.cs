using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class CustomString
    {
        private char[] _str;
        public int Length { get; set; }

        public CustomString(object input, int capacity)
        {
            var temp = input.ToString().ToArray();
            this.Length = capacity;
            this._str = temp;
        }
        public CustomString(object input) : this(input, input.ToString().Length)
        {

        }

        public CustomString(int length) : this("", length)
        {

        }

        public CustomString() : this("", 20)
        {

        }

        public CustomString(CustomString input)
        {
            this._str = input._str;
            this.Length = input.Length;
        }

        public CustomString(CustomString input, int length)
        {
            this._str = input._str;
            this.Length = length;
        }

        public char this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentException("Negative value of index");
                }
                if (index > _str.Length)
                {
                    throw new ArgumentException("Index out of range");
                }
                return this._str[index];
            }
            set
            {
                if (index < 0)
                {
                    throw new ArgumentException("Negative value of index");
                }
                if (index > _str.Length)
                {
                    throw new ArgumentException("Index out of range");
                }
                this._str[index] = value;
            }
        }

        public void AddSymbol(char symbol)
        {
            IncreaseCapacity(1);
            this[this.Length - 1] = symbol;
        }

        public void AddSymbol(int startIndex, char symbol)
        {
            if (IsIndexCorrect(startIndex)) { }
            IncreaseCapacity(1);
            for (int i = this.Length - 1; i > startIndex; i--)
            {
                this[i] = this[i - 1];
            }
            this[startIndex] = symbol;
        }

        public void AddSymbol(int startIndex, int count, char symbol)
        {
            if (IsIndexCorrect(startIndex)) { }
            IncreaseCapacity(count);
            for (int i = startIndex, j = 0; j < this.Length - count; i++, j++)
            {
                this[count + j] = this[i];
            }
            for (int i = startIndex, j = 0; j < count; i++, j++)
            {
                this[i] = symbol;
            }
        }

        public void RemoveSymbol(int startIndex)
        {
            char[] temp = new char[this.Length - 1];
            if (IsIndexCorrect(startIndex)) { }

            int i;
            for (i = 0; i < startIndex; i++)
            {
                temp[i] = this[i];
            }

            for (int j = startIndex + 1; j < this.Length; j++, i++)
            {
                temp[i] = this[j];
            }

            this._str = temp;
            this.DecreaseCapacity(1);
        }

        public void RemoveSymbol(int startIndex, int count)
        {
            char[] temp = new char[this.Length - count];
            if (IsIndexCorrect(startIndex, count)) { }

            int i;
            for (i = 0; i < startIndex; i++)
            {
                temp[i] = this[i];
            }

            for (int j = startIndex + count; j < this.Length; j++, i++)
            {
                temp[i] = this[j];
            }

            this._str = temp;
            this.DecreaseCapacity(count);
        }


        public override string ToString()
        {
            string outString = "";
            for (int i = 0; i < this.Length; i++)
            {
                outString += this[i];
            }

            return outString;
        }

        public CustomString Join(CustomString str)
        {
            CustomString newStr = new CustomString(this);
            newStr.IncreaseCapacity(str.Length);
            for (int i = this.Length, j = 0; i < newStr.Length; i++, j++)
            {
                newStr[i] = str[j];
            }

            return newStr;
        }

        public CustomString Join(CustomString str, int startIndex)
        {
            if (IsIndexCorrect(startIndex)) { }
            if (startIndex == this.Length)
            {
                return this.Join(str);
            }
            CustomString newStr = new CustomString(this);
            newStr.IncreaseCapacity(str.Length);
            for (int i = startIndex, j = 0; j < this.Length; i++, j++)
            {
                newStr[newStr.Length - j - 1] = newStr[newStr.Length - this.Length - j - 1];
            }
            for (int i = startIndex, j = 0; j < str.Length; i++, j++)
            {
                newStr[i] = str[j];
            }
            return newStr;
        }

        public int IndexOf(char ch)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] == ch)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Replace(int startaIndex, string str)
        {
            if (IsIndexCorrect(startaIndex, str.Length)) { }

            for (int i = startaIndex, j = 0; j < str.Length; i++, j++)
            {
                this[i] = str[j];
            }
        }

        public void Replace(int startaIndex, CustomString str)
        {
            if (IsIndexCorrect(startaIndex, str.Length)) { }

            for (int i = startaIndex, j = 0; j < str.Length; i++, j++)
            {
                this[i] = str[j];
            }
        }

        public CustomString Substring(int startIndex, int count)
        {
            if (IsIndexCorrect(startIndex,count)) { }
            string sub = "";
            for (int i = 0, j = startIndex; count != 0; i++, count--)
            {
                sub += this[j];
            }
            return new CustomString(sub);
        }

        //Из прошлого задания понял, что обычная строка
        //может менять регистры только всех символов,
        //поэтому решил добавить
        public void CharUpper()
        {
            for (int i = 0; i < this.Length; i++)
            {
                this[i] = Char.ToUpper(this[i]);
            }
        }

        public void CharUpper(int index)
        {
            if (IsIndexCorrect(index)) { }
            this[index] = Char.ToUpper(this[index]);
        }

        public void CharUpper(int startIndex, int count)
        {
            if (IsIndexCorrect(startIndex, count)) { }
            for (int i = startIndex, j = 0; j < count; i++, j++)
            {
                this[i] = Char.ToUpper(this[i]);
            }
        }

        public void CharLower()
        {
            for (int i = 0; i < this.Length; i++)
            {
                this[i] = Char.ToLower(this[i]);
            }
        }

        public void CharLower(int index)
        {
            if (IsIndexCorrect(index)) { }
            this[index] = Char.ToLower(this[index]);
        }

        public void CharLower(int startIndex, int count)
        {
            if (IsIndexCorrect(startIndex, count)) { }
            for (int i = startIndex, j = 0; j < count; i++, j++)
            {
                this[i] = Char.ToLower(this[i]);
            }
        }

        private void IncreaseCapacity(int size)
        {
            char[] temp = new char[this.Length + size];
            for (int i = 0; i < this.Length; i++)
            {
                temp[i] = this[i];
            }
            this._str = temp;
            this.Length += size;
        }

        private void DecreaseCapacity(int size)
        {
            this.Length -= size;
        }

        public void Clear()
        {
            this._str = new char[20];
            this.Length = 20;
        }

        public bool Equals(CustomString str)
        {
            if (this.Length != str.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < this.Length; i++)
                {
                    if (this[i] != str[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public bool IsIndexCorrect(int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("Negative value of index");
            }
            if (index > this.Length)
            {
                throw new ArgumentException("Index out of string length");
            }
            return true;
        }

        public bool IsIndexCorrect(int index, int count)
        {
            if (index < 0)
            {
                throw new ArgumentException("Negative value of index");
            }
            if (index > this.Length)
            {
                throw new ArgumentException("Index out of string length");
            }
            if (index + count > this.Length)
            {
                throw new ArgumentException("Length of the deleted characters is longer than the string");
            }
            if (count < 0)
            {
                throw new ArgumentException("Negative value of count");
            }
            return true;
        }

        public void Show()
        {
            foreach(var ch in this._str)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
}
}
