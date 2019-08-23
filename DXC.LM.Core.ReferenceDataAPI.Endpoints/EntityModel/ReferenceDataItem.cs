using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel
{
    /// <summary>
    /// </summary>
    public class ReferenceDataItem
    {
        /// <summary>
        /// </summary>
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
            
        /// <summary>
        /// </summary>
        [StringLength(80)]
        public string Path { get; set; }

        /// <summary>
        /// </summary>
        [Required, StringLength(80)]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [Required, StringLength(400)]
        public string Value { get; set; }
    }
}
