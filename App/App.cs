using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Threading;
using static System.Console;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace App
{
    internal class App
    {
        static void Main(string[] args)
        {
            IWeapon iweapon = new IWeapon();
            iweapon.NewWeapon();
        }
    }
}