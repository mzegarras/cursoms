kubectl create deployment lpsa --image mzegarra/lpsa:1.0


kubectl scale deployments/lpsa --replicas=5
kubectl expose deployments lpsa --port=80 --type=LoadBalancer


kubectl set image deployments/lpsa lpsa=mzegarra/lpsa:2.0

kubectl get events

kubectl create deployment msjava2 --image msalvadorp/msjavahub:100
kubectl expose deployments msjava2 --port=80 --type=LoadBalancer --target-port 8080

kubectl set image deployments/msjava2 msjava2=msalvadorp/msjavahub:100
kubectl scale deployments/msjava2 --replicas=5
kubectl delete deployments/msjava2
#actualizo la imagen
kubectl set image deployments/msjava2 msjavahub=msalvadorp/msjavahub:200
kubectl get pods -o wide

kubectl edit service/msjava2

kubectl create -f "file.yml"
kubectl delete -f "file.yml"
kubectl apply -f "file.yml"


kubectl get pods -l app=lpsa


kubectl run my-shell --rm -i --tty --image ubuntu -- bash
apt-get update
apt-get install -y curl
apt-get install -y telnet
apt-get install -y dnsutils
apt-get install -y iputils-ping
apt-get install net-tools

===

apiVersion: extensions/v1beta1
kind: Deployment
metadata:
  name: lpsa
spec:
  replicas: 1
  template:
    metadata:
      labels:
        app: lpsa
    spec:
      containers:
      - name: lpsa
        image: mzegarra/lpsa:1.0
        ports:
        - containerPort: 80
---
apiVersion: v1
kind: Service
metadata:
  name: lpsa
  labels:
    app: lpsa
spec:
  ports:
    - port: 80
      protocol: TCP
      targetPort: 80
      name: http-traffic
  selector:
    app: lpsa
  type: LoadBalancer

=====


apiVersion: extensions/v1beta1
kind: Deployment
metadata:
  name: msjava2
spec:
  replicas: 2
  template:
    metadata:
      labels:
        app: msjava2
    spec:
      containers:
      - name: msjava2
        image: msalvadorp/msjavahub:100
        ports:
        - containerPort: 8080
---
apiVersion: v1
kind: Service
metadata:
  name: msjava2
  labels:
    app: lpsa
spec:
  ports:
    - port: 8085
      protocol: TCP
      targetPort: 8080
      name: http-traffic
  selector:
    app: msjava2
  type: LoadBalancer
===



===
apiVersion: v1
kind: Service
metadata:
  name: theshire-customers
  labels:
    app: theshire-customers
spec:
  ports:
    - port: 8080
      targetPort: 8080
  selector:
    app: theshire-customers
  type: ClusterIP
