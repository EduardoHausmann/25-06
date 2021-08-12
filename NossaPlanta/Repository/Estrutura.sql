DROP TABLE IF EXISTS plantas;
CREATE TABLE plantas(
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	peso DECIMAL(5,2),
	altura DECIMAL(3,1)
);

INSERT INTO plantas (nome,  peso, altura) 
VALUES ('Dioneia', 5.50, 0.75), 
('Stylidium', 3.50, 1.00),
('Orquidea', 10.50, 1.25);

SELECT * FROM plantas;