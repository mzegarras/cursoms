
# 1: bash / sh

```bash
#!/bin/sh
echo "123"
```

```bash
#!/bin/bash
echo "123"
```
# 2: Sistema de archivos

```bash
mkdir /data
cd /data
pwd
echo "miguel" > data.txt
```

```bash
for i in `seq 1 10`;do;echo $i > data_demo.txt;done
for i in `seq 1 10`;do;echo $i >> data_demo.txt;done
tail -3 data_demo.txt
cat data_demo.txt |grep 2
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
r	Permiso de lectura
w	Permiso de escritura
x	Permiso de ejecución
```

===
Lectura tiene el valor de 4
Escritura tiene el valor de 2
Ejecución tiene el valor de 1
