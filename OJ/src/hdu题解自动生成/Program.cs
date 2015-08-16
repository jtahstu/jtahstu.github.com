using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hdu题解自动生成 {
    class Program {
        static void Main(string[] args) {
            for (int i = 4599; i <= 5299; i++) {
                try {
                    string path = @"G:\ACM\OJ\code\hduoj_accept\hduoj_" + i.ToString() + ".cpp";
                    StreamReader sr = new StreamReader(path);
                    string s_path = sr.ReadToEnd();
                    sr.Close();
                    string te_path = @"D:\Github\jtahstu.github.com\OJ\code\hdu\Te.html";
                    StreamReader sr2 = new StreamReader(te_path);
                    string s_te = sr2.ReadToEnd();
                    sr2.Close();
                    s_te = s_te.Replace("$code$", s_path);
                    s_te = s_te.Replace("$time$", DateTime.Now.ToString());
                    s_te = s_te.Replace("$title$", "HDUOJ_P" + i.ToString());
                    string code_path = @"D:\Github\jtahstu.github.com\OJ\code\hdu\P" + i.ToString() + ".html";
                    StreamWriter readTxt = new StreamWriter(code_path, false);
                    readTxt.Write(s_te);
                    readTxt.Close();
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }
    }
}
