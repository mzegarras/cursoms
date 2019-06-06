# 1: Docker build

```
docker build -f Dockerbuild1 -t miguel:2.0.0 .
docker run -p 8085:80 miguel:1.0.0

docker build -f Dockerbuild2 -t miguel:2.0.0 .
docker run -p 8085:8085 miguel:2.0.0

docker build . -t mjava:1.0.0
docker run -p 8085:8080 mjava:1.0.0

```

# 2: Conectarse container
```
docker exec -it a1051285c4ab /bin/sh
cd /usr/share/nginx/html
```
[Settings NGINX](https://docs.docker.com/samples/library/nginx/)
