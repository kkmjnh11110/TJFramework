﻿using UnityEngine;
using UnityEngine.SceneManagement;

namespace TJ
{
    //由于启动场景必然在包里而无法热更新. 所以基于热更新的程序必须从一个专门的启动场景开始
    public class LaunchScene : MonoBehaviour
    {
        public string sceneName;

        void Awake()
        {
            LuaManager.InitSearchPaths = new string[] { "Assets/TJFramework/Test/Lua" };

            var bundlename = BundleManager.Instance.AssetBundleName(sceneName);
            BundleManager.Instance.LoadBundle(bundlename);
            SceneManager.LoadScene(sceneName);
        }
    }



}
