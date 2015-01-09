using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.ModAPI.Ingame;
using Sandbox.Common.Components;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.Engine;
using Sandbox.Game;
using VRageMath;
using VRage;

namespace Test.Scripts
{
    class Tests
    {
        IMyGridTerminalSystem GridTerminalSystem;
        //http://steamcommunity.com/sharedfiles/filedetails/?id=360966557

        void Main()
        {
            int test = 1;

            switch (test)
            {
                case 1: test1(); break;
                case 2: test2(); break;
                case 3: test3(); break;
                default: test1(); break;
            }
        }

        void test1()
        {
            var items = new List<int>();
            items.Add(100);
            items.Add(25);
            items.Add(3);

            int sum = 0;
            for (int i = 0; i < items.Count; i++)
            {
                sum += items[i];
            }
        }

        void test2()
        {
            var items = new List<int>();
            items.Add(100);
            items.Add(25);
            items.Add(3);

            int sum = 0;
            foreach (int item in items)
            {
                sum += item;
            }
        }

        void test3()
        {
            var items = new List<int>();

            int sum = 0;
            while (sum <= 100)
            {
                sum += 10;
            }
        }

        void test4()
        {
            var items = new List<int>();
            items.Add(100);
            items.Add(25);
            items.Add(3);

            var q = from item in items
                    where item > 10
                    select item;

            q.Sum();
        }
    }
}
