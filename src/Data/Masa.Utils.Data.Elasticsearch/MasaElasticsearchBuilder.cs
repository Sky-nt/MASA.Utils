﻿namespace Masa.Utils.Data.Elasticsearch;

public class MasaElasticsearchBuilder
{
    public IServiceCollection Services { get; }

    public IElasticClient ElasticClient { get; }

    public IMasaElasticClient Client { get; }

    public MasaElasticsearchBuilder(IServiceCollection services, IElasticClient elasticClient)
    {
        Services = services;
        ElasticClient = elasticClient;
        Client = new DefaultMasaElasticClient(elasticClient);
    }
}
