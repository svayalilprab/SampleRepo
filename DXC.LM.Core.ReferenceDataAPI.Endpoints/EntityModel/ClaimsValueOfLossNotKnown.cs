using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel
{
    /// <summary>
    /// </summary>
    public class ClaimsValueOfLossNotKnown
    {
        /// <summary>
        /// </summary>
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
            
        /// <summary>
        /// </summary>
        [Required, StringLength(1)]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [Required, StringLength(50)]
        public string Value { get; set; }
    }
}
