
using System;
using System.Collections.Generic;
using System.Linq;

using Autodesk.Max;

using BatchLabs.Max2016.Plugin.Actions;
using BatchLabs.Max2016.Plugin.Common;

using BatchLabs.Plugin.Common.Actions;

namespace BatchLabs.Max2016.Plugin
{
    public class MenuUtilities
    {
        private const string MainMenuName = "Azure Batch Rendering";

        /// <summary>
        /// This method setups all possible callbacks to handle menus add/remove in various user actions. For example, 
        /// if the user changes workspaces, the entire menu bar is updated, so this handles adding it in all workspaces as switched.
        /// The drawback is that 3ds Max calls some more than once, so you get some seemingly unnecessary add/remove. But it's safer 
        /// if you always want your menu present. Of course you could also call the add/remove in other conexts and callbacks 
        /// depending on the 3ds max state where you need your menu to display.
        /// 
        /// TODO: refactor this so i can have a single instance of this code in the BatchLabs.Plugin.Common project.
        /// Will need to have all the GlobalInterface methods interfaced.
        /// </summary>
        public static void SetupMenuHandlers()
        {
            var global = GlobalInterface.Instance;
            Log.Instance.Debug("setting up main menu handlers");

            // this only needs to be done once
            global.COREInterface.MenuManager.RegisterMenuBarContext(ActionStrings.MenuUniqueContextId, MainMenuName);
            
            // register menu change handler callbacks
            global.RegisterNotification(MenuPostLoadHandler, null, SystemNotificationCode.CuiMenusPostLoad);
            global.RegisterNotification(MenuPreSaveHandler, null, SystemNotificationCode.CuiMenusPreSave);
            global.RegisterNotification(MenuPostSaveHandler, null, SystemNotificationCode.CuiMenusPostSave);
            global.RegisterNotification(MenuSystemStartupHandler, null, SystemNotificationCode.SystemStartup);
        }

        private static void MenuPostLoadHandler(IntPtr objPtr, IntPtr infoPtr)
        {
            Log.Instance.Debug("*** MenuPostLoadHandler ***");
            InstallMenu(MainMenuName);
        }

        private static void MenuPostSaveHandler(IntPtr objPtr, IntPtr infoPtr)
        {
            Log.Instance.Debug("*** MenuPostSaveHandler ***");
            InstallMenu(MainMenuName);
        }

        private static void MenuSystemStartupHandler(IntPtr objPtr, IntPtr infoPtr)
        {
            Log.Instance.Debug("*** MenuSystemStartupHandler ***");
            InstallMenu(MainMenuName);
        }

        private static void MenuPreSaveHandler(IntPtr objPtr, IntPtr infoPtr)
        {
            Log.Instance.Debug("*** MenuPreSaveHandler ***");
            var menu = GlobalInterface.Instance.COREInterface13.MenuManager.FindMenu(MainMenuName);
            if (menu != null)
            {
                GlobalInterface.Instance.COREInterface13.MenuManager.UnRegisterMenu(menu);
                GlobalInterface.Instance.ReleaseIMenu(menu);
            }
        }

        /// <summary>
        /// Note, this method is iterating all action tbales and actions (for this example to also be able to find built-in actions).
        /// If you only need your own, you can use actionManager.FindTable(context);
        /// </summary>
        private static Dictionary<string, ActionWrapper> LookupActions()
        {
            Log.Instance.Debug("looking up actions");
            var actionItems = new Dictionary<string, ActionWrapper>();
            var actionManager = GlobalInterface.Instance.COREInterface.ActionManager;
            for (var actionTableIndex = 0; actionTableIndex < actionManager.NumActionTables; ++actionTableIndex)
            {
                var actionTable = actionManager.GetTable(actionTableIndex);
                if (actionTable.Name.Equals(Loader.ActionCategory, StringComparison.InvariantCultureIgnoreCase))
                {
                    Log.Instance.Debug($"found plugin action table :: {actionTable.Id_} - {actionTable.Name}");
                    for (var actionIndex = 0; actionIndex < actionTable.Count; ++actionIndex)
                    {
                        var action = actionTable[actionIndex];
                        if (action != null)
                        {
                            Log.Instance.Debug($"menu action :: {action.DescriptionText}");
                            actionItems[action.DescriptionText] = new ActionWrapper(action);
                        }
                    }
                }
            }

            return actionItems;
        }

        /// <summary>
        /// Installs the menu from scratch
        /// </summary>
        /// <returns>1 when successfully installed, or 0 in error state</returns>
        private static uint InstallMenu(string menuName)
        {
            Log.Instance.Debug("installing main menu");
            var menu = GlobalInterface.Instance.COREInterface13.MenuManager.FindMenu(menuName);
            if (menu != null)
            {
                Log.Instance.Debug("existing menu found, returning");
                return 0;
            }

            try
            {
                var global = GlobalInterface.Instance;
                var menuManager = global.COREInterface.MenuManager;

                // create a new menu item
                var maxPluginSubMenu = global.IMenu;
                maxPluginSubMenu.Title = menuName;
                menuManager.RegisterMenu(maxPluginSubMenu, 0);

                var actionItems = LookupActions().Values.OrderBy(item => item.Order);
                foreach (var actionWrapper in actionItems)
                {
                    Log.Instance.Debug($"adding '{actionWrapper.Action.DescriptionText}' to menu");
                    var menuItem1 = global.IMenuItem;
                    menuItem1.ActionItem = actionWrapper.Action;
                    maxPluginSubMenu.AddItem(menuItem1, -1);
                }

                // create the top level menu selector
                var maxPluginMenu = global.IMenuItem;
                maxPluginMenu.Title = menuName;
                maxPluginMenu.SubMenu = maxPluginSubMenu;
                menuManager.MainMenuBar.AddItem(maxPluginMenu, -1);
                global.COREInterface.MenuManager.UpdateMenuBar();
            }
            catch (Exception ex)
            {
                Log.Instance.Error($"{ex.Message}\n{ex}", "Failed to add menu items", true);
                return 0;
            }

            return 1;
        }
    }
}
