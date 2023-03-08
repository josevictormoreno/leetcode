-- Exercicio 182 Duplicate email
select email from person group by email having count(*) > 1

-- Exercicio 175 Combine two table
select p.firstName, p.lastName, a.city, a.state from Person p left join Address a on p.personId = a.personId

-- Exercicio 183 Customers Who never order
SELECT Name as Customers from Customers LEFT JOIN Orders ON Customers.Id = Orders.CustomerId WHERE Orders.CustomerId IS NULL;