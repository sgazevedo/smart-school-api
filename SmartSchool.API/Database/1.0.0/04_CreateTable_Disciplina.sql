CREATE TABLE Disciplina 
    (
     Id BIGINT NOT NULL CONSTRAINT Disciplina_PK PRIMARY KEY GENERATED ALWAYS AS IDENTITY,
     Nome VARCHAR (100) NOT NULL , 
     CargaHoraria BIGINT NOT NULL ,
     PrerequisitoId BIGINT CONSTRAINT Disciplina_Disciplina_FK REFERENCES Disciplina (Id),
     ProfessorId BIGINT NOT NULL CONSTRAINT Disciplina_Professor_FK REFERENCES Professor (Id),
     CursoId BIGINT NOT NULL CONSTRAINT Disciplina_Curso_FK REFERENCES Curso (Id)
    );
