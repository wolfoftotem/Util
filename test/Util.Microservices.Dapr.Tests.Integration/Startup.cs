using Util.Logging.Serilog;

namespace Util.Microservices.Dapr.Tests; 

/// <summary>
/// ��������
/// </summary>
public class Startup {
    /// <summary>
    /// ��������
    /// </summary>
    public void ConfigureHost( IHostBuilder hostBuilder ) {
        Util.Helpers.Environment.SetDevelopment();
        hostBuilder.ConfigureDefaults( null )
            .AsBuild()
            .AddSerilog( "Util.Microservices.Dapr.Tests.Integration" )
            .AddDapr(null, builder => {
                builder
                    .UseHttpEndpoint( $"http://127.0.0.1:{Config.GetValue( "DaprPorts:HttpPort" )}" )
                    .UseGrpcEndpoint( $"http://127.0.0.1:{Config.GetValue( "DaprPorts:GrpcPort" )}" );
            } )
            .AddUtil();
    }

    /// <summary>
    /// ���÷���
    /// </summary>
    public void ConfigureServices( IServiceCollection services ) {
        services.AddLogging( logBuilder => logBuilder.AddXunitOutput() );
        Ioc.SetServiceProviderAction( services.BuildServiceProvider );
    }
}