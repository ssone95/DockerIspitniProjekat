FROM e2eteam/nginx:1.15-alpine-windows-amd64-1903 AS base
WORKDIR /
#COPY ["C:/nginx/nginx-1.15.12/conf/nginx.conf", "C:/nginx/nginx-1.15.12/conf/nginx.conf.bkp"]
COPY ["API/DB/Nginx/nginx.conf", "C:/nginx/nginx-1.15.12/conf/nginx.conf"]
WORKDIR /nginx/nginx-1.15.12
ENTRYPOINT ["nginx.exe"]