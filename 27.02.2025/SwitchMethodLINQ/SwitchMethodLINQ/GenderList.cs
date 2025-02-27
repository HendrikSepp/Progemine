using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchMethodLINQ
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>()
        {
        new Gender()
            {
                Id = Guid.Parse("e195e7fd-0e46-440c-b315-cfcd2047b712"),
                GenderName = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("685798c0-a1a0-4246-80e1-4f1fd7f79d54"),
                GenderName = "female"
            }
        };
    }
}
