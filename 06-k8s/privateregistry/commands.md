
´´´
kubectl create secret docker-registry regcred --docker-server=<your-registry-server> --docker-username=<your-name> --docker-password=<your-pword> --docker-email=<your-email>
´´´

```
kubectl get secret regcred --output=yaml
```
