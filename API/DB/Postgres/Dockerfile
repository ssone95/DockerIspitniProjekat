FROM ubuntu:16.04

RUN apt-get update && apt-get install -y wget gnupg


# Kljuc za verifikaciju repozitorijuma
run wget --quiet -O - https://www.postgresql.org/media/keys/ACCC4CF8.asc | apt-key add -

RUN echo "deb http://apt.postgresql.org/pub/repos/apt/ xenial"-pgdg main | tee  /etc/apt/sources.list.d/pgdg.list


RUN apt-get update && apt-get install -y postgresql-11


USER postgres


RUN /etc/init.d/postgresql start &&\
    psql --command "ALTER USER postgres WITH SUPERUSER PASSWORD 'Secret123';"

RUN echo "host all  all    0.0.0.0/0  md5" >> /etc/postgresql/11/main/pg_hba.conf

RUN echo "listen_addresses='*'" >> /etc/postgresql/11/main/postgresql.conf

EXPOSE 5432

VOLUME  ["/etc/postgresql", "/var/log/postgresql", "/var/lib/postgresql"]

CMD ["/usr/lib/postgresql/11/bin/postgres", "-D", "/var/lib/postgresql/11/main", "-c", "config_file=/etc/postgresql/11/main/postgresql.conf"]