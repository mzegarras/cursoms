# 1: Docker build

```
docker build -f Dockerbuild1 -t miguel:2.0.0 .
docker run -p 8085:80 miguel:1.0.0

docker build -f Dockerbuild2 -t miguel:2.0.0 .
docker run -p 8085:8085 miguel:2.0.0

docker build . -t mjava:1.0.0
docker run -p 8085:8080 mjava:1.0.0

```



# 1: Generar binario


```
dotnet publish -c Release
dotnet publish -c Debug
```

# 2: Generar compose
```
docker-compose build
```
