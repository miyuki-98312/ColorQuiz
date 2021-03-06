using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace color_test
{
    class ScoreData
    {
        ApplicationDataContainer localSettings;
        ApplicationDataContainer container;
        private const int LENGTH_OF_STORAGE = 20;

        public ScoreData()
        {
            localSettings = ApplicationData.Current.LocalSettings;
            bool hasContainer = CheckContainerExsists();
            if (!hasContainer)
            {
                CreateContainer();
            }
        }

        /// <summary>
        /// コンテナを作成する
        /// </summary>
        private void CreateContainer()
        {
            container = localSettings.CreateContainer("scoreContainer", ApplicationDataCreateDisposition.Always);
        }

        /// <summary>
        /// スコアを格納するコンテナが存在するかチェックする
        /// </summary>
        /// <returns>コンテナが存在するか</returns>
        private bool CheckContainerExsists()
        {
            bool hasContainer = localSettings.Containers.ContainsKey("scoreContainer");
            return hasContainer;
        }

        /// <summary>
        /// スコアを保存する
        /// </summary>
        /// <param name="score">点数</param>
        public void SetScore(int score)
        {
            bool hasContainer = CheckContainerExsists();
            if (!hasContainer)
            {
                CreateContainer();
            }

            // 空いている最小のインデックスでスコアを格納する
            for (int i=0; true; i++)
            {
                if(localSettings.Containers["scoreContainer"].Values[i.ToString()] == null)
                {
                    localSettings.Containers["scoreContainer"].Values[i.ToString()] = score;
                    break;
                }
            }
        }

        /// <summary>
        /// スコアを格納した配列を取得する
        /// </summary>
        /// <returns>スコアを格納した配列。nullあり。</returns>
        public string[] GetScore()
        {
            string[] scores = new string[LENGTH_OF_STORAGE];
            bool hasContainer = CheckContainerExsists();
            if (!hasContainer)
            {
                CreateContainer();
                for(int i=0; i<LENGTH_OF_STORAGE; i++)
                {
                    scores[i] = 0.ToString();
                }
            }
            else
            { // スコアのデータ数が20コ以下の場合
                bool isUnder20 = localSettings.Containers["scoreContainer"].Values["20"] == null;
                var tmp = localSettings.Containers["scoreContainer"];
                if (isUnder20)
                {
                    for (int i = 0; i < LENGTH_OF_STORAGE; i++)
                    {
                        if (localSettings.Containers["scoreContainer"].Values[i.ToString()] != null)
                        {
                            scores[i] = localSettings.Containers["scoreContainer"].Values[i.ToString()].ToString();
                        }
                        else
                        {
                            scores[i] = null;
                        }
                    }
                }
                else
                { // スコアのデータが21以上の場合、末尾から20コのデータを格納する
                    int counter = 20;
                    while (true)
                    {
                        if (localSettings.Containers["scoreContainer"].Values[counter.ToString()] == null)
                        {
                            break;
                        }
                        counter++;
                    }
                    for (int i = 0; i < LENGTH_OF_STORAGE; i++)
                    {
                        int offset = counter - LENGTH_OF_STORAGE;
                        scores[i] = localSettings.Containers["scoreContainer"].Values[(i+offset).ToString()].ToString();
                    }
                }
            }
            return scores;
        }

        /// <summary>
        /// スコアの長さの最大値を取得する
        /// </summary>
        /// <returns>スコアの長さの最大値</returns>
        public int GetLengthOfStorage()
        {
            return LENGTH_OF_STORAGE;
        }

        /// <summary>
        /// スコアの長さを取得する
        /// </summary>
        /// <returns>スコアの長さ</returns>
        public int GetLengthOfScore()
        {
            int lengthOfScore = 0;
            bool hasContainer = CheckContainerExsists();
            if (!hasContainer)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < LENGTH_OF_STORAGE; i++)
                {
                    if (localSettings.Containers["scoreContainer"].Values[i.ToString()] != null)
                    {
                        lengthOfScore++;
                    }
                    else
                    {
                        break;
                    }
                }
                return lengthOfScore;
            }
        }

        /// <summary>
        /// スコアを全て削除する
        /// </summary>
        public void DeleteScores()
        {
            bool hasContainer = CheckContainerExsists();
            if (hasContainer)
            {
                localSettings.DeleteContainer("scoreContainer");
            }
        }
    }
}
