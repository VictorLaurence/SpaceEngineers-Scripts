//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Sandbox.Common;
//using Sandbox.Common.Components;
//using Sandbox.Common.ObjectBuilders;
//using Sandbox.Definitions;
//using Sandbox.Engine;
//using Sandbox.ModAPI.Ingame;
//using Sandbox.Game;
//using VRageMath;
//using VRage;

//namespace Test.Scripts
//{
//    static class MyExtensions
//    {
//        public static bool Action(this IMyTerminalBlock block, string action)
//        {
//            var foundAction = block.GetActionWithName(action);
//            if (foundAction != null)
//            {
//                foundAction.Apply(block);
//                return true;
//            }
//            else return false;
//        }
//        public static void Toggle(this IMyFunctionalBlock block)
//        {
//            block.Action("OnOff");
//        }
//        public static void Enable(this IMyFunctionalBlock block)
//        {
//            block.Action("OnOff_On");
//        }
//        public static void Disable(this IMyFunctionalBlock block)
//        {
//            block.Action("OnOff_Off");
//        }
//        public static bool Action(this IMyFunctionalBlock block, string action)
//        {
//            var foundAction = block.GetActionWithName(action);
//            if (foundAction != null)
//            {
//                foundAction.Apply(block);
//                return true;
//            }
//            else return false;
//        }
//    }

//    class EnableStuff
//    {
//        IMyGridTerminalSystem GridTerminalSystem;
//        //http://steamcommunity.com/sharedfiles/filedetails/?id=360966557

//        void Main()
//        {
//            var blocks = new List<IMyTerminalBlock>();
//            GridTerminalSystem.GetBlocksOfType<IMyLightingBlock>(blocks);

//            for (int i = 0; i < blocks.Count; i++)
//            {
//                ((IMyFunctionalBlock)blocks[i]).Enable();
//            }
//        }
//    }
//}
