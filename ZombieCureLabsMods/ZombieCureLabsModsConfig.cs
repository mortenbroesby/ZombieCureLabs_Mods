using System;
using UModFramework.API;

namespace ZombieCureLabsMods
{
    public class ZombieCureLabsModsConfig
    {
        private static readonly string configVersion = "0.2";

        internal static void Load()
        {
            ZombieCureLabsMods.Log("Loading settings.");

            try
            {
                using (UMFConfig config = new UMFConfig())
                {
                    string configVersion = config.Read("ConfigVersion", new UMFConfigString());
                    if (configVersion != string.Empty && configVersion != ZombieCureLabsModsConfig.configVersion)
                    {
                        config.DeleteConfig(false);
                        ZombieCureLabsMods.Log("The config file was outdated and has been deleted. A new config will be generated.");
                    }

                    //cfg.Write("SupportsHotLoading", new UMFConfigBool(false)); //Uncomment if your mod can't be loaded once the game has started.
                    config.Write("ModDependencies", new UMFConfigStringArray(new string[] { "" })); //A comma separated list of mod/library names that this mod requires to function. Format: SomeMod:1.50,SomeLibrary:0.60
                    config.Read("LoadPriority", new UMFConfigString("Normal"));
                    config.Write("MinVersion", new UMFConfigString("0.53.6"));
                    config.Write("MaxVersion", new UMFConfigString("0.54.99999.99999")); //This will prevent the mod from being loaded after the next major UMF release
                    config.Write("UpdateURL", new UMFConfigString(""));
                    config.Write("ConfigVersion", new UMFConfigString(ZombieCureLabsModsConfig.configVersion));

                    ZombieCureLabsMods.Log("Finished loading settings.");
                }
            }
            catch (Exception e)
            {
                ZombieCureLabsMods.Log("Error loading mod settings: " + e.Message + "(" + e.InnerException?.Message + ")");
            }
        }
    }
}