create database if not exists bd_loja;
use bd_loja;

create table if not exists tb_login(
    id int primary key auto_increment,
    user_id varchar(10),
    password varchar(5)
);

insert into tb_login (user_id,password) values('pedro','teste');