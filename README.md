# TemplateApi with .Net8
This repository provides a REST API template built with .NET 8, designed to streamline and accelerate the deployment of web services in your daily projects. It includes built-in authorization to secure your endpoints from the start, enabling quick and secure deployment. Perfect for developers seeking a solid, easy-to-configure base for their APIs.

### Structure
└─ .gitignore <br>
└─ ./Services <br>
└─ ./Services/Interfaces <br>
└─ ./Services/Implementations <br>
└─ ./Unitest <br>
└─ ./Controllers <br>
└─ azure-pipelines-acr.yml: pipeline for the Azure Container Registries provider <br>
└─ azure-pipelines-ecr.yml: pipeline for the Aws and Elastic container registry <br>
└─ Dockerfile <br>
└─ README.md <br>

### How to use this repository?
```
dotner run
http://localhost:5142/swagger/index.html
```

## Docker Build

```
docker build -f Dockerfile -t api .
docker run -d -p 8787:80 -e "ASPNETCORE_ENVIRONMENT=Development" --name api api
# test api:
http://localhost:8787/swagger/index.html
```

