#!/bin/bash
echo "# Atualizando o servidor! #"
apt-get update
apt-get upgrade -y
apt-get install apache2 -y
apt-get install unzip -y
echo "Copiando os arquivos do site"
cd /tmp
wget https://github.com/GabrielFernella/Dio/Linux/main.zip
unzip main.zip
cd linux-site-dio-main
cp -R * /var/www/html/