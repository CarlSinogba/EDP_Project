ALTER USER 'root'@'localhost' IDENTIFIED BY 'carl';
CREATE DATABASE activity2original;
GRANT ALL PRIVILEGES ON activity2original.* TO 'root'@'localhost';
FLUSH PRIVILEGES;