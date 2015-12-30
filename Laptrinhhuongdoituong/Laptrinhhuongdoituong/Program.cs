using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Laptrinhhuongdoituong
{
    class Program
    {
        static void Main(string[] args)
        {

            student[] sv = new student[100];
            for (int i = 0; i < 100; i++)
            {
                sv[i] = new student();
                sv[i].laygiatri(i + 400);
                sv[i].tinhtoan();
                for (int j = 0; j < 4; j++)
                    if (sv[i].Ketqua[j] > 0)
                    {
                        int k = j + 1;
                        string sql = @"drop table NVXT;
                                        create table NVXT (sbd varchar(9), nvso int, manv varchar(4), diemxt double precision);";
                        sql += "INSERT INTO NVXT VALUES('" + sv[i].SBd + "','" + k + "','" + sv[i].Nguyenvong[j, 0] + "','" + sv[i].Ketqua[j] + "')";

                        sv[i].Getdata(sql);

                    }

            }

            Console.WriteLine("ok");
                     
                Console.ReadKey();
            
        }
    }
}
