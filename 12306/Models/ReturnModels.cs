using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturnModels
{
    public class Register
    {
        private int isVaild;

        public int IsVaild { get => isVaild; set => isVaild = value; }
    }

    public class Login
    {
        private int isVaild;

        public int IsVaild { get => isVaild; set => isVaild = value; }
    }

}
