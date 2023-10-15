# .NET7-with-ElasticSearch

## Ordem para iniciar o projeto:

> Crie a imagem do Elastic Search 
```
docker pull docker.elastic.co/elasticsearch/elasticsearch:7.10.0
```
```
docker network create elasticsearchnetwork
```
```
docker run -d --name elasticsearch --net elasticsearchnetwork -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.10.0
```

> Clone o projeto
```
git clone https://github.com/zWalterli/.NET7-with-ElasticSearch.git
```

> Execute o projeto
```
cd .NET7-with-ElasticSearch/Elastic.API && dotnet run
```
