SELECT COUNT(Numero_Aviao) FROM avioes

SELECT * FROM avioes

INSERT INTO avioes (Numero_Aviao, Marca, Modelo, Horas_Total, Horas_Revisao, Capacidade) VALUES (1, "Boeing", "737", 1, 5, 30)

DELETE FROM avioes WHERE Numero_Aviao = 1

SELECT * FROM aeroportos WHERE Pais = "Portugal"

INSERT INTO aeroportos (Codigo, Nome, Latitude, Longitude, `Local`, Pais) VALUES (1, "Aeroport de Lisboa", 15.2, 10.2, "Lisboa", "Portugal")

SELECT VV.Numero_Voo, GROUP_CONCAT(PP.Nome SEPARATOR ', ') AS Passageiros 
FROM passageiros P
LEFT JOIN pessoas PP ON PP.Id = P.Id_Pessoa
LEFT JOIN viagens V ON V.Id_Passageiro = P.Id
LEFT JOIN voo VV ON VV.Numero_Voo = V.N_Voo
WHERE VV.Numero_Voo = 10
GROUP BY VV.Numero_Voo;

SELECT * FROM tripulantes
WHERE Funcao = "Hospedeira"