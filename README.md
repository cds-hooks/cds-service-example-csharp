# cds-service-example-csharp

Simple CSharp server that acts as a CDS Service

## Usage
This card service can be deployed with docker. By default, the Dockerfile exposes port 5000. Creating the docker container can be done by:

```bash
$ docker build -t <your-name>/cds-service-example-csharp .
Successfully built <container-id>

$ docker run -p 5000:5000 -d --rm <your-name>/cds-service-example-csharp
```

Alternatively, you run directly on your box with `dnx`.

```base
$ dnu restore
Restore Complete

$ dnx web
Now listening on: http://localhost:5000
Application started. Press Ctrl+C to shut down.
```
