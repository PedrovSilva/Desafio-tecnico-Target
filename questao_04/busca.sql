SELECT 
    e.codigo AS CodigoEstado,
    c.razaoSocial AS RazaoSocial,
    t.numero AS Telefone
FROM 
    Cliente c
JOIN 
    Estado e ON c.idEstado = e.idEstado
JOIN 
    Telefone t ON c.idTelefone = t.idTelefone
WHERE 
    e.codigo = 'SP';
