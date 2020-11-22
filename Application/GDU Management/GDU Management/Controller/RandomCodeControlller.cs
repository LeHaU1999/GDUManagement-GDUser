using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDU_Management.Controller
{
    class RandomCodeControlller
    {


        //ramdom code xác thực
        public int RandomVerificationCode()
        {
            Random rd = new Random();
           int  randomCode = rd.Next(100, 999);
            return randomCode;
        } 

        //ma xac thuc
        public string VerificationCode()
        {
            string verificationCode;
            int code = RandomVerificationCode();
            if(code % 2 == 0)
            {
                verificationCode = "SSNI-" + code;
            }
            else
            {
                verificationCode = "SNIS-" + code;
            }
            return verificationCode;
        }

        //random id sinh vien
        public int RandomIdStudent()
        {
            Random rd = new Random();
            int randomIdStudent = rd.Next(0009, 9999);
            return randomIdStudent;
        }
    }
}
