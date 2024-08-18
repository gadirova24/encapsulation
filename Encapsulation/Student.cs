using System;
namespace Encapsulation
{
    public class Student
    {
        public int No { get; set; }
        public string Fullname { get; set; }
        private string _groupName;

        public string GroupName
        {
            get
            {

                return Char.ToUpper(_groupName[0]) + "-" + _groupName.Substring(1);
            }
            set
            {
                //if (value.Length == 4 && Char.IsLetter(value[0]) && Char.IsDigit(value[1]) && Char.IsDigit(value[2]) && Char.IsDigit(value[3]))
                if (value.Length == 4 && Char.IsLetter(value[0]))
                {
                    for (int i = 1; i < value.Length; i++)
                    {
                        if (!Char.IsDigit(value[i]))
                        {
                            return;
                        }
                    }
                    _groupName = value;
                }
            }
        }
    }
}
  

