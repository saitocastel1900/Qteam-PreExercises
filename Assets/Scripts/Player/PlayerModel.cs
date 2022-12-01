using Commons.Enum;
using UniRx;
using UnityEngine;

namespace Player
{
    public class PlayerModel : MonoBehaviour
    {
        private BoolReactiveProperty _running;
        public IReadOnlyReactiveProperty<bool> Running => _running;
        
        //InGamePresenterで管理すべき
        private EnumReactiveProperty _state;
        public IReadOnlyReactiveProperty<InGameEnum.State> State=>_state;

        //PlayerのHPとして使う予定
        private IntReactiveProperty _hpProp;
        public IReactiveProperty<int> HpProp => _hpProp;

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialized()
        {
            _state = new EnumReactiveProperty(InGameEnum.State.Stop);
            _running = new BoolReactiveProperty(false);
        }

        /// <summary>
        /// Animatorのフラグを書き換え
        /// </summary>
        /// <param name="isRun"></param>
        public void UpdateBool(bool isRun)
        {
            _running.Value = isRun;
        }

        /// <summary>
        /// Enumを書き換える
        /// </summary>
        /// <param name="state"></param>
        public void UpdateState(InGameEnum.State state)
        {
            _state.Value = state;
        }

        public void UpdateHp(int hp)
        {
            _hpProp.Value = hp;
        }
    }
}