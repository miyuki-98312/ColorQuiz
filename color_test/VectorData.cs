using System.Numerics;

namespace color_test
{
    /// <summary>
    /// 各コンポーネントの位置情報を提供するクラス
    /// </summary>
    class VectorData
    {
        private Vector3[] positionVectorForRectangle = null;
        private Vector3 positionVectorForDescription;
        private Vector3 positionVectorForAnswerColorName;
        private Vector3 positionVectorForIsCorrected;
        private Vector3 positionVectorForAnswerStatus;

        public VectorData(int NUM_OPTIONS)
        {
            InitializeVectorForRectangle(NUM_OPTIONS);
            InitializeVectorForDescription();
            InitializeVectorForColorNameOfQuiz();
            InitializeVectorForIsCorrected();
            InitializepositionVectorForAnswerStatus();
        }
        /// <summary>
        /// 各長方形の位置を示したベクトルを初期化する
        /// </summary>
        private void InitializeVectorForRectangle(int NUM_OPTIONS)
        {
            positionVectorForRectangle = new Vector3[NUM_OPTIONS];
            positionVectorForRectangle[0] = new Vector3(50.0f, 330.0f, 0.0f);
            positionVectorForRectangle[1] = new Vector3(303.0f, 330.0f, 0.0f);
            positionVectorForRectangle[2] = new Vector3(556.0f, 330.0f, 0.0f);
            positionVectorForRectangle[3] = new Vector3(810.0f, 330.0f, 0.0f);
            positionVectorForRectangle[4] = new Vector3(50.0f, 530.0f, 0.0f);
            positionVectorForRectangle[5] = new Vector3(303.0f, 530.0f, 0.0f);
            positionVectorForRectangle[6] = new Vector3(556.0f, 530.0f, 0.0f);
            positionVectorForRectangle[7] = new Vector3(810.0f, 530.0f, 0.0f);
        }

        /// <summary>
        /// 問題文の位置ベクトルを初期化する
        /// </summary>
        private void InitializeVectorForDescription()
        {
            positionVectorForDescription = new Vector3(50.0f, 120.0f, 1.0f);
        }

        /// <summary>
        /// 問題の色名の位置ベクトルを初期化する
        /// </summary>
        private void InitializeVectorForColorNameOfQuiz()
        {
            positionVectorForAnswerColorName = new Vector3(50.0f, 180.0f, 1.0f);
        }

        /// <summary>
        /// 正解/不正解の位置ベクトルを初期化する
        /// </summary>
        private void InitializeVectorForIsCorrected()
        {
            positionVectorForIsCorrected = new Vector3(500.0f, 230.0f, 1.0f);
        }

        /// <summary>
        /// 正解状況の位置ベクトルを初期化する
        /// </summary>
        private void InitializepositionVectorForAnswerStatus()
        {
            positionVectorForAnswerStatus = new Vector3(50.0f, 40.0f, 1.0f);
        }

        /// <summary>
        /// 長方形の位置を取得する
        /// </summary>
        /// <param name="offset">位置を返す長方形の番号</param>
        /// <returns>長方形の位置ベクトル</returns>
        public Vector3 GetpositionVectorForRectangle(int offset)
        {
            return positionVectorForRectangle[offset];
        }

        /// <summary>
        /// 問題文の位置を取得する
        /// </summary>
        /// <returns>問題文の位置ベクトル</returns>
        public Vector3 GetpositionVectorForDescription()
        {
            return positionVectorForDescription;
        }

        /// <summary>
        /// 正解/不正解の位置ベクトルを取得する
        /// </summary>
        /// <returns>正解/不正解の位置ベクトル</returns>
        public Vector3 GetpositionVectorForIsCorrected()
        {
            return positionVectorForIsCorrected;
        }

        /// <summary>
        /// 問題の色名の位置を取得する
        /// </summary>
        /// <returns>問題の色名の位置ベクトル</returns>
        public Vector3 GetpositionVectorForAnswerColorName()
        {
            return positionVectorForAnswerColorName;
        }

        /// <summary>
        /// 回答状況の位置を取得する
        /// </summary>
        /// <returns>回答状況の位置ベクトル</returns>
        public Vector3 GetpositionVectorForAnswerStatus()
        {
            return positionVectorForAnswerStatus;
        }
    }
}
