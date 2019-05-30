
# 1: docker

```docker
docker run nginx
docker ps -a
docker ps -aq
docker stop a1051285c4ab
docker start a1051285c4ab
docker exec -it a1051285c4ab /bin/sh
```

# 2: images

```bash

docker images
docker rmi 3af156432993
docker tag
docker push

docker login --username=yourhubusername --email=youremail@company.com
docker login xxx.azurecr.io
```


# 3: Listar contenido
```bash
ls
ls -lt
ls -lta
```

# 4: Permisos

```bash
-rw-r--r--    1  wada  users  4096 abr 13 19:30 file
drw-r--r--    1  wada  users  4096 abr 13 19:30 file
```

```bash
x-------------x-------------x
|  permisos   |  pertenece  |
x-------------x-------------x
|  rwx------  | usuario     |
|  ---r-x---  | grupo       |
|  ------r-x  | otros       |
x-------------x-------------x
```

```bash
r	Permiso de lectura (4)
w	Permiso de escritura (2)
x	Permiso de ejecución (1)
```

```bash
x-----x-----x-----------------------------------x
| rwx |  7  | Lectura, escritura y ejecución    |
| rw- |  6  | Lectura, escritura        |
| r-x |  5  | Lectura y ejecución       |
| r-- |  4  | Lectura               |
| -wx |  3  | Escritura y ejecución             |
| -w- |  2  | Escritura                         |
| --x |  1  | Ejecución             |
| --- |  0  | Sin permisos          |
x-----x-----x-----------------------------------x
```

# 4: Cambiar permisos y owner
```bash
chmod 400 file
chmod 777 file
```

miguel es owner y clients es el grupo propietario

```bash
chown miguel:clients demo.txt
```

miguel es owner
```bash
chown miguel demo.txt
```
