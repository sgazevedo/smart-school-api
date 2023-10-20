CREATE TABLE AlunoDisciplina
    (
     Id BIGINT NOT NULL CONSTRAINT AlunoDisciplina_PK PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
     AlunoId BIGINT CONSTRAINT AlunoDisciplina_Aluno_FK REFERENCES Aluno (Id),
     DisciplinaId BIGINT NOT NULL CONSTRAINT AlunoDisciplina_Disciplina_FK REFERENCES Disciplina (Id),
     DataIni TIMESTAMP NOT NULL , 
     DataFim TIMESTAMP,
     Nota BIGINT
    );
