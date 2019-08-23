using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DXC.LM.SDK.SharedErrorHandling.Interfaces;
using DXC.LM.SDK.SharedLogging.Interfaces;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Controllers
{
    using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel;


    using Microsoft.AspNet.OData;
    using Microsoft.AspNet.OData.Query;
    using Microsoft.AspNet.OData.Results;
    using Microsoft.AspNet.OData.Routing;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    using Microsoft.EntityFrameworkCore;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using Microsoft.OData;

    [Authorize]
    [ApiVersion("1.0")]
    [ODataRoutePrefix("claimsvalueoflossnk")]
    public class ClaimsValueOfLossNKController : ODataController
    {
        private readonly IUnitOfWork<ReferenceDataDbContext> _unitOfWork;
        private readonly IHostingEnvironment _environment;
        private readonly IConfiguration _configuration;

        private readonly ILoggerWrapper<ClaimsValueOfLossNKController> _logging;
        private readonly IErrorHandler<ClaimsValueOfLossNKController> _errorHandler;

        /// <summary>
        /// </summary>
        private readonly ODataValidationSettings _validQueryOptions =
            new ODataValidationSettings()
            {
                //AllowedOrderByProperties = { "key", "value" },
                AllowedQueryOptions = AllowedQueryOptions.All,
                AllowedArithmeticOperators =
                    AllowedArithmeticOperators.None,
                AllowedFunctions =
                    AllowedFunctions.None,
                AllowedLogicalOperators =
                    AllowedLogicalOperators.All,
                MaxTop = 100,
                MaxNodeCount = 20,
                MaxExpansionDepth = 2,
                MaxOrderByNodeCount = 2,
            };


        /// <summary>
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="logging"></param>
        /// <param name="errorHandler"></param>
        /// <param name="unitOfWork"></param>
        public ClaimsValueOfLossNKController(
                IHostingEnvironment environment,
                IServiceCollection services,
                IConfiguration configuration,
                ILoggerWrapper<ClaimsValueOfLossNKController> logging,
                IErrorHandler<ClaimsValueOfLossNKController> errorHandler,
                IUnitOfWork<ReferenceDataDbContext> unitOfWork = null)
            : base()
        {
            _environment = environment;
            _configuration = configuration;
            _logging = logging;
            _errorHandler = errorHandler;

            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        [ODataRoute()]
        [AllowAnonymous]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Forbidden)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NotImplemented)]
        [ProducesResponseType((int)HttpStatusCode.PaymentRequired)]
        [ProducesResponseType((int)HttpStatusCode.ServiceUnavailable)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType((int)HttpStatusCode.UnsupportedMediaType)]
        [ProducesResponseType(typeof(EntityModel.ClaimsValueOfLossNotKnown), (int)HttpStatusCode.OK)]
        public IActionResult Get(ODataQueryOptions<EntityModel.ClaimsValueOfLossNotKnown> options)
        {
            try
            {
                options.Validate(_validQueryOptions);
                using (var _repository = _unitOfWork.GetRepository<EntityModel.ClaimsValueOfLossNotKnown>())
                {
                    var queryResults = options.ApplyTo(
                        _repository.GetAll());

                    if (queryResults != null)
                        return Ok(queryResults);
                    return NotFound();
                }
            }
            catch (ODataException oex)
            {
                return BadRequest(oex.Message);
            }
            catch (Exception ex)
            {
                // (GG) When the error handling middleware is registered, it basically does this for all unhandled exceptions.
                // Perhaps similar functionality could be implemented for odata exceptions which would keep all of this try/catch out of the controllers.
                var handleErrorResponse = _errorHandler.HandleError("Something went wrong", new EventId(999999), ex);

                var errorMessage = $"Error Ref: {handleErrorResponse.ErrorRef}, {ex.Message}";

                return StatusCode((int)HttpStatusCode.InternalServerError, errorMessage);
            }
        }

    }
}
