-- Exercicio 182 Duplicate email
select email from person group by email having count(*) > 1
