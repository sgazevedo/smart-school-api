CREATE TABLE AlunoCurso 
    (
     Id BIGINT NOT NULL CONSTRAINT AlunoCurso_PK PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
     AlunoId BIGINT CONSTRAINT AlunoCurso_Aluno_FK REFERENCES Aluno (Id),
     CursoId BIGINT NOT NULL CONSTRAINT AlunoCurso_Curso_FK REFERENCES Curso (Id),
     DataIni TIMESTAMP NOT NULL , 
     DataFim TIMESTAMP
    );
