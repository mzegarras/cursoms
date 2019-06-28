

# 1: Build container

```
kubectl create deployment lpsa --image mzegarra/lpsa:1.0
kubectl scale deployments/lpsa --replicas=5
```
