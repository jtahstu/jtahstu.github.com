using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hdu题解自动添加 {
    class Program {
        static void Main(string[] args) {
            for (int i = 4365; i>=1000; i--) {
                var utf8WithBom = new System.Text.UTF8Encoding(true);
                string index = @"D:\Github\jtahstu.github.com\OJ\index.html";
                StreamReader cin = new StreamReader(index, utf8WithBom);
                string s = cin.ReadToEnd();
                cin.Close();
                string file = "P" + i.ToString();
                string str = "<a href=\"code\\hdu\\" + file + ".html\"" + " target=\"_blank\">" + file + "&nbsp;&nbsp;</a>";
                if (i % 14 == 0) str = str + "<br />";
                int start = s.IndexOf("<p id=\"insert\">") + 15;
                s = s.Insert(start, str);//插入链接

                StreamWriter readTxt = new StreamWriter(index, false, utf8WithBom);
                readTxt.Write(s);
                readTxt.Close();
            }
        }
    }
}
