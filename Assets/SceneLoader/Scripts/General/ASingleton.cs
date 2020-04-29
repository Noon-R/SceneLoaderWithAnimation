using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Noon.General {

    /// <summary>
    /// GameObjectである必要がないことも十分にあろうから、ただのsingleton
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public abstract class ASingleton<T> {

        private T m_instance;

        /// <summary>
        /// Singletone<T> のインスタンス
        /// m_instance == null であれば、インスタンスを自動生成
        /// </summary>
        public T Instance {
            get {

                if (!ExistInstance()) {

                    m_instance = CreateInstance();

                }

                return m_instance;
            }
        }

        private bool ExistInstance() {

            return m_instance != null;
        }

        /// <summary>
        /// クラスによってコンストラクタが変わるだろうから、インスタンス生成は各クラスに委任
        /// </summary>
        /// <returns></returns>
        protected abstract T CreateInstance();

    }
}