using NetAutoGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA
{
    public static class wechat
    {
        public static void dog()
        {
            Console.WriteLine("请输入发送人");
            string Name = Console.ReadLine();
            if (Name == null)
            {
                Console.WriteLine("请输入发送人");
                return;
            }

            Console.WriteLine("请输入发送次数");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count == null)
            {
                Console.WriteLine("请输入发送次数");
                return;
            }

            Console.WriteLine("请输入发送内容");
            string path = Console.ReadLine();
            if (path == null)
            {
                Console.WriteLine("请输入发送内容");
                return;
            }

            Window? win = GUI.Application.FindWindowByTitle("微信");

            if (win == null)
            {
                Console.WriteLine("请打开并登录微信");
                return;
            }
            else
            {
                win.Activate();
            }

            Thread.Sleep(200);
            GUI.Keyboard.HotKey(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_F);
            GUI.Keyboard.Write(Name);
            Thread.Sleep(800);
            GUI.Keyboard.Press(VirtualKeyCode.RETURN);
            Thread.Sleep(100);
            for (int i = 0; i < count; i++)
            {
                GUI.Keyboard.Write(path);
                GUI.Keyboard.Press(VirtualKeyCode.RETURN);
            }
        }
    }
}