---CRIAR a tabela PESSOA---
CREATE TABLE PESSOA (
    PESSOA_ID INT IDENTITY(1,1) PRIMARY KEY,
    NOME_FANTASIA VARCHAR(255) NOT NULL,
    CNPJ_CPF VARCHAR(20) NOT NULL
);

-------------------------------------------------------------

---INSERIR valores ao campos da tabela PESSOA---
INSERT INTO PESSOA (NOME_FANTASIA, CNPJ_CPF) VALUES
('Empresa A', '111.111.111-11'),
('Empresa B', '222.222.222-22'),
('Empresa C', '333.333.333-33'),
('Empresa D', '444.444.444-44'),
('Empresa E', '555.555.555-55'),
('Empresa F', '666.666.666-66'),
('Empresa G', '777.777.777-77'),
('Empresa H', '888.888.888-88'),
('Empresa I', '999.999.999-99'),
('Empresa J', '000.000.000-00');