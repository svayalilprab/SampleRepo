using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;


namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Controllers
{
    using Microsoft.AspNet.OData;
    using Microsoft.AspNet.OData.Routing;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;

    using Microsoft.EntityFrameworkCore;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    using DXC.LM.SDK.SharedErrorHandling.Interfaces;
    using DXC.LM.SDK.SharedLogging.Interfaces;

    using Microsoft.AspNet.OData.Results;

    /// <summary>
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class ODataController<TDbContext,TEntity> : ODataController
        where TDbContext : DbContext
        where TEntity : class 
    {
        private readonly IUnitOfWork<TDbContext> _unitOfWork;
        private readonly IHostingEnvironment _environment;
        private readonly IConfiguration _configuration;
        private readonly ILoggerWrapper _logging;

        /// <summary>
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <param name="logging"></param>
        /// <param name="errorHandler"></param>
        /// <param name="unitOfWork"></param>
        public ODataController(
                IHostingEnvironment environment,
                IServiceCollection services,
                IConfiguration configuration,
                ILoggerWrapper logging,
                IUnitOfWork<TDbContext> unitOfWork = null)
            : base()
        {
            _environment = environment;
            _configuration = configuration;
            _logging = logging;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.Conflict)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        [ProducesResponseType(typeof(SingleResult<EntityModel.ReferenceDataItem>), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody]TEntity entity)
        { return Ok();  }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="delta"></param>
        /// <returns></returns>
        [HttpPatch][HttpPut]
        [ODataRoute("({id})")]
        [Produces("application/json")]
        public IActionResult PutOrPatch([FromRoute]int id, Delta<ViewModel.ReferenceDataItem> delta)
        { return Ok(); }

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="suspendOnly"></param>
        /// <returns></returns>
        [ODataRoute("({id})")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public IActionResult Delete([FromRoute]int id, bool suspendOnly)
        {
            return Ok( );
        }
    }
}
