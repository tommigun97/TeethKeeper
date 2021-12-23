SELECT F.CodFarmaco, F.Nome
FROM dbo.FARMACO AS F, dbo.ASSUNZIONE_FARMACO AS A, dbo.SCHEDA_CLINICA AS S
WHERE F.CodFarmaco = A.CodFarmaco
AND A.CodPaziente = S.CodPaziente
AND S.CodPaziente = 'GNGNRC97S06D458B'