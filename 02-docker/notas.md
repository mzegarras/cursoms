
# 1: Crear containers

```
docker run nginx
docker run -p 8085:80 nginx
docker run -p 8086:80 nginx:pipeline
docker run -p 8087:80 nginx:latest
docker run -e MYSQL_ROOT_PASSWORD=my-secret-pw -p 3306:3306 mysql:5.7
```

# 2: Listar containers
```
docker ps -a
docker ps -aq
```

# 3: Iniciar y detener containers
```
docker stop a1051285c4ab
docker start a1051285c4ab
```

# 3: Eliminar containers
```
docker rm a1051285c4ab -f
```

# 4: Conectarse container
```
docker exec -it a1051285c4ab /bin/sh
```

# 5: images

```bash

docker images
docker rmi 3af156432993
docker tag
docker push

docker login --username=yourhubusername --email=youremail@company.com
docker login xxx.azurecr.io
```
