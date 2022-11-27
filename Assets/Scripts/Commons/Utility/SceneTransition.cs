using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Commons
{
    public static class SceneTransition
    {
        public static async UniTask LoadScene(AssetReference scene)
        {
            await scene.LoadSceneAsync().Task;
        }
    }
}