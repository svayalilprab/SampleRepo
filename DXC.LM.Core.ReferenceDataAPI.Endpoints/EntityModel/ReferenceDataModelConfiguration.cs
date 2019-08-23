using System;
using System.Collections.Generic;
using System.Text;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel
{
    using Microsoft.AspNet.OData.Builder;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// </summary>
    public class ReferenceDataModelConfiguration : IModelConfiguration
    {
        /// <summary>
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="apiVersion"></param>
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion)
        {
            var item = builder.EntitySet<ReferenceDataItem>("items").EntityType;
            item.HasKey(e => e.ID);

            var claimCurrency = builder.EntitySet<ClaimsCurrency>("claimscurrency").EntityType;
            claimCurrency.HasKey(e => e.ID);

            // Note: The EntitySet name parameter must match your controller name or ODataRoutePrefix attribute on the controller
            var claimsValueOfLossNotKnown = builder.EntitySet<ClaimsValueOfLossNotKnown>("claimsValueOfLossNK").EntityType;
            claimsValueOfLossNotKnown.HasKey(e => e.ID);

        }
    }
}
