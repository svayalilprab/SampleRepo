using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace App.Metrics.Health
{
    //using StackExchange.Redis;

    //public static class RedisHealthCheckBuilderExtensions
    //{

    //    public static IHealthBuilder AddRedisQuiteTimeCheck(
    //            this IHealthCheckBuilder healthCheckBuilder,
    //            string name,
    //            Func<IConnectionMultiplexer> newConnection,
    //            TimeSpan timeout,
    //            HealthCheck.QuiteTime quiteTime,
    //            bool degradedOnError = false)
    //    {
    //        EnsureValidTimeout(timeout);
    //        healthCheckBuilder.AddQuiteTimeCheck(
    //            name,
    //            cancellationToken => ExecuteRedisCheckAsync(name, newConnection, timeout, degradedOnError, cancellationToken),
    //            quiteTime);
    //        return healthCheckBuilder.Builder;
    //    }

    //    public static IHealthBuilder AddRedisCheck(
    //        this IHealthCheckBuilder healthCheckBuilder,
    //        string name,
    //        Func<IConnectionMultiplexer> newConnection,
    //        TimeSpan timeout,
    //        bool degradedOnError = false)
    //    {
    //        EnsureValidTimeout(timeout);
    //        healthCheckBuilder.AddCheck(
    //            name,
    //            cancellationToken => ExecuteRedisCheckAsync(name, newConnection, timeout, degradedOnError, cancellationToken));
    //        return healthCheckBuilder.Builder;
    //    }


    //    /// <summary>
    //    /// </summary>
    //    /// <param name="timeout"></param>
    //    private static void EnsureValidTimeout(TimeSpan timeout)
    //    {
    //        if (timeout <= TimeSpan.Zero)
    //        {
    //            throw new InvalidOperationException($"{nameof(timeout)} must be greater than 0");
    //        }
    //    }

    //    /// <summary>
    //    /// </summary>
    //    /// <param name="name"></param>
    //    /// <param name="newConnection"></param>
    //    /// <param name="timeout"></param>
    //    /// <param name="degradedOnError"></param>
    //    /// <param name="cancellationToken"></param>
    //    /// <returns></returns>
    //    private static ValueTask<HealthCheckResult> ExecuteRedisCheckAsync(
    //        string name,
    //        Func<IConnectionMultiplexer> newConnection,
    //        TimeSpan timeout,
    //        bool degradedOnError,
    //        CancellationToken cancellationToken)
    //    {


    //        ValueTask<HealthCheckResult> checkResult = new ValueTask<HealthCheckResult>(
    //            HealthCheckResultOnError("Not Implemented", true));

    //        var sw = new Stopwatch();
    //        try
    //        {
    //            using (var tokenWithTimeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken))
    //            {
    //                tokenWithTimeout.CancelAfter(timeout);


    //                sw.Start();

    //                var _connection = newConnection();
    //                var _cache = _connection.GetDatabase();

    //                var pingResult = _cache.PingAsync(CommandFlags.PreferMaster)
    //                    .GetAwaiter().GetResult();

    //                checkResult = (pingResult > timeout) ?
    //                    new ValueTask<HealthCheckResult>(
    //                        HealthCheckResultOnError(
    //                            $"FAILED. {name} failed. Time taken: {sw.ElapsedMilliseconds}ms.", true
    //                        )
    //                    ) :
    //                    new ValueTask<HealthCheckResult>(
    //                        HealthCheckResult.Healthy(
    //                            $"OK. {name}."
    //                        )
    //                    );

    //                sw.Stop();
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            var failedResult = degradedOnError
    //                ? HealthCheckResult.Degraded(ex)
    //                : HealthCheckResult.Unhealthy(ex);

    //            checkResult = new ValueTask<HealthCheckResult>(failedResult);
    //        }

    //        return checkResult;
    //    }

    //    /// <summary>
    //    /// Create a failure (degraded or unhealthy) status response.
    //    /// </summary>
    //    /// <param name="message">Status message.</param>
    //    /// <param name="degradedOnError">
    //    /// If true, create a degraded status response.
    //    /// Otherwise create an unhealthy status response. (default: false)
    //    /// </param>
    //    /// <returns>Failure status response.</returns>
    //    private static HealthCheckResult HealthCheckResultOnError(string message, bool degradedOnError)
    //    {
    //        return degradedOnError
    //            ? HealthCheckResult.Degraded(message)
    //            : HealthCheckResult.Unhealthy(message);
    //    }
    //}
}
