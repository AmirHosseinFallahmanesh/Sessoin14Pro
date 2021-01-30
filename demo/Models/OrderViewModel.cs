using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public OrderState State { get; set; }
    }

    public enum OrderState
    {
        [Display(Name ="در حال انجام")]
        inProcess,
        [Display(Name = "ارسال شده")]
        Shipped,
        [Display(Name = "ناموفق")]
        Failed,
        [Display(Name = "کنسل شده")]
        Ignore
    }
}

