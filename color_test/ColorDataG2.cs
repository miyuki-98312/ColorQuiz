﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace color_test
{
    /// <summary>
    /// 色彩検定二級の色のデータを提供するクラス
    /// </summary>
    class ColorDataG2
    {
        Dictionary<int, string> nameMap = new Dictionary<int, string>();
        Dictionary<int, byte[]> rgbMap = new Dictionary<int, byte[]>();
         public ColorDataG2(int NUM_OPTIONS)
        {
            InitializeNameMap();
            InitializergbMap();
        }

        /// <summary>
        /// 連番と色名の辞書を初期化する
        /// </summary>
        private void InitializeNameMap()
        {
            /*  ここからが出題範囲1つめ  */
            nameMap.Add(0, "鴇色(ときいろ)\n(明るい紫みの赤)");
            nameMap.Add(1, "オールドローズ\n(やわらかい赤)");
            nameMap.Add(2, "韓紅色(からくれない)\n(あざやかな赤)");
            nameMap.Add(3, "ポピーレッド\n(あざやかな赤)");
            nameMap.Add(4, "テラコッタ\n(くすんだ黄みの赤)");
            nameMap.Add(5, "蘇芳(すおう)\n(くすんだ赤)");
            nameMap.Add(6, "鳶色(とびいろ)\n(暗い黄みの赤)");
            nameMap.Add(7, "弁柄色(べんがらいろ)\n(暗い黄みの赤)");
            nameMap.Add(8, "海老茶(えびちゃ)\n(暗い黄みの赤)");
            nameMap.Add(9, "マルーン\n(暗い赤)");
            nameMap.Add(10, "チャイニーズレッド\n(あざやかな黄赤)");
            nameMap.Add(11, "黄丹(おうに)\n(つよい黄赤)");
            nameMap.Add(12, "ローシェンナ\n(つよい黄赤)");
            nameMap.Add(13, "桧皮色(ひわだいろ)\n(暗い灰みの黄赤)");
            nameMap.Add(14, "バーントシェンナ\n(くすんだ黄赤)");
            nameMap.Add(15, "タン\n(くすんだ黄赤)");
            nameMap.Add(16, "代赭(たいしゃ)\n(くすんだ黄赤)");
            nameMap.Add(17, "柑子色(こうじいろ)\n(明るい黄赤)");
            /*  ここからが出題範囲2つめ  */
            nameMap.Add(18, "琥珀色(こはくいろ)\n(くすんだ赤みの黄)");
            nameMap.Add(19, "バーントアンバー\n(ごく暗い赤みの黄)");
            nameMap.Add(20, "ローアンバー\n(暗い黄)");
            nameMap.Add(21, "アンバー(くすんだ赤みの黄)");
            nameMap.Add(22, "朽葉色(くちばいろ)\n(灰みの赤みを帯びた黄)");
            nameMap.Add(23, "鬱金色(うこんいろ)\n(つよい黄)");
            nameMap.Add(24, "ゴールデンイエロー\n(つよい赤みの黄)");
            nameMap.Add(25, "ネープルスイエロー\n(つよい黄)");
            nameMap.Add(26, "ジョンブリアン\n(あざやかな黄)");
            nameMap.Add(27, "刈安色(かりやすいろ)\n(うすい緑みの黄)");
            nameMap.Add(28, "エクルベージュ\n(うすい赤みの黄)");
            nameMap.Add(29, "海松色(みるいろ)\n(暗い灰みの黄緑)");
            nameMap.Add(30, "シャルトルーズグリーン\n(明るい黄緑)");
            nameMap.Add(31, "鶸色(ひわいろ)\n(つよい黄緑)");
            nameMap.Add(32, "黄蘗色(きはだいろ)\n(あかるい黄緑)");
            nameMap.Add(33, "グラスグリーン\n(くすんだ黄緑)");
            nameMap.Add(34, "リーフグリーン\n(つよい黄緑)");
            /*  ここからが出題範囲3つめ  */
        }

        /// <summary>
        /// 連番と色のRGBの辞書を初期化する
        /// </summary>
        private void InitializergbMap()
        {
            /*  ここからが出題範囲1つめ  */
            rgbMap.Add(0, new byte[] { 244, 179, 194 }); // 鴇色
            rgbMap.Add(1, new byte[] { 226, 147, 153 }); // オールドローズ
            rgbMap.Add(2, new byte[] { 233, 84, 100 }); // 韓紅色
            rgbMap.Add(3, new byte[] { 234, 85, 80 }); // ポピーレッド
            rgbMap.Add(4, new byte[] { 189, 104, 86 }); // テラコッタ
            rgbMap.Add(5, new byte[] { 158, 61, 63 }); // 蘇芳
            rgbMap.Add(6, new byte[] { 149, 72, 63 }); // 鳶色
            rgbMap.Add(7, new byte[] { 143, 46, 20 }); // 弁柄色
            rgbMap.Add(8, new byte[] { 119, 60, 48 }); // 海老茶
            rgbMap.Add(9, new byte[] { 106, 25, 23 }); // マルーン
            rgbMap.Add(10, new byte[] { 237, 109, 70 }); // チャイニーズレッド
            rgbMap.Add(11, new byte[] { 238, 121, 72 }); // 黄丹
            rgbMap.Add(12, new byte[] { 225, 123, 52 }); // ローシェンナ
            rgbMap.Add(13, new byte[] { 150, 80, 54 }); // 桧皮色
            rgbMap.Add(14, new byte[] { 187, 85, 53 }); // バーントシェンナ
            rgbMap.Add(15, new byte[] { 191, 120, 62 }); // タン
            rgbMap.Add(16, new byte[] { 187, 85, 32 }); // 代赭
            rgbMap.Add(17, new byte[] { 246, 173, 73 }); // 柑子色
            /*  ここからが出題範囲2つめ  */
            rgbMap.Add(18, new byte[] { 191, 120, 58 }); // 琥珀色
            rgbMap.Add(19, new byte[] { 111, 84, 54 }); // バーントアンバー
            rgbMap.Add(20, new byte[] { 134, 102, 41 }); // ローアンバー
            rgbMap.Add(21, new byte[] { 194, 137, 75 }); // アンバー
            rgbMap.Add(22, new byte[] { 145, 115, 71 }); // 朽葉色
            rgbMap.Add(23, new byte[] { 250, 191, 20 }); // 鬱金色
            rgbMap.Add(24, new byte[] { 246, 174, 84 }); // ゴールデンイエロー
            rgbMap.Add(25, new byte[] { 253, 211, 92 }); // ネープルスイエロー
            rgbMap.Add(26, new byte[] { 255, 220, 0 }); // ジョンブリアン
            rgbMap.Add(27, new byte[] { 245, 229, 107 }); // 刈安色
            rgbMap.Add(28, new byte[] { 246, 229, 204 }); // エクルベージュ
            rgbMap.Add(29, new byte[] { 114, 109, 64 }); // 海松色
            rgbMap.Add(30, new byte[] { 217, 227, 103 }); // シャルトルーズグリーン
            rgbMap.Add(31, new byte[] { 215, 207, 58 }); // 鶸色
            rgbMap.Add(32, new byte[] { 254, 242, 99 }); // 黄蘗色
            rgbMap.Add(33, new byte[] { 123, 141, 66 }); // グラスグリーン
            rgbMap.Add(34, new byte[] { 159, 194, 77 }); // リーフグリーン
            /*  ここからが出題範囲3つめ  */
        }

        /// <summary>
        /// 問題の番号を受け取って、出題範囲の始まりを返す
        /// </summary>
        /// <param name="quizCounter">問題の番号</param>
        /// <returns>出題範囲の始まり</returns>
        public int GetCurrentStartOfColors(int quizCounter)
        {
            int startNum;
            if(quizCounter <= 17)
            {
                startNum = 0;
            }
            else
            {
                startNum = 18;
            }
            return startNum;
        }

        /// <summary>
        /// 問題の番号を受け取って、出題範囲の終わりを返す
        /// </summary>
        /// <param name="quizCounter">問題の番号</param>
        /// <returns>出題範囲の終わり</returns>
        public int GetCurrentEndOfColors(int quizCounter)
        {
            int endNum;
            if(quizCounter <= 17)
            {
                endNum = 17;
            }else
            {
                endNum = 34;
            }
            return endNum;
        }

        /// <summary>
        /// nameMapで指定した値を取得する
        /// </summary>
        /// <param name="key">値を指定するためのキー</param>
        /// <returns>nameMapの値</returns>
        public string GetnameMapValue(int key)
        {
            return nameMap[key];
        }

        /// <summary>
        /// nameMapの長さを取得する
        /// </summary>
        /// <returns>nameMapの長さ</returns>
        public int GetnameMapLength()
        {
            return nameMap.Count();
        }

        /// <summary>
        /// rgbMapで指定した値を取得する
        /// </summary>
        /// <param name="key"></param>
        /// <returns>rgbMapの値</returns>
        public byte[] GetrgbMapValue(int key)
        {
            return rgbMap[key];
        }
    }
}
