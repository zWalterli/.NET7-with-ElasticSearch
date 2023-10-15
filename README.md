# .NET7-with-ElasticSearch


1. docker pull docker.elastic.co/elasticsearch/elasticsearch:7.10.0

2. docker network create elasticsearchnetwork

3. docker run -d --name elasticsearch --net elasticsearchnetwork -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.10.0
