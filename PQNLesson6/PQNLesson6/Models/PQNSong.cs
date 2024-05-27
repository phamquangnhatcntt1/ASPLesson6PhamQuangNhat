using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PQNLesson6.Models
{
    public class PQNSong
    {
        public int ID { get; set; }
        [DisplayName("Tiêu Đề")]
        [Required(ErrorMessage ="PQN: Hãy Nhập Tiêu Đề")]
        public string PQNTitle { get; set; }
        [DisplayName("Tác Giả")]
        [Required(ErrorMessage = "PQN: Hãy Nhập Tác Giả")]
        public string PQNAuthor { get; set; }
        [DisplayName("Nghệ Sĩ")]
        [Required(ErrorMessage = "PQN: Hãy Nhập Nghệ sĩ")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "PQN: độ dài trong khoảng từ [2-50]")]
        public string PQNArtist { get; set; }

        [DisplayName("Năm xuất bản")]
        [Required(ErrorMessage = "PQN: Hãy Nhập Ngày xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="PQN= Năm xuất bản phải là số có 4 kí tự số")]
        [Range(1900,2020,ErrorMessage ="PQN: Năm xuất bản trong khoảng 1900 - 2020")]
        public string PQNYearRealese { get; set; }


    }
}