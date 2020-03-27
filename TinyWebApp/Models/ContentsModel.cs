using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TinyWebApp.Models
{
    public class ContentsModel
    {
        public string Title { get; set; }
        public DateTime PostedOn { get; set; }
        public string Tags { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}
