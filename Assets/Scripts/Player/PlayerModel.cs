using UniRx;
using UnityEngine;

namespace Player
{
    public class PlayerModel
    {
        private BoolReactiveProperty _running;
        public IReadOnlyReactiveProperty<bool> Running => _running;

        private IntReactiveProperty _hpProp;
        public IReactiveProperty<int> HpProp => _hpProp;
        private int HP => _hpProp.Value;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PlayerModel()
        {
            _running = new BoolReactiveProperty(false);
            _hpProp = new IntReactiveProperty(0);
        }

        /// <summary>
        /// Animatorのフラグを書き換え
        /// </summary>
        /// <param name="isRun"></param>
        public void UpdateBool(bool isRun)
        {
            _running.Value = isRun;
        }

        public void UpdateHp()
        {
            var value = HP + 1;
            Debug.Log("Modelの値"+value);
            _hpProp.Value =Mathf.Clamp(value, 0, 10);
        }
    }
}