using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    public class Class1
    {
        private static Random rand = new Random();

        public string GenerateStory(string keyword1, string keyword2, string keyword3)
        {
            string[] templates =
            {
                $"Ngày xửa ngày xưa, có một {keyword1} vô tình gặp {keyword2} trong một {keyword3}.",
                $"Trong thế giới {keyword3}, {keyword1} và {keyword2} đã trở thành đôi bạn thân bất ngờ.",
                $"{keyword1} đang thưởng thức {keyword2} thì cánh cửa {keyword3} mở ra, mang theo một cuộc phiêu lưu mới.",
                $"Không ai ngờ rằng {keyword1} cùng với {keyword2} lại chính là chìa khóa giải cứu {keyword3}.",
                $"Một ngày nọ, {keyword1} đi lạc vào {keyword3}, nơi {keyword2} đang chờ đợi."
            };

            int idx = rand.Next(templates.Length);
            return templates[idx];
        }
    }
}
