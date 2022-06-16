using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web410919946.Models.Partial
{
    [MetadataType(typeof(TableMetadata))]
    public partial class Table
    {
    }
    public class TableMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50)]

        public string Title { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public string Content { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        public System.DateTime PublishDate { get; set; }
    }
}