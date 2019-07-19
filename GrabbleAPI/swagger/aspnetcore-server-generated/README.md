# IO.Swagger - ASP.NET Core 2.0 Server

This is the api server for Grabble.  You can find out more about     Grabble at [http://github.com/sguz3m4n/Grabble.git](http://github.com/sguz3m4n/Grabble.git).

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
